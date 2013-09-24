using System;
using System.Collections.Generic;

namespace RegisterKeeper.Web.Models.SeedData
{
	public static class IndividualCompetitions
	{
		public static IndividualCompetition TestLiveIndividualCompetition()
		{
			return new IndividualCompetition
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
															new SightingShot {ShotNumber = 1, Score = Score.Five, Converted = true},
															new SightingShot {ShotNumber = 2, Score = Score.V, Converted = true},
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.Four},
															new ScoringShot {ShotNumber = 4},
															new ScoringShot {ShotNumber = 5},
															new ScoringShot {ShotNumber = 6},
															new ScoringShot {ShotNumber = 7},
															new ScoringShot {ShotNumber = 8},
															new ScoringShot {ShotNumber = 9},
															new ScoringShot {ShotNumber = 10}
														}
												},
											new Shoot
												{
													Distance = Distance.x500yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1},
															new ScoringShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 3},
															new ScoringShot {ShotNumber = 4},
															new ScoringShot {ShotNumber = 5},
															new ScoringShot {ShotNumber = 6},
															new ScoringShot {ShotNumber = 7},
															new ScoringShot {ShotNumber = 8},
															new ScoringShot {ShotNumber = 9},
															new ScoringShot {ShotNumber = 10}
														}
												},
											new Shoot
												{
													Distance = Distance.x600yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1},
															new ScoringShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 3},
															new ScoringShot {ShotNumber = 4},
															new ScoringShot {ShotNumber = 5},
															new ScoringShot {ShotNumber = 6},
															new ScoringShot {ShotNumber = 7},
															new ScoringShot {ShotNumber = 8},
															new ScoringShot {ShotNumber = 9},
															new ScoringShot {ShotNumber = 10}
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
															new SightingShot {ShotNumber = 1, Score = Score.Five, Converted = true},
															new SightingShot {ShotNumber = 2, Score = Score.V, Converted = true},
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.Five},
															new ScoringShot {ShotNumber = 4},
															new ScoringShot {ShotNumber = 5},
															new ScoringShot {ShotNumber = 6},
															new ScoringShot {ShotNumber = 7},
															new ScoringShot {ShotNumber = 8},
															new ScoringShot {ShotNumber = 9},
															new ScoringShot {ShotNumber = 10}
														}
												},
											new Shoot
												{
													Distance = Distance.x500yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1},
															new ScoringShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 3},
															new ScoringShot {ShotNumber = 4},
															new ScoringShot {ShotNumber = 5},
															new ScoringShot {ShotNumber = 6},
															new ScoringShot {ShotNumber = 7},
															new ScoringShot {ShotNumber = 8},
															new ScoringShot {ShotNumber = 9},
															new ScoringShot {ShotNumber = 10}
														}
												},
											new Shoot
												{
													Distance = Distance.x600yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1},
															new ScoringShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 3},
															new ScoringShot {ShotNumber = 4},
															new ScoringShot {ShotNumber = 5},
															new ScoringShot {ShotNumber = 6},
															new ScoringShot {ShotNumber = 7},
															new ScoringShot {ShotNumber = 8},
															new ScoringShot {ShotNumber = 9},
															new ScoringShot {ShotNumber = 10}
														}
												}
										}
								}
						}
				};
		}

		public static IndividualCompetition TestUpcomingIndividualCompetition()
		{
			return new IndividualCompetition
				{
					Name = "Test Upcoming Individual Competition",
					StartDateTime = DateTime.Now.AddDays(1),
					EndDateTime = DateTime.Now.AddDays(1).AddHours(1),
					Location = "Test Location",
					Distances = Distance.x900yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 15
				};
		}

		public static IndividualCompetition Alexandra()
		{
			return new IndividualCompetition
				{
					Name = "Alexandra",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 8, 30),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 12, 30),
					Location = "Century Range, Bisley",
					Distances = Distance.x600yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 10
				};
		}

		public static IndividualCompetition ConanDoyle()
		{
			return new IndividualCompetition
				{
					Name = "Conan Doyle",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 9, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 18, 0),
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V}
														}
												}
										}
								},

						}
				};
		}

		public static IndividualCompetition Corporation()
		{
			return new IndividualCompetition
				{
					Name = "Corporation",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Monday, 9, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Monday, 18, 0),
					Location = "Stickledown Range, Bisley",
					Distances = Distance.x1000yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 10
				};
		}
	
		public static IndividualCompetition DailyMail()
		{
			return new IndividualCompetition
				{
					Name = "Daily Mail",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 14, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 18, 0),
					Location = "Century Range, Bisley",
					Distances = Distance.x500yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 15,
					RegisterCards = new List<RegisterCard>()
				};
		}

		public static IndividualCompetition DailyTelegraph()
		{
			return new IndividualCompetition
				{
					Name = "Daily Telegraph",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 14, 0, weekOffset: -1),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 18, 0, weekOffset: -1),
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.Five},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.Five},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.Five},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.Five},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.Five},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.Five}
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
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.Five}
														}
												}
										}
								}
						}
				};
		}

		public static IndividualCompetition DukeOfCambridge()
		{
			return new IndividualCompetition
				{
					Name = "Duke of Cambridge",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 9, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Sunday, 18, 0),
					Location = "Stickledown Range, Bisley",
					Distances = Distance.x900yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 10
				};
		}

		public static IndividualCompetition PrinceOfWales()
		{
			return new IndividualCompetition
				{
					Name = "Prince of Wales",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Thursday, 8, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Thursday, 12, 30),
					Location = "Century Range, Bisley",
					Distances = Distance.x600yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 15
				};
		}

		public static IndividualCompetition QueensFirstStage()
		{
			return new IndividualCompetition
				{
					Name = "Queen's First Stage",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 8, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Wednesday, 18, 0),
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
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},
											new Shoot
												{
													Distance = Distance.x500yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},
											new Shoot
												{
													Distance = Distance.x600yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

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
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.Five},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},
											new Shoot
												{
													Distance = Distance.x500yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},
											new Shoot
												{
													Distance = Distance.x600yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

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
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},
											new Shoot
												{
													Distance = Distance.x500yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},
											new Shoot
												{
													Distance = Distance.x600yds,
													Shots = new List<Shot>
														{
															new SightingShot {ShotNumber = 1},
															new SightingShot {ShotNumber = 2},
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V}

														}
												},

										}
								}
						}
				};
		}

		public static IndividualCompetition StGeorgesFirstStage()
		{
			return new IndividualCompetition
				{
					Name = "St. George's First Stage",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Tuesday, 8, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Tuesday, 12, 30),
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.Five},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V},
															new ScoringShot {ShotNumber = 11, Score = Score.V},
															new ScoringShot {ShotNumber = 12, Score = Score.V},
															new ScoringShot {ShotNumber = 13, Score = Score.V},
															new ScoringShot {ShotNumber = 14, Score = Score.V},
															new ScoringShot {ShotNumber = 15, Score = Score.V}
														}
												}
										}
								},

						}
				};
		}

		public static IndividualCompetition Times()
		{
			return new IndividualCompetition
				{
					Name = "Times",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Monday, 8, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Monday, 12, 30),
					Location = "Century Range, Bisley",
					Distances = Distance.x300yds,
					NumberOfSightingShots = 2,
					NumberOfScoringShots = 10
				};
		}

		public static IndividualCompetition WimbledonTR()
		{
			return new IndividualCompetition
				{
					Name = "Wimbledown TR",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Monday, 14, 0),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Monday, 18, 0),
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.V},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V}
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
															new ScoringShot {ShotNumber = 1, Score = Score.V},
															new ScoringShot {ShotNumber = 2, Score = Score.Five},
															new ScoringShot {ShotNumber = 3, Score = Score.V},
															new ScoringShot {ShotNumber = 4, Score = Score.V},
															new ScoringShot {ShotNumber = 5, Score = Score.V},
															new ScoringShot {ShotNumber = 6, Score = Score.V},
															new ScoringShot {ShotNumber = 7, Score = Score.V},
															new ScoringShot {ShotNumber = 8, Score = Score.V},
															new ScoringShot {ShotNumber = 9, Score = Score.V},
															new ScoringShot {ShotNumber = 10, Score = Score.V}
														}
												}
										}
								},

						}
				};
		}

	}
}