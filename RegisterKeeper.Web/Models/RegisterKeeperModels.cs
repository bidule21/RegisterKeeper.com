using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegisterKeeper.Web.Models
{
	public class Competition
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Display(Name = "Start date & time")]
		[DisplayFormat(DataFormatString = "{0:dd MMMM yyyy HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime StartDateTime { get; set; }

		[Display(Name = "End date & time")]
		[DisplayFormat(DataFormatString = "{0:dd MMMM yyyy HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime EndDateTime { get; set; }

		public string Location { get; set; }

		public Distance Distances { get; set; }

		[Display(Name = "Number of Sighting Shots", ShortName = "Sighters")]
		public int NumberOfSightingShots { get; set; }

		[Display(Name = "Number of Scoring Shots", ShortName = "Shots")]
		public int NumberOfScoringShots { get; set; }
	}

	public class IndividualCompetition : Competition
	{
		public virtual List<IndividualRegisterCard> IndividualRegisterCards { get; set; }
	}

	public class IndividualRegisterCard
	{
		public int Id { get; set; }

		[Required]
		[Display(Name = "Competitor Name")]
		public string CompetitorName { get; set; }

		[Display(Name = "Index Number")]
		public int? CompetitorIndexNumber { get; set; }

		[Display(Name = "Class")]
		public string CompetitorClass { get; set; }

		[Display(Name = "Club")]
		public string CompetitorClub { get; set; }

		public int? IndividualCompetitionId { get; set; }
		public virtual IndividualCompetition IndividualCompetition { get; set; }

		public int? TeamRegisterCardId { get; set; }

		public virtual List<Shoot> Shoots { get; set; }

		public TotalScore TotalScore
		{
			get
			{
				return new TotalScore(Shoots.Select(s => s.TotalScore).ToList());
			}
		}

		public int SortOrder
		{
			get
			{
				// TODO: Implementation for sort order on IndividualRegisterCard
				return 0;
			}
		}
	}

	public class TeamCompetition : Competition
	{
		public virtual List<TeamRegisterCard> TeamRegisterCards { get; set; }
	}

	public class TeamRegisterCard
	{
		public int Id { get; set; }

		[Required]
		[Display(Name = "Team Name")]
		public string TeamName { get; set; }

		[Display(Name = "Team Captain")]
		public string TeamCaptain { get; set; }

		public int TeamCompetitionId { get; set; }
		public virtual TeamCompetition TeamCompetition { get; set; }

		public virtual List<IndividualRegisterCard> IndividualRegisterCards { get; set; }

		public int SortOrder
		{
			get
			{
				// TODO: Implementation for sort order on TeamRegisterCard
				return 0;
			}
		}

		public TotalScore TotalScore
		{
			get { return new TotalScore(IndividualRegisterCards.Select(x => x.TotalScore).ToList()); }
		}

		public TotalScore TotalAt(Distance distance)
		{
			return
				new TotalScore(IndividualRegisterCards
					.Select(x => x.Shoots.Single(s => s.Distance == distance).TotalScore)
					.ToList());
		}
	}

	public class Shoot
	{
		public int Id { get; set; }
		public Distance Distance { get; set; }
		[ForeignKey("ShootId")]
		public virtual List<SightingShot> Sighters { get; set; }
		[ForeignKey("ShootId")]
		public virtual List<ScoringShot> ScoringShots { get; set; }

		public TotalScore TotalScore
		{
			get
			{
				return new TotalScore(ScoringShots);
			}
		}
	}

	public class Shot
	{
		public int Id { get; set; }
		public int ShotNumber { get; set; }
		public Score Score { get; set; }
		public string ScoreHacker
		{
			get
			{
				switch (Score)
				{
					case Score.V:
						return "V";
					case Score.Five:
						return "5";
					case Score.Four:
						return "4";
					case Score.Three:
						return "3";
					case Score.Two:
						return "2";
					case Score.One:
						return "1";
					default:
						return "0";
				}
			}
			set
			{
				switch (value)
				{
					case "V":
					case "v":
						Score = Score.V;
						break;
					case "5":
						Score = Score.Five;
						break;
					case "4":
						Score = Score.Four;
						break;
					case "3":
						Score = Score.Three;
						break;
					case "2":
						Score = Score.Two;
						break;
					case "1":
						Score = Score.One;
						break;
					default:
						Score = Score.Zero;
						break;
				}
			}
		}
		public int ShootId { get; set; }
	}

	public class SightingShot : Shot
	{
		public bool Converted { get; set; }
	}

	public class ScoringShot : Shot { }

	public enum Score
	{
		Zero,
		One,
		Two,
		Three,
		Four,
		Five,
		V
	}

	[Flags]
	public enum Distance
	{
		// ReSharper disable InconsistentNaming
		[Display(Name = "300yds")]
		x300yds = 1,
		[Display(Name = "500yds")]
		x500yds = 2,
		[Display(Name = "600yds")]
		x600yds = 4,
		[Display(Name = "800yds")]
		x800yds = 8,
		[Display(Name = "900yds")]
		x900yds = 16,
		[Display(Name = "1000yds")]
		x1000yds = 32,
		[Display(Name = "800m")]
		x800m = 64,
		[Display(Name = "900m")]
		x900m = 128
		// ReSharper restore InconsistentNaming
	}

	public class TotalScore
	{
		public int Points { get; set; }
		public int VBulls { get; set; }

		public TotalScore(List<ScoringShot> scoringShots)
		{
			Points = scoringShots.Sum(s => (s.Score == Score.V ? 5 : (int)s.Score));
			VBulls = scoringShots.Count(s => s.Score == Score.V);
		}

		public TotalScore(List<TotalScore> totalScores)
		{
			Points = totalScores.Sum(s => s.Points);
			VBulls = totalScores.Sum(s => s.VBulls);
		}

		public override string ToString()
		{
			return Points + "." + VBulls + "v";
		}
	}
}