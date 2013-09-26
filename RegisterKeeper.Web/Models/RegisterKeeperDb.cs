using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;

namespace RegisterKeeper.Web.Models
{
	public class RegisterKeeperDb : DbContext
	{
		public RegisterKeeperDb()
			: base("name=DefaultConnection")
		{ }

		public DbSet<Competition> Competitions { get; set; }
		public DbSet<IndividualCompetition> IndividualCompetitions { get; set; }
		public DbSet<RegisterCard> RegisterCards { get; set; }
		public DbSet<TeamCompetition> TeamCompetitions { get; set; }
		public DbSet<TeamRegisterCard> TeamRegisterCards { get; set; }
		public DbSet<TeamCompetitor> TeamCompetitors { get; set; }
		public DbSet<Shoot> Shoots { get; set; }
		public DbSet<Shot> Shots { get; set; }
		public DbSet<SightingShot> SightingShots { get; set; }

		public DbSet<UserProfile> UserProfiles { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Shoot>().HasOptional(s => s.TeamCompetitor).WithMany(tc => tc.Shoots).WillCascadeOnDelete();
			//modelBuilder.Entity<TeamCompetitor>()
			//	.HasMany(tc => tc.Shoots)
			//	.WithOptional(s => s.TeamCompetitor)
			//	.WillCascadeOnDelete();

			//modelBuilder.Entity<RegisterCard>()
			//	.HasMany(rc => rc.Shoots)
			//	.WithOptional(s => s.RegisterCard)
			//	.WillCascadeOnDelete();
		}
	}

	public class RegisterKeeperDbInitialiser : DropCreateDatabaseAlways<RegisterKeeperDb>
	{
		protected override void Seed(RegisterKeeperDb context)
		{
			var competitions = new List<Competition>
				{
					SeedData.IndividualCompetitions.Alexandra(),
					SeedData.IndividualCompetitions.ConanDoyle(),
					SeedData.IndividualCompetitions.Corporation(),
					SeedData.IndividualCompetitions.DailyMail(),
					SeedData.IndividualCompetitions.DailyTelegraph(),
					SeedData.IndividualCompetitions.DukeOfCambridge(),
					SeedData.IndividualCompetitions.PrinceOfWales(),
					SeedData.IndividualCompetitions.QueensFirstStage(),
					SeedData.IndividualCompetitions.StGeorgesFirstStage(),
					SeedData.IndividualCompetitions.Times(),
					SeedData.IndividualCompetitions.WimbledonTR(),
					
					SeedData.TeamCompetitions.TheKolapore(),
					SeedData.TeamCompetitions.TheMackinnon(),

					
					// TEST DATA

					SeedData.IndividualCompetitions.TestLiveIndividualCompetition(),
					SeedData.IndividualCompetitions.TestUpcomingIndividualCompetition(),

					SeedData.TeamCompetitions.TestLiveTeamCompetition(),
				};

			competitions.ForEach(x => context.Competitions.Add(x));
			context.SaveChanges();

			SeedMembership(context);
		}

		private void SeedMembership(RegisterKeeperDb db)
		{
			//WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);

			//UserProfile user = db.UserProfiles.FirstOrDefault(u => u.UserName.ToLower() == "Tom Hunter");
			//// Check if user already exists
			//if (user == null)
			//{
			//	// Insert name into the profile table
			//	db.UserProfiles.Add(new UserProfile {UserName = model.UserName});
			//	db.SaveChanges();

			//	OAuthWebSecurity.CreateOrUpdateAccount(provider, providerUserId, model.UserName);
			//	OAuthWebSecurity.Login(provider, providerUserId, createPersistentCookie: false);
			//}

		}

		internal static DateTime GetDateTimeInCurrentWeek(DayOfWeek dayOfWeek, int hour, int minute, int weekOffset = 0)
		{
			var date = DateTime.Now.AddDays(7 * weekOffset).Date;
			while (date.DayOfWeek != DayOfWeek.Sunday)
			{
				date = date.AddDays(-1);
			}
			date = date.AddDays((int)dayOfWeek);

			return date.AddHours(hour).AddMinutes(minute);
		}
	}
}