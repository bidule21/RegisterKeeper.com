using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace RegisterKeeper.Web.Models
{
	public class RegisterKeeperDb : DbContext
	{
		public RegisterKeeperDb()
			: base("name=DefaultConnection")
		{ }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<Shoot>().HasOptional(u => u.BillingAddress)
			//						   .WithRequired();

			//modelBuilder.Entity<Shipment>().HasRequired(u => u.DeliveryAddress)
			//							   .WithOptional();

			//modelBuilder.Entity<Shoot>().HasKey(e => e.Id);
			//modelBuilder.Entity<Shot>().HasRequired(e => e.Shoot).WithRequiredDependent();

		}


		public DbSet<Competition> Competitions { get; set; }
		public DbSet<IndividualCompetition> IndividualCompetitions { get; set; }
		public DbSet<RegisterCard> RegisterCards { get; set; }
		public DbSet<TeamCompetition> TeamCompetitions { get; set; }
		public DbSet<TeamRegisterCard> TeamRegisterCards { get; set; }
		public DbSet<TeamCompetitor> TeamCompetitors { get; set; }
		public DbSet<Shoot> Shoots { get; set; }
		public DbSet<Shot> Shots { get; set; }
		public DbSet<SightingShot> SightingShots { get; set; }
	}

	public class RegisterKeeperDbInitialiser : DropCreateDatabaseAlways<RegisterKeeperDb>
	{
		protected override void Seed(RegisterKeeperDb context)
		{
			var competitions = new List<Competition>
				{
					new IndividualCompetition
						{
							Name = "Alexandra",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 8, 30),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 12, 30),
							Location = "Century Range, Bisley",
							Distances = Distance.x600yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10
						},
					new IndividualCompetition
						{
							Name = "Conan Doyle",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 9, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 18, 0),
							Location = "Stickledown Range, Bisley",
							Distances = Distance.x900yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10,
							RegisterCards = new List<RegisterCard>
								{
									new RegisterCard
										{
											CompetitorName = "Dr AJ Pilgrim",
											CompetitorClass = "X",
											CompetitorClub = "NLRC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x900yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr TA Ringer",
											CompetitorClass = "X",
											CompetitorClub = "Uppingham Veterans RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x900yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr CTS Belk",
											CompetitorClass = "X",
											CompetitorClub = "OCRA",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x900yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V }
																}
														}
												}
										},
									
								}
						},
					new IndividualCompetition
						{
							Name = "Corporation",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Monday, 9, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Monday, 18, 0),
							Location = "Stickledown Range, Bisley",
							Distances = Distance.x1000yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10
						},
					new IndividualCompetition
						{
							Name = "Daily Mail",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 14, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 18, 0),
							Location = "Century Range, Bisley",
							Distances = Distance.x500yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 15,
							RegisterCards = new List<RegisterCard>()
						},
					new IndividualCompetition
						{
							Name = "Daily Telegraph",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 14, 0, weekOffset: -1),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 18, 0, weekOffset: -1),
							Location = "Century Range, Bisley",
							Distances = Distance.x500yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 15,
							RegisterCards = new List<RegisterCard>
								{
									new RegisterCard
										{
											CompetitorName = "Mr GE Morris",
											CompetitorClass = "X",
											CompetitorClub = "Uppingham Veterans RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr JA Haward",
											CompetitorClass = "X",
											CompetitorClub = "Exonia & Tiverton RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr R Birtwistle",
											CompetitorClass = "X",
											CompetitorClub = "Manydown RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.Five }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr BJ Wood",
											CompetitorClass = "O",
											CompetitorClub = "Katandra RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.Five }
																}
														}
												}
										}
								}
						},
					new IndividualCompetition
						{
							Name = "Duke of Cambridge",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 9, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 18, 0),
							Location = "Stickledown Range, Bisley",
							Distances = Distance.x900yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10
						},
					new IndividualCompetition
						{
							Name = "Prince of Wales",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Thursday, 8, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Thursday, 12, 30),
							Location = "Century Range, Bisley",
							Distances = Distance.x600yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 15
						},
					new IndividualCompetition
						{
							Name = "Queen's First Stage",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 8, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 18, 0),
							Location = "Century Range, Bisley",
							Distances = Distance.x300yds | Distance.x500yds | Distance.x600yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 7,
							RegisterCards = new List<RegisterCard>
								{
									new RegisterCard
										{
											CompetitorName = "Mr P Patel",
											CompetitorClass = "X",
											CompetitorClub = "Old Epsomian RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.V},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.Five},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.V},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr GE Morris",
											CompetitorClass = "X",
											CompetitorClub = "Uppingham Veterans RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.Five},
																	new ScoringShot{ShotNumber = 2, Score = Score.Five},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.V},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.V},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr S Osmond",
											CompetitorClass = "A",
											CompetitorClub = "LMRA",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.Five},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.Five},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ShotNumber = 1, Score = Score.V},
																	new ScoringShot{ShotNumber = 2, Score = Score.V},
																	new ScoringShot{ShotNumber = 3, Score = Score.V},
																	new ScoringShot{ShotNumber = 4, Score = Score.V},
																	new ScoringShot{ShotNumber = 5, Score = Score.V},
																	new ScoringShot{ShotNumber = 6, Score = Score.V},
																	new ScoringShot{ShotNumber = 7, Score = Score.V}

																}
														},
													
												}
										}
								}
						},
					new IndividualCompetition
						{
							Name = "St. George's First Stage",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Tuesday, 8, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Tuesday, 12, 30),
							Location = "Century Range, Bisley",
							Distances = Distance.x300yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 15,
							RegisterCards = new List<RegisterCard>
								{
									new RegisterCard
										{
											CompetitorName = "Mr JG Du Toit",
											CompetitorClass = "X",
											CompetitorClub = "Witwatersrand",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr DGP Vamplew",
											CompetitorClass = "X",
											CompetitorClub = "DCRA",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr PJ Chapman-Sheath",
											CompetitorClass = "X",
											CompetitorClub = "NLRC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V },
																	new ScoringShot{ ShotNumber = 11, Score = Score.V },
																	new ScoringShot{ ShotNumber = 12, Score = Score.V },
																	new ScoringShot{ ShotNumber = 13, Score = Score.V },
																	new ScoringShot{ ShotNumber = 14, Score = Score.V },
																	new ScoringShot{ ShotNumber = 15, Score = Score.V }
																}
														}
												}
										},
									
								}
						},
					new IndividualCompetition
						{
							Name = "Times",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Monday, 8, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Monday, 12, 30),
							Location = "Century Range, Bisley",
							Distances = Distance.x300yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10
						},
					new IndividualCompetition
						{
							Name = "Wimbledown TR",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Monday, 14, 0),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Monday, 18, 0),
							Location = "Century Range, Bisley",
							Distances = Distance.x600yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10,
							RegisterCards = new List<RegisterCard>
								{
									new RegisterCard
										{
											CompetitorName = "Mr RA Jobson",
											CompetitorClass = "O",
											CompetitorClub = "Cornwall RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Mr D Rose",
											CompetitorClass = "X",
											CompetitorClub = "Old Epsomian RC",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Cadet OS Marshall",
											CompetitorClass = "A",
											CompetitorClub = "Victoria College",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new ScoringShot{ ShotNumber = 1, Score = Score.V },
																	new ScoringShot{ ShotNumber = 2, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 3, Score = Score.V },
																	new ScoringShot{ ShotNumber = 4, Score = Score.V },
																	new ScoringShot{ ShotNumber = 5, Score = Score.V },
																	new ScoringShot{ ShotNumber = 6, Score = Score.V },
																	new ScoringShot{ ShotNumber = 7, Score = Score.V },
																	new ScoringShot{ ShotNumber = 8, Score = Score.V },
																	new ScoringShot{ ShotNumber = 9, Score = Score.V },
																	new ScoringShot{ ShotNumber = 10, Score = Score.V }
																}
														}
												}
										},
									
								}
						},

					
					// TEST DATA

					new IndividualCompetition
						{
							Name = "Test Live Individual Competition",
							StartDateTime = DateTime.Now,
							EndDateTime = DateTime.Now.AddDays(1),
							Location = "Test Location",
							Distances = Distance.x300yds | Distance.x500yds | Distance.x600yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 10,
							RegisterCards = new List<RegisterCard>
								{
									new RegisterCard
										{
											CompetitorName = "Test Competitor",
											CompetitorIndexNumber = 123,
											CompetitorClass = "X",
											CompetitorClub = "Test Club",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new SightingShot{ ShotNumber = 1, Score = Score.Five, Converted = true},
																	new SightingShot{ ShotNumber = 2, Score = Score.V, Converted = true},
																	new ScoringShot{ ShotNumber = 1, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.Four },
																	new ScoringShot{ ShotNumber = 4 },
																	new ScoringShot{ ShotNumber = 5 },
																	new ScoringShot{ ShotNumber = 6 },
																	new ScoringShot{ ShotNumber = 7 },
																	new ScoringShot{ ShotNumber = 8 },
																	new ScoringShot{ ShotNumber = 9 },
																	new ScoringShot{ ShotNumber = 10 }
																}
														},
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new SightingShot{ ShotNumber = 1 },
																	new SightingShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 1 },
																	new ScoringShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 3 },
																	new ScoringShot{ ShotNumber = 4 },
																	new ScoringShot{ ShotNumber = 5 },
																	new ScoringShot{ ShotNumber = 6 },
																	new ScoringShot{ ShotNumber = 7 },
																	new ScoringShot{ ShotNumber = 8 },
																	new ScoringShot{ ShotNumber = 9 },
																	new ScoringShot{ ShotNumber = 10 }
																}
														},
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new SightingShot{ ShotNumber = 1 },
																	new SightingShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 1 },
																	new ScoringShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 3 },
																	new ScoringShot{ ShotNumber = 4 },
																	new ScoringShot{ ShotNumber = 5 },
																	new ScoringShot{ ShotNumber = 6 },
																	new ScoringShot{ ShotNumber = 7 },
																	new ScoringShot{ ShotNumber = 8 },
																	new ScoringShot{ ShotNumber = 9 },
																	new ScoringShot{ ShotNumber = 10 }
																}
														}
												}
										},
									new RegisterCard
										{
											CompetitorName = "Another Competitor",
											CompetitorIndexNumber = 456,
											CompetitorClass = "A",
											CompetitorClub = "Test Club",
											Shoots = new List<Shoot>
												{
													new Shoot
														{
															Distance = Distance.x300yds,
															Shots = new List<Shot>
																{
																	new SightingShot{ ShotNumber = 1, Score = Score.Five, Converted = true},
																	new SightingShot{ ShotNumber = 2, Score = Score.V, Converted = true},
																	new ScoringShot{ ShotNumber = 1, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 2, Score = Score.V },
																	new ScoringShot{ ShotNumber = 3, Score = Score.Five },
																	new ScoringShot{ ShotNumber = 4 },
																	new ScoringShot{ ShotNumber = 5 },
																	new ScoringShot{ ShotNumber = 6 },
																	new ScoringShot{ ShotNumber = 7 },
																	new ScoringShot{ ShotNumber = 8 },
																	new ScoringShot{ ShotNumber = 9 },
																	new ScoringShot{ ShotNumber = 10 }
																}
														},
													new Shoot
														{
															Distance = Distance.x500yds,
															Shots = new List<Shot>
																{
																	new SightingShot{ ShotNumber = 1 },
																	new SightingShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 1 },
																	new ScoringShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 3 },
																	new ScoringShot{ ShotNumber = 4 },
																	new ScoringShot{ ShotNumber = 5 },
																	new ScoringShot{ ShotNumber = 6 },
																	new ScoringShot{ ShotNumber = 7 },
																	new ScoringShot{ ShotNumber = 8 },
																	new ScoringShot{ ShotNumber = 9 },
																	new ScoringShot{ ShotNumber = 10 }
																}
														},
													new Shoot
														{
															Distance = Distance.x600yds,
															Shots = new List<Shot>
																{
																	new SightingShot{ ShotNumber = 1 },
																	new SightingShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 1 },
																	new ScoringShot{ ShotNumber = 2 },
																	new ScoringShot{ ShotNumber = 3 },
																	new ScoringShot{ ShotNumber = 4 },
																	new ScoringShot{ ShotNumber = 5 },
																	new ScoringShot{ ShotNumber = 6 },
																	new ScoringShot{ ShotNumber = 7 },
																	new ScoringShot{ ShotNumber = 8 },
																	new ScoringShot{ ShotNumber = 9 },
																	new ScoringShot{ ShotNumber = 10 }
																}
														}
												}
										}
								}
						},
					new TeamCompetition
						{
							Name = "Test Live Team Competition",
							StartDateTime = DateTime.Now,
							EndDateTime = DateTime.Now.AddDays(1),
							Location = "Test Location",
							Distances = Distance.x900yds | Distance.x1000yds,
							NumberOfSightingShots = 1,
							NumberOfScoringShots = 10
						},
					
					new IndividualCompetition
						{
							Name = "Test Upcoming Individual Competition",
							StartDateTime = DateTime.Now.AddDays(1),
							EndDateTime = DateTime.Now.AddDays(1).AddHours(1),
							Location = "Test Location",
							Distances = Distance.x900yds,
							NumberOfSightingShots = 2,
							NumberOfScoringShots = 15
						},

					new TeamCompetition
						{
							Name = "The Kolapore",
							StartDateTime = DateTime.Now,
							EndDateTime = DateTime.Now.AddHours(1),
							Location = "Century Range, Bisley",
							Distances = Distance.x300yds | Distance.x500yds | Distance.x600yds,
							NumberOfSightingShots = 1,
							NumberOfScoringShots = 10,
							TeamRegisterCards = new List<TeamRegisterCard>
								{
									new TeamRegisterCard
										{
											TeamName = "Great Britain",
											TeamCaptain = "Dr JD Warburton",
											Firers = new List<TeamCompetitor>
												{
													new TeamCompetitor
														{
															CompetitorName = "Mr JA Watson",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.V },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr GE Morris",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Dr GCD Barnett",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.V },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr SA Thomas",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr TJD Raincock",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr DC Luckman",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.V },
																					new ScoringShot { ShotNumber = 2, Score = Score.V },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr P Patel",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Miss JM Rankin",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													
												}
										},
									new TeamRegisterCard
										{
											TeamName = "Australia",
											TeamCaptain = "Mr GE Grosskreutz",
											Firers = new List<TeamCompetitor>
												{
													new TeamCompetitor
														{
															CompetitorName = "Mr JP Bailey",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.V },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.V },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr J Corbett",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr MI Buchanan",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr RA Bale",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr DR Cadden",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Lt RK Whalen",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.V },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Miss JL Bale",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Four },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Five },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.Five },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Four },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr SM Negus",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x300yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Four },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.Five },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x500yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Five },
																					new ScoringShot { ShotNumber = 3, Score = Score.Five },
																					new ScoringShot { ShotNumber = 4, Score = Score.V },
																					new ScoringShot { ShotNumber = 5, Score = Score.V },
																					new ScoringShot { ShotNumber = 6, Score = Score.V },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x600yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot { ShotNumber = 1, Score = Score.Four },
																					new ScoringShot { ShotNumber = 2, Score = Score.Four },
																					new ScoringShot { ShotNumber = 3, Score = Score.Four },
																					new ScoringShot { ShotNumber = 4, Score = Score.Five },
																					new ScoringShot { ShotNumber = 5, Score = Score.Five },
																					new ScoringShot { ShotNumber = 6, Score = Score.Five },
																					new ScoringShot { ShotNumber = 7, Score = Score.V },
																					new ScoringShot { ShotNumber = 8, Score = Score.V },
																					new ScoringShot { ShotNumber = 9, Score = Score.V },
																					new ScoringShot { ShotNumber = 10, Score = Score.V }
																				}
																		}
																}
														},
													
												}
										},
									
								}
						},

					new TeamCompetition
						{
							Name = "The Mackinnon",
							StartDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 10, 0, weekOffset:-1),
							EndDateTime = GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 12, 0, weekOffset:-1),
							Location = "Stickledown, Bisley",
							Distances = Distance.x900yds | Distance.x1000yds,
							NumberOfSightingShots = 1,
							NumberOfScoringShots = 10,
							TeamRegisterCards = new List<TeamRegisterCard>
								{
									new TeamRegisterCard
										{
											TeamName = "Australia",
											TeamCaptain = "Mr GE Grosskreutz",
											Firers = new List<TeamCompetitor>
												{
													new TeamCompetitor
														{
															CompetitorName = "Mr J Corbett",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.V},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr MI Buchanan",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.V},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr PA Collins",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr JP Bailey",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.V},
																					new ScoringShot{ShotNumber = 2, Score = Score.V},
																					new ScoringShot{ShotNumber = 3, Score = Score.V},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Lt RK Whalen",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr DR Cadden",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr SM Negus",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Four},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Miss SL Hayes",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.V},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr GE Grosskreutz",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.Five},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr EI Cartwright",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Four},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Mr RA Bale",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Five},
																					new ScoringShot{ShotNumber = 2, Score = Score.Five},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.V},
																					new ScoringShot{ShotNumber = 6, Score = Score.V},
																					new ScoringShot{ShotNumber = 7, Score = Score.V},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Four},
																					new ScoringShot{ShotNumber = 4, Score = Score.Four},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.Five},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														},
													new TeamCompetitor
														{
															CompetitorName = "Miss JL Bale",
															Shoots = new List<Shoot>
																{
																	new Shoot
																		{
																			Distance = Distance.x900yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Five},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.Five},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		},
																	new Shoot
																		{
																			Distance = Distance.x1000yds,
																			Shots = new List<Shot>
																				{
																					new ScoringShot{ShotNumber = 1, Score = Score.Four},
																					new ScoringShot{ShotNumber = 2, Score = Score.Four},
																					new ScoringShot{ShotNumber = 3, Score = Score.Four},
																					new ScoringShot{ShotNumber = 4, Score = Score.Five},
																					new ScoringShot{ShotNumber = 5, Score = Score.Five},
																					new ScoringShot{ShotNumber = 6, Score = Score.Five},
																					new ScoringShot{ShotNumber = 7, Score = Score.Five},
																					new ScoringShot{ShotNumber = 8, Score = Score.V},
																					new ScoringShot{ShotNumber = 9, Score = Score.V},
																					new ScoringShot{ShotNumber = 10, Score = Score.V}
																				}
																		}
																}
														}
												}
										}
								}
						}
				};

			competitions.ForEach(x => context.Competitions.Add(x));
			context.SaveChanges();
		}

		private static DateTime GetDateTimeInCurrentWeek(DayOfWeek dayOfWeek, int hour, int minute, int weekOffset = 0)
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