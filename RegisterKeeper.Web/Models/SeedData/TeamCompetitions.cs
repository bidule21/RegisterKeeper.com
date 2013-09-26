using System;
using System.Collections.Generic;

namespace RegisterKeeper.Web.Models.SeedData
{
	public static class TeamCompetitions
	{
		public static TeamCompetition TestLiveTeamCompetition()
		{
			return new TeamCompetition
				{
					Name = "Test Live Team Competition",
					StartDateTime = DateTime.Now,
					EndDateTime = DateTime.Now.AddDays(1),
					Location = "Test Location",
					Distances = Distance.x900yds | Distance.x1000yds,
					NumberOfSightingShots = 1,
					NumberOfScoringShots = 10,
					TeamRegisterCards = new List<TeamRegisterCard>
						{
							new TeamRegisterCard
								{
									TeamName = "Test Team 1",
									TeamCompetitors = new List<TeamCompetitor>
										{
											new TeamCompetitor
												{
													CompetitorName = "Test Competitor 1",
													Shoots = new List<Shoot>
														{
															new Shoot
																{
																	Distance = Distance.x900yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot
																				{
																					ShotNumber = 1,
																					ScoreText = "V",
																					Converted = true
																				},
																			new ScoringShot
																				{
																					ShotNumber = 1,
																					ScoreText = "5"
																				},
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
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot { ShotNumber = 1 },
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
								}
						}
				};
		}

		public static TeamCompetition TheKolapore()
		{
			return new TeamCompetition
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
									TeamCompetitors = new List<TeamCompetitor>
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
																			new SightingShot {ShotNumber = 1},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
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
								},
							new TeamRegisterCard
								{
									TeamName = "Australia",
									TeamCaptain = "Mr GE Grosskreutz",
									TeamCompetitors = new List<TeamCompetitor>
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
																			new SightingShot {ShotNumber = 1},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
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
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
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
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x500yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x600yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot {ShotNumber = 1},
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																}
														}
												},

										}
								},

						}
				};
		}

		public static TeamCompetition TheMackinnon()
		{
			return new TeamCompetition
				{
					Name = "The Mackinnon",
					StartDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 10, 0, weekOffset: -1),
					EndDateTime = RegisterKeeperDbInitialiser.GetDateTimeInCurrentWeek(DayOfWeek.Saturday, 12, 0, weekOffset: -1),
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
									TeamCompetitors = new List<TeamCompetitor>
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
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
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.V},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.Five},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Five},
																			new ScoringShot {ShotNumber = 2, Score = Score.Five},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.V},
																			new ScoringShot {ShotNumber = 6, Score = Score.V},
																			new ScoringShot {ShotNumber = 7, Score = Score.V},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Four},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.Five},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
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
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Five},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.Five},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																},
															new Shoot
																{
																	Distance = Distance.x1000yds,
																	Shots = new List<Shot>
																		{
																			new SightingShot { ShotNumber = 1 },
																			new ScoringShot {ShotNumber = 1, Score = Score.Four},
																			new ScoringShot {ShotNumber = 2, Score = Score.Four},
																			new ScoringShot {ShotNumber = 3, Score = Score.Four},
																			new ScoringShot {ShotNumber = 4, Score = Score.Five},
																			new ScoringShot {ShotNumber = 5, Score = Score.Five},
																			new ScoringShot {ShotNumber = 6, Score = Score.Five},
																			new ScoringShot {ShotNumber = 7, Score = Score.Five},
																			new ScoringShot {ShotNumber = 8, Score = Score.V},
																			new ScoringShot {ShotNumber = 9, Score = Score.V},
																			new ScoringShot {ShotNumber = 10, Score = Score.V}
																		}
																}
														}
												}
										}
								}
						}
				};
		}
	}
}