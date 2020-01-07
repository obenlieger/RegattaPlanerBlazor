using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegattaPlanerBlazor.Data.Migrations
{
    public partial class RegattaInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boatclasses",
                columns: table => new
                {
                    BoatclassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Seats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boatclasses", x => x.BoatclassId);
                });

            migrationBuilder.CreateTable(
                name: "CampingFees",
                columns: table => new
                {
                    CampingFeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Amount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampingFees", x => x.CampingFeeId);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    VNr = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubId);
                });

            migrationBuilder.CreateTable(
                name: "DeletedStartboats",
                columns: table => new
                {
                    DeletedStartboatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportedStartboatId = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    deleteDate = table.Column<DateTime>(nullable: false),
                    wasLate = table.Column<bool>(nullable: false),
                    ClubId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false),
                    ReportedRaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedStartboats", x => x.DeletedStartboatId);
                });

            migrationBuilder.CreateTable(
                name: "Oldclasses",
                columns: table => new
                {
                    OldclassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FromAge = table.Column<int>(nullable: false),
                    ToAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oldclasses", x => x.OldclassId);
                });

            migrationBuilder.CreateTable(
                name: "Raceclasses",
                columns: table => new
                {
                    RaceclassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raceclasses", x => x.RaceclassId);
                });

            migrationBuilder.CreateTable(
                name: "RaceDraws",
                columns: table => new
                {
                    RaceDrawId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isAbteilungslauf = table.Column<bool>(nullable: false),
                    ReportedSBCountFrom = table.Column<int>(nullable: false),
                    ReportedSBCountTo = table.Column<int>(nullable: false),
                    VorlaufCount = table.Column<int>(nullable: false),
                    HoffnungslaufCount = table.Column<int>(nullable: false),
                    ZwischenlaufCount = table.Column<int>(nullable: false),
                    EndlaufCount = table.Column<int>(nullable: false),
                    RaceLength = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceDraws", x => x.RaceDrawId);
                });

            migrationBuilder.CreateTable(
                name: "Racestati",
                columns: table => new
                {
                    RacestatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racestati", x => x.RacestatusId);
                });

            migrationBuilder.CreateTable(
                name: "RaceTyps",
                columns: table => new
                {
                    RaceTypId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    isFinal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTyps", x => x.RaceTypId);
                });

            migrationBuilder.CreateTable(
                name: "RRFreeStartslots",
                columns: table => new
                {
                    RRFreeStartslotsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportedRaceId = table.Column<int>(nullable: false),
                    FreeStartslots = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRFreeStartslots", x => x.RRFreeStartslotsId);
                });

            migrationBuilder.CreateTable(
                name: "Startboatstati",
                columns: table => new
                {
                    StartboatstatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Startboatstati", x => x.StartboatstatusId);
                });

            migrationBuilder.CreateTable(
                name: "Waters",
                columns: table => new
                {
                    WaterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waters", x => x.WaterId);
                });

            migrationBuilder.CreateTable(
                name: "ClubCampingFees",
                columns: table => new
                {
                    CampingFeeId = table.Column<int>(nullable: false),
                    ClubId = table.Column<int>(nullable: false),
                    ClubCampingFeeId = table.Column<int>(nullable: false),
                    campingcount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubCampingFees", x => new { x.CampingFeeId, x.ClubId });
                    table.ForeignKey(
                        name: "FK_ClubCampingFees_CampingFees_CampingFeeId",
                        column: x => x.CampingFeeId,
                        principalTable: "CampingFees",
                        principalColumn: "CampingFeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClubCampingFees_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Birthyear = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    isRented = table.Column<bool>(nullable: false),
                    RentedToClubId = table.Column<int>(nullable: false),
                    RentYear = table.Column<int>(nullable: false),
                    ClubId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Members_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartingFees",
                columns: table => new
                {
                    StartingFeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<float>(nullable: false),
                    BoatclassId = table.Column<int>(nullable: false),
                    FromOldclassId = table.Column<int>(nullable: false),
                    ToOldclassId = table.Column<int>(nullable: false),
                    OldclassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartingFees", x => x.StartingFeeId);
                    table.ForeignKey(
                        name: "FK_StartingFees_Boatclasses_BoatclassId",
                        column: x => x.BoatclassId,
                        principalTable: "Boatclasses",
                        principalColumn: "BoatclassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StartingFees_Oldclasses_OldclassId",
                        column: x => x.OldclassId,
                        principalTable: "Oldclasses",
                        principalColumn: "OldclassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoatclassId = table.Column<int>(nullable: false),
                    RaceclassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => x.CompetitionId);
                    table.ForeignKey(
                        name: "FK_Competitions_Boatclasses_BoatclassId",
                        column: x => x.BoatclassId,
                        principalTable: "Boatclasses",
                        principalColumn: "BoatclassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Competitions_Raceclasses_RaceclassId",
                        column: x => x.RaceclassId,
                        principalTable: "Raceclasses",
                        principalColumn: "RaceclassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceDrawRules",
                columns: table => new
                {
                    RaceDrawRuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceDrawId = table.Column<int>(nullable: false),
                    RaceTypId = table.Column<int>(nullable: false),
                    RaceSequence = table.Column<int>(nullable: false),
                    PlacementFrom = table.Column<int>(nullable: false),
                    PlacementTo = table.Column<int>(nullable: false),
                    ToRaceTypId = table.Column<int>(nullable: false),
                    ToRaceSequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceDrawRules", x => x.RaceDrawRuleId);
                    table.ForeignKey(
                        name: "FK_RaceDrawRules_RaceDraws_RaceDrawId",
                        column: x => x.RaceDrawId,
                        principalTable: "RaceDraws",
                        principalColumn: "RaceDrawId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceDrawRules_RaceTyps_RaceTypId",
                        column: x => x.RaceTypId,
                        principalTable: "RaceTyps",
                        principalColumn: "RaceTypId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regattas",
                columns: table => new
                {
                    RegattaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Choosen = table.Column<bool>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    Waterdepth = table.Column<int>(nullable: false),
                    Startslots = table.Column<int>(nullable: false),
                    ReportText = table.Column<string>(nullable: true),
                    ReportOpening = table.Column<DateTime>(nullable: false),
                    ReportSchedule = table.Column<DateTime>(nullable: false),
                    ReportAddress = table.Column<string>(nullable: true),
                    ReportTel = table.Column<string>(nullable: true),
                    ReportFax = table.Column<string>(nullable: true),
                    ReportMail = table.Column<string>(nullable: true),
                    Judge = table.Column<string>(nullable: true),
                    Awards = table.Column<string>(nullable: true),
                    Security = table.Column<string>(nullable: true),
                    ScheduleText = table.Column<string>(nullable: true),
                    SubscriberFee = table.Column<float>(nullable: false),
                    Accomodation = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Catering = table.Column<string>(nullable: true),
                    Organizer = table.Column<string>(nullable: true),
                    StartersLastYear = table.Column<int>(nullable: false),
                    ClubId = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    WaterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regattas", x => x.RegattaId);
                    table.ForeignKey(
                        name: "FK_Regattas_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Regattas_Waters_WaterId",
                        column: x => x.WaterId,
                        principalTable: "Waters",
                        principalColumn: "WaterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starttime = table.Column<DateTime>(nullable: false),
                    Realstarttime = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Spoken = table.Column<bool>(nullable: false),
                    ResultSpoken = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    RaceCode = table.Column<string>(nullable: true),
                    FinishType = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    RegattaId = table.Column<int>(nullable: false),
                    RaceclassId = table.Column<int>(nullable: false),
                    OldclassId = table.Column<int>(nullable: false),
                    BoatclassId = table.Column<int>(nullable: false),
                    RacestatusId = table.Column<int>(nullable: false),
                    isAbteilungslauf = table.Column<bool>(nullable: false),
                    RaceTypId = table.Column<int>(nullable: false),
                    ReportedRaceId = table.Column<int>(nullable: false),
                    RaceDrawId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Races_Boatclasses_BoatclassId",
                        column: x => x.BoatclassId,
                        principalTable: "Boatclasses",
                        principalColumn: "BoatclassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Oldclasses_OldclassId",
                        column: x => x.OldclassId,
                        principalTable: "Oldclasses",
                        principalColumn: "OldclassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_RaceTyps_RaceTypId",
                        column: x => x.RaceTypId,
                        principalTable: "RaceTyps",
                        principalColumn: "RaceTypId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Raceclasses_RaceclassId",
                        column: x => x.RaceclassId,
                        principalTable: "Raceclasses",
                        principalColumn: "RaceclassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Racestati_RacestatusId",
                        column: x => x.RacestatusId,
                        principalTable: "Racestati",
                        principalColumn: "RacestatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegattaCampingFees",
                columns: table => new
                {
                    CampingFeeId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegattaCampingFees", x => new { x.CampingFeeId, x.RegattaId });
                    table.ForeignKey(
                        name: "FK_RegattaCampingFees_CampingFees_CampingFeeId",
                        column: x => x.CampingFeeId,
                        principalTable: "CampingFees",
                        principalColumn: "CampingFeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegattaCampingFees_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegattaClubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false),
                    Guid = table.Column<string>(nullable: true),
                    Invited = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegattaClubs", x => new { x.ClubId, x.RegattaId });
                    table.ForeignKey(
                        name: "FK_RegattaClubs_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegattaClubs_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegattaCompetitions",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegattaCompetitions", x => new { x.CompetitionId, x.RegattaId });
                    table.ForeignKey(
                        name: "FK_RegattaCompetitions_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegattaCompetitions_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegattaOldclasses",
                columns: table => new
                {
                    OldclassId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegattaOldclasses", x => new { x.OldclassId, x.RegattaId });
                    table.ForeignKey(
                        name: "FK_RegattaOldclasses_Oldclasses_OldclassId",
                        column: x => x.OldclassId,
                        principalTable: "Oldclasses",
                        principalColumn: "OldclassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegattaOldclasses_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegattaStartingFees",
                columns: table => new
                {
                    StartingFeeId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegattaStartingFees", x => new { x.StartingFeeId, x.RegattaId });
                    table.ForeignKey(
                        name: "FK_RegattaStartingFees_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegattaStartingFees_StartingFees_StartingFeeId",
                        column: x => x.StartingFeeId,
                        principalTable: "StartingFees",
                        principalColumn: "StartingFeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportedRaces",
                columns: table => new
                {
                    ReportedRaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modifiedDate = table.Column<DateTime>(nullable: false),
                    isCreated = table.Column<bool>(nullable: false),
                    StartboatCount = table.Column<int>(nullable: false),
                    isAbteilungslauf = table.Column<bool>(nullable: false),
                    OldclassId = table.Column<int>(nullable: false),
                    CompetitionId = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    RaceCode = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    FreeStartslots = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedRaces", x => x.ReportedRaceId);
                    table.ForeignKey(
                        name: "FK_ReportedRaces_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportedRaces_Oldclasses_OldclassId",
                        column: x => x.OldclassId,
                        principalTable: "Oldclasses",
                        principalColumn: "OldclassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportedRaces_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReportedStartboats",
                columns: table => new
                {
                    ReportedStartboatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(nullable: true),
                    modifiedDate = table.Column<DateTime>(nullable: false),
                    isLate = table.Column<bool>(nullable: false),
                    NoStartslot = table.Column<bool>(nullable: false),
                    ClubId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false),
                    ReportedRaceId = table.Column<int>(nullable: false),
                    CompetitionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedStartboats", x => x.ReportedStartboatId);
                    table.ForeignKey(
                        name: "FK_ReportedStartboats_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportedStartboats_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportedStartboats_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportedStartboats_ReportedRaces_ReportedRaceId",
                        column: x => x.ReportedRaceId,
                        principalTable: "ReportedRaces",
                        principalColumn: "ReportedRaceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReportedStartboatMembers",
                columns: table => new
                {
                    ReportedStartboatId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Seatnumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedStartboatMembers", x => new { x.ReportedStartboatId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_ReportedStartboatMembers_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportedStartboatMembers_ReportedStartboats_ReportedStartboatId",
                        column: x => x.ReportedStartboatId,
                        principalTable: "ReportedStartboats",
                        principalColumn: "ReportedStartboatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportedStartboatStandbys",
                columns: table => new
                {
                    ReportedStartboatId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Standbynumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportedStartboatStandbys", x => new { x.ReportedStartboatId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_ReportedStartboatStandbys_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReportedStartboatStandbys_ReportedStartboats_ReportedStartboatId",
                        column: x => x.ReportedStartboatId,
                        principalTable: "ReportedStartboats",
                        principalColumn: "ReportedStartboatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Startboats",
                columns: table => new
                {
                    StartboatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Startslot = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Placement = table.Column<int>(nullable: false),
                    FinishTime = table.Column<DateTime>(nullable: false),
                    ClubId = table.Column<int>(nullable: false),
                    RaceId = table.Column<int>(nullable: false),
                    StartboatstatusId = table.Column<int>(nullable: false),
                    ReportedStartboatId = table.Column<int>(nullable: false),
                    RegattaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Startboats", x => x.StartboatId);
                    table.ForeignKey(
                        name: "FK_Startboats_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Startboats_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Startboats_Regattas_RegattaId",
                        column: x => x.RegattaId,
                        principalTable: "Regattas",
                        principalColumn: "RegattaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Startboats_ReportedStartboats_ReportedStartboatId",
                        column: x => x.ReportedStartboatId,
                        principalTable: "ReportedStartboats",
                        principalColumn: "ReportedStartboatId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Startboats_Startboatstati_StartboatstatusId",
                        column: x => x.StartboatstatusId,
                        principalTable: "Startboatstati",
                        principalColumn: "StartboatstatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartboatMembers",
                columns: table => new
                {
                    StartboatId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    SeatNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartboatMembers", x => new { x.StartboatId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_StartboatMembers_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StartboatMembers_Startboats_StartboatId",
                        column: x => x.StartboatId,
                        principalTable: "Startboats",
                        principalColumn: "StartboatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StartboatStandbys",
                columns: table => new
                {
                    StartboatId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Standbynumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartboatStandbys", x => new { x.StartboatId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_StartboatStandbys_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StartboatStandbys_Startboats_StartboatId",
                        column: x => x.StartboatId,
                        principalTable: "Startboats",
                        principalColumn: "StartboatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Boatclasses",
                columns: new[] { "BoatclassId", "Name", "Seats" },
                values: new object[,]
                {
                    { 1, "K1", 1 },
                    { 10, "S8", 8 },
                    { 9, "S6", 6 },
                    { 7, "S1", 1 },
                    { 6, "C4", 4 },
                    { 8, "S2", 2 },
                    { 4, "C1", 1 },
                    { 3, "K4", 4 },
                    { 11, "S4", 4 },
                    { 2, "K2", 2 },
                    { 5, "C2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "ClubId", "City", "EMail", "Name", "ShortName", "VNr" },
                values: new object[,]
                {
                    { 275, "Wesenberg", null, "SV Union Wesenberg, Abtl. Kanu", "SV Wesenberg", "08-021" },
                    { 280, "Wittenberge", null, "Wassersportverein Wittenberge e.V.", "WSV Wittenberge", "04-029" },
                    { 279, "Witten", null, "Kanu-Club Witten e.V.", "KC Witten", "10-305" },
                    { 278, "Wismar", null, "Turn- und Sportgemeinschaft Wismar", "TuS Wismar", "08-002" },
                    { 277, "Wilhelmshaven", null, "Wilhelmshavener Kanu-Freunde 1950 e.V.", "Wilhelmshavener KF", "09-108" },
                    { 276, "Wiesbaden", null, "Wassersport-Verein Schierstein 1921 e.V.", "WSV Schierstein", "07-073" },
                    { 274, "Wengelsdorf", null, "SV 1919 Wacker Wengelsdorf/Abt. Kanurennsport", "SV Wacker", "16-063" },
                    { 270, "Verden", null, "Wassersportverein Verden e.V.", "WSV Verden", "09-100" },
                    { 272, "Waren", null, "Müritzsportclub Waren e.V., Abtl. Kanu", "MSC Waren", "08-013" },
                    { 271, "Voerde", null, "Kanu-Club Friedrichsfeld e.V.", "KC Friedrichsfeld", "10-118" },
                    { 28, "Berlin", null, "Berliner Sportverein Akademie d.Wissenschaften e.V., Kanuabt.", "AdW Berlin", "03-053" },
                    { 29, "Berlin", null, "Köpenicker Kanusportclub e. V.", "Köpenicker KC", "03-045" },
                    { 269, "Troisdorf", null, "Kanu-Klub Pirat e.V. Bergheim/Sieg", "KK Pirat Bergheim", "10-012" },
                    { 268, "Trier", null, "Trierer Kanu-Fahrer 1948 e.V.", "Trierer KF", "13-018" },
                    { 273, "Wehr", null, "Kanu Sport Wehr e.V.", "KS Wehr", "01-206" },
                    { 281, "Wolfsburg", null, "Wolfsburger Kanu-Club e.V.", "Wolfsburger KC", "09-111" },
                    { 287, "Wuppertal", null, "ESV Wuppertal Ost e.V., Kanuabteilung", "ESV Wuppertal", "10-311" },
                    { 283, "Worms", null, "Wassersportverein Worms e.V.", "WSV Worms", "12-014" },
                    { 32, "Bochum", null, "Bochumer Kanu-Club e.V.", "Bochumer KC", "10-016" },
                    { 31, "Bitburg", null, "Turnverein Bitburg 1911 e.V. Kanuabteilung", "TV Bitburg", "13-001" },
                    { 4, "Bad Lobenstein", null, "Kanuteam Thüringen e.V.", "Bad Lobenstein", "18-031" },
                    { 294, "Platzhalter", null, "Platzhalter", "Platzhalter", "00-000" },
                    { 293, "Wusterwitz", null, "Blau Weiß Wusterwitz e.V., Abtl. Kanu", "BW Wusterwitz", "04-019" },
                    { 292, "Wurzen", null, "Sportgemeinschaft Lokomotive Wurzen e.V.", "SG Lok Wurzen", "15-007" },
                    { 291, "Würzburg", null, "TG Würzburg Heidingsfeld Kanuabt.", "TG Würzburg", "02-101" },
                    { 30, "Bernburg", null, "Bernburger-Wassersport-Verein e.V.", "Bernburger WSV", "16-030" },
                    { 290, "Würzburg", null, "Kanu-Club Würzburg", "KC Würzburg", "02-100" },
                    { 289, "Würzburg", null, "Kanurennsport Verein Bayern", "KRV Bayern", "02-163" },
                    { 288, "Wuppertal", null, "Kanu-Sport-Gemeinschaft Wuppertal e.V.", "KSG Wuppertal", "10-312" },
                    { 267, "Templin", null, "Kanusportverein Templin e.V.", "KSV Templin", "04-011" },
                    { 286, "Wuppertal", null, "Wuppertaler Paddler-Gilde e.V.", "Wuppertaler PG", "10-316" },
                    { 285, "Wuppertal", null, "Wuppertaler Kanu-Club e.V.", "Wuppertaler KC", "10-315" },
                    { 284, "Wuppertal", null, "Verein für Kanusport e.V. Wuppertal", "VK Wuppertal", "10-314" },
                    { 282, "Wolmirstedt", null, "Wolmirstedter KV", "Wolmirstedter KV", "16-011" },
                    { 266, "Stuttgart", null, "KG Stuttgart e.V.", "KG Stuttgart", "01-128" },
                    { 261, "Schwörstadt", null, "WSV e.V. Rheinstrom Schwörstadt Hochrhein", "WSV Schwörstadt", "01-046" },
                    { 264, "Stahnsdorf", null, "Aktiv e.V., Abtl. Parakanu", "Aktiv Stahnsdorf", "04-048" },
                    { 246, "Rostock", null, "Sportverein Breitling e.V.", "SV Breitling", "08-007" },
                    { 245, "Rostock", null, "Kanufreunde Rostocker Greif e.V.", "KF Rostocker Greif", "08-015" },
                    { 244, "Rosenthal", null, "WSV Rosenthal e.V. Abt. Kanurennsport", "WSV Rosenthal", "18-024" },
                    { 243, "Rosenheim", null, "Kajak-Klub Rosenheim", "KK Rosenheim", "02-084" },
                    { 242, "Rogätz", null, "Sportclub Kanu Rogätz e.V.", "SC Rogätz", "16-039" },
                    { 241, "Riesa", null, "Riesaer Wassersportverein e.V.", "Riesaer WSV", "15-028" },
                    { 247, "Rostock", null, "Rostocker Kanu-Club e.V.", "Rostocker KC", "08-016" },
                    { 25, "Berlin", null, "Verein für Kanusport Berlin e.V.", "Verein KS Berlin", "03-024" },
                    { 238, "Rheine", null, "Kanu-Club Rheine 1950 e.V.", "KC Rheine", "10-263" },
                    { 237, "Rheine", null, "Paddel- und Radsportclub Emsstern Rheine 1933 e.V.", "PRSC Emsstem", "10-264" },
                    { 236, "Rheine", null, "Wassersportverein Rheine 1932 e.V.", "WSV Rheine", "10-265" },
                    { 235, "Rendsburg", null, "Rendsburger Kanu-Club e.V.", "Rendsburger KC", "17-027" },
                    { 234, "Regensburg", "asdfsdaf@sfasf.de", "Regensburger Ruderverein Faltbootabteilung", "Regensburger RV", "02-081" },
                    { 233, "Recklinghausen", null, "TuWSV e.V. Recklinghausen-Süd, Kanuabteilung", "TuWSV Recklinghausen", "10-258" },
                    { 240, "Riesa", null, "Sportclub Riesa e.V. Kanuabt.", "SC Riesa", "15-045" },
                    { 248, "Rüsselsheim", null, "WSV ‚Undine' Rüsselsheim", "WSV Rüsselsheim", "07-064" },
                    { 249, "Saarbrücken", null, "Saarbrücker Kanu-Club e.V.", "Saarbrücker KC", "14-007" },
                    { 250, "Saarbrücken", null, "Kanu-Wanderer Saarbrücken e.V.", "KW Saarbrücken", "14-006" },
                    { 263, "Springe", null, "Kanu-Club Springe e.V.", "KC Springe", "09-093" },
                    { 262, "Spremberg", null, "Sportgemeinschaft Einheit Spremberg e.V., Kanuabt.", "SG Spremberg", "04-014" },
                    { 33, "Bochum", null, "Linden-Dahlhauser Kanu-Club e.V.", "Linden-Dahlhauser KC", "10-018" },
                    { 27, "Berlin", "thorstenschwerdtfeger@msn.com", "Kajak-Club Albatros 1926 e.V.", "KC Albatros", "03-005" },
                    { 260, "Schwerte", null, "Kanu-und Surf-Verein Schwerte e.V.", "KSV Schwerte", "10-272" },
                    { 259, "Schwerin", null, "Kanurenngemeinschaft Schwerin e.V.", "KRG Schwerin", "08-003" },
                    { 258, "Schwedt", null, "Wassersport PCK Schwedt e.V., Abtl. Kanu", "WS PCK Schwedt", "04-043" },
                    { 257, "Schönebeck", null, "SG Lok Schönebeck", "SG Lok Schönebeck", "16-042" },
                    { 256, "Schönebeck", null, "Schönebecker Sportclub e.V., Kanuabt.", "Schönebecker SC", "16-037" },
                    { 255, "Sandersdorf", null, "Sandersdorfer Kanu-Verein", "Sandersdorfer KV", "16-056" },
                    { 254, "Salzgitter", null, "Kanu-Club Salzgitter e.V.", "KC Salzgitter", "09-087" },
                    { 253, "Saarlouis", null, "Kanu-Club Undine Saarlouis", "KC Saarlouis", "14-008" },
                    { 252, "Saarbrücken", null, "Verein zur Förderung des Jugendsports Saar, Abteilung Kanu", "VzFJ Saar", "14-015" },
                    { 251, "Saarbrücken", null, "VfK Saar", "VfK Saar", "14-003" },
                    { 26, "Berlin", null, "Wander-Paddler-Havel e. V.", "WP Havel", "03-027" },
                    { 265, "Stralsund", null, "Stralsunder Kanu-Club e.V.", "Stralsunder KC", "08-001" },
                    { 34, "Bochum", null, "Kanu-Club Wiking Bochum 1951 e.V.", "KC Wiking", "10-017" },
                    { 39, "Brandenburg", null, "Wassersportverein Stahl Beetzsee Brandenburg e.V., Kanu", "WSV Stahl Beetzsee", "04-028" },
                    { 36, "Bornheim", null, "Herseler Wassersportverein 1930 e.V.", "Herseler WSV", "10-155" },
                    { 82, "Esslingen", null, "Sportvereinigung 1845 Esslingen e.V., Kanuabtl.", "SV Esslingen", "01-106" },
                    { 81, "Esslingen", null, "KV Esslingen", "KV Esslingen", "01-105" },
                    { 9, "Berlin", "test", "Berliner Kanu Club Borussia e.V.", "Borussia", "03-001" },
                    { 80, "Essen", null, "Kanu-Regatta-Verein Baldeneysee e.V. Essen", "KRV Baldeneysee", "10-506" },
                    { 79, "Essen", null, "Steeler Kanu Club e.V.", "Steeler KC", "10-114" },
                    { 78, "Essen", null, "Kanusport-Gemeinschaft Essen e.V.", "KG Essen", "10-105" },
                    { 83, "Flecken Zechlin", null, "Wassersportverein Zechlin e.V.", "WSV Zechlin", "04-046" },
                    { 77, "Essen", null, "Schwimmverein Steele 1911 e.V., Kanuabteilung", "SV Steele", "10-113" },
                    { 75, "Esens", null, "Wassersportverein Harle e.V.", "WSV Harle", "09-001" },
                    { 74, "Erlangen", null, "Naturfreunde Deutschlands, OG Erlangen", "NFD Erlangen", "02-020" },
                    { 73, "Emsdetten", null, "Canu-Club Emsdetten 1950 e.V.", "CC Emsdetten", "10-087" },
                    { 72, "Elze", null, "CJD Elze Leichtathletik e.V.", "CJD Elze", "09-024" },
                    { 71, "Eisenhüttenstadt", null, "Kanucentrum 1957 Eisenhüttenstadt e.V.", "KC Eisenhüttenstadt", "04-001" },
                    { 8, "Berlin", null, "Sportclub Berlin-Grünau e. V., Abt. Kanu", "Berlin-Grünau", "03-050" },
                    { 76, "Essen", null, "Eisenbahner-Sportverein Essen Kupferdreh e.V.", "ESV Essen", "10-092" },
                    { 84, "Flensburg", null, "Flensburger Paddelfreunde e.V.", "Flensburger PF", "17-009" },
                    { 85, "Flöha", "ksv-floeha@t-online.de", "Kanusportverein 1928 Flöha e.V.", "KSV Flöha", "15-006" },
                    { 86, "Forst", null, "Sportgemeinschaft Turbine Forst/Lausitz e.V. Sek. Kanu", "SGTF Lausitz", "04-009" },
                    { 100, "Görlitz", null, "NSV Gelb - Weiß Görlitz e.V.Kanuabt.", "NSV Görlitz", "15-032" },
                    { 99, "Ginsheim", null, "KV Ginsheim-Gustavsburg", "KV Ginsheim", "07-027" },
                    { 98, "Gießen", null, "SKC Gießen", "SKC Gießen", "07-025" },
                    { 97, "Geringswalde", "ines.naarmann@web.de", "Kanuverein Geringswalde e.V.", "KV Geringswalde", "15-062" },
                    { 96, "Genthin", null, "SV Chemie Genthin e.V., Sek. Kanu", "SVC Genthin", "16-031" },
                    { 95, "Gemünden", null, "White Water Company Gemünden", "WWC Gemünden", "02-145" },
                    { 94, "Gemünden", null, "Kanu und Ski-Club 1929 e.V. Gemünden am Main", "KSC Gemünden", "02-028" },
                    { 93, "Gemünden", null, "KT Main-Spessart", "KT Main-Spessart", "02-164" },
                    { 92, "Gelsenkirchen", null, "Gelsenkirchener Kanu-Club e.V.", "Gelsenkirchener KC", "10-121" },
                    { 91, "Fürth", null, "TV Fürth 1860 Kanuabt.", "TV Fürth", "02-024" },
                    { 10, "Berlin", null, "Grünauer Kanuverein 1990 e. V.", "GKV", "03-042" },
                    { 90, "Friedrichshafen", null, "KSF Friedrichshafen", "KSF Friedrichshafen", "01-109" },
                    { 89, "Friedersdorf", null, "WSC Friedersdorf 1949 e.V.", "WSC Friedersdorf", "16-016" },
                    { 88, "Frankfurt/M.", null, "Frankfurter Kanu-Verein 1913 e.V.", "FFKV", "07-014" },
                    { 87, "Frankfurt/M.", null, "Frankfurter Ruder- u. Kanusportverein Sachsenhausen v. 1898 e.V.", "FFRKV Sachsenhausen", "07-015" },
                    { 70, "Eisenhüttenstadt", null, "Kanu-Verein Brandenburger Adler e. V.", "KV Adler", "04-040" },
                    { 35, "Borna", null, "SV Blau-Gelb Borna e.V.", "SV Borna", "15-010" },
                    { 69, "Eberswalde-Finow", null, "Eberswalder Sportverein Empor e.V.Kanuabt.", "SV Empor", "04-022" },
                    { 67, "Düsseldorf", null, "Düsseldorfer Kanu-Club e.V.", "Düsseldorfer KC", "10-050" },
                    { 49, "Colditz", "zyma.randy@web.de", "Colditzer Kanu- und Sportverein e.V.", "Colditzer KSV", "15-066" },
                    { 48, "Coburg", null, "Schwimmverein Coburg Faltbootabteilung", "SV Coburg", "02-013" },
                    { 47, "Coburg", null, "Paddel u. Segelclub Coburg-Schney 1926 e.V.", "PuS Coburg", "02-012" },
                    { 46, "Calbe", null, "TSG Calbe e.V. Abt. Kanu", "TSG Calbe", "16-032" },
                    { 45, "Burg", null, "WSF Burg 1924 e.V.", "WSF Burg", "16-012" },
                    { 44, "Bremen", null, "Verein für Kanusport Bremen e.V.", "VfK Bremen", "05-018" },
                    { 50, "Cottbus", null, "Eisenbahnersportverein Lok RAW Cottbus e.V. Kanuabt.", "ESV Lok Cottbus", "04-013" },
                    { 43, "Bremen", null, "Turn- und Rasensportverein Bremen e.V.", "TuRSV Bremen", "05-017" },
                    { 41, "Braunsbedra OT Großkayna", null, "SV Großkayna 1922 e.V.", "SV Großkayna", "16-065" },
                    { 5, "Bamberg", null, "Bamberger Faltbootclub", "Bamberg", "02-006" },
                    { 40, "Brandenburg", null, "Brandenburger Sport-Club Süd 05 e.V. Abteilung Kanu", "Brandenburger SC Süd", "04-006" },
                    { 232, "Raunheim", null, "KCW 1955 Raunheim", "KCW Raunheim", "07-061" },
                    { 38, "Brandenburg", null, "Brandenburger Kanuverein Freie Wasserfahrer 1925 e.V.", "Freie Wasserfahrer", "04-020" },
                    { 37, "Bramsche", null, "Turn- u. Sportverein Bramsche, Kanu-Abteilung", "TuS Bramsche", "09-009" },
                    { 42, "Bremen", null, "Störtebeker Bremer Paddelsport e.V von 1924", "Störtebeker PS", "05-015" },
                    { 6, "Barby", null, "SSV Blau - Weiß 04 Barby e.V.", "Barby", "16-041" },
                    { 51, "Darmstadt", null, "Darmstädter TSG 1846 - Kanuabteilung", "Darmstädter TSG", "07-003" },
                    { 52, "Datteln", null, "Kanuten Emscher Lippe e.V. Datteln", "Emscher Lippe", "10-038" },
                    { 66, "Düsseldorf", null, "Wassersportverein Rheintreue Düsseldorf e.V.", "WSV Rheintreue", "10-063" },
                    { 65, "Duisburg", null, "Wassersportverein Niederrhein e.V. Duisburg", "WSV Niederrhein", "10-084" },
                    { 64, "Duisburg", null, "ESV Grün-Weiß-Meiderich e.V., Kanuabteilung", "ESV GW Meiderich", "10-071" },
                    { 63, "Duisburg", null, "Bertasee Duisburg e.V.", "Bertasee", "10-067" },
                    { 62, "Dresden", null, "Kanu-Club Dresden e.V.", "KC Dresden", "15-026" },
                    { 61, "Dresden", "burkhama@freenet.de", "Wassersportverein Am Blauen Wunder e.V.Dresden", "BW Dresden", "15-059" },
                    { 7, "Bederkesa", null, "Wassersportverein Bederkesa e.V.", "Bederkesa", "09-006" },
                    { 60, "Dresden", null, "Verein Kanusport Dresden e.V.", "VK Dresden", "15-011" },
                    { 59, "Dresden", "rennsportwart@tsv-rotation-kanurennsport.de", "TSV Rotation Dresden 1990 e.V. Kanuabt.", "TSV Rotation", "15-013" },
                    { 58, "Dresden", null, "Kanuverein Laubegast e.V. Dresden", "KV Laubegast", "15-039" },
                    { 57, "Dresden", null, "Eisenbahner Sportverein Dresden e.V.", "ESV Dresden", "15-027" },
                    { 56, "Dresden", null, "Sportverein TuR Dresden e.V. Kanuabt.", "TuR Dresden", "15-055" },
                    { 55, "Dortmund", null, "Freier Sportverein von 1898 Dortmund e.V.,Kanu-Abtl.", "FSV Dortmund", "10-043" },
                    { 54, "Döbeln", "husky24@gmx.de", "Eisenbahnersportverein Lokomotive Döbeln e.V.", "ESV Lok Döbeln", "15-005" },
                    { 53, "Dillingen", null, "Kanu-Club Dillingen e.V./Saar", "KC Dillingen", "14-002" },
                    { 68, "Eberswalde-Finow", null, "Sportvereinigung Stahl Finow e.V. Sek. Kanu", "SV Stahl Finow", "04-016" },
                    { 231, "Raunheim", null, "EURO CANOE SPORT TEAM 2000 RAUNHEIM e.V.", "ECST Raunheim", "07-111" },
                    { 239, "Rheinsheim", null, "KV Bruhrain Rheinsheim e.V.", "KV Bruhrain", "01-039" },
                    { 230, "Rathenow", null, "Rathenower Wassersportverein Kanu 1922 e.V.", "Rathenower WSV", "04-017" },
                    { 145, "Kelheim", null, "Kanu-Club Kelheim e.V.", "KC Kelheim", "02-041" },
                    { 144, "Kassel", null, "WVC Cassel", "WVC Cassel", "07-079" },
                    { 143, "Kassel", null, "PSV Grün-Weiß Kassel", "PSV Kassel", "07-041" },
                    { 142, "Kassel", null, "Kanu-Sport Kassel e.V.", "KS Kassel", "07-038" },
                    { 141, "Karlsruhe", null, "Rheinbrüder Karlsruhe e.V. Kanu-Segel-Skiclub", "RB Karlsruhe", "01-019" },
                    { 15, "Berlin", null, "Blau-Gelb-Köpenick e.V.", "BG Köpenick", "03-065" },
                    { 146, "Kiel", null, "TUS Gaarden e.V. - Kanuabt.", "TUS Gaarden", "17-016" },
                    { 140, "Kaiserslautern", null, "Paddlergilde Kaiserslautern 1926 e.V.", "PG Kaiserslautern", "11-005" },
                    { 138, "Jeßnitz", null, "Kanu-Club Jeßnitz/Anhalt e.V.", "KC Jeßnitz", "16-036" },
                    { 137, "Jena", null, "USV Jena e.V. Abt. Kanu", "USV Jena", "18-013" },
                    { 136, "Hof", null, "Faltboot-Club Hof 1932 e.V.", "FC Hof", "02-035" },
                    { 135, "Hof", null, "Schwimmverein Hof 1911 e.V. Kanuabt.", "SV Hof", "02-037" },
                    { 134, "Hof", null, "Kanu Rennsport Vereinigung Hof e.V.", "KRV Hof", "02-151" },
                    { 133, "Herford", null, "Herforder Kanu-Klub e.V.", "Herforder KK", "10-151" },
                    { 139, "Kaiserslautern", null, "1. Ski- und Kanu-Club Kaiserslautern e.V.", "KC Kaiserslautern", "11-004" },
                    { 147, "Kiel", null, "TSV Klausdorf von 1916 e.V. - Kanuabt.", "TSV Klausdorf", "17-017" },
                    { 148, "Kiel", null, "Kieler Kanu-Klub von 1921 e.V.", "Kieler KK", "17-015" },
                    { 149, "Kiel", null, "Ellerbeker Turnvereinigung von 1886 e.V., Kanuabtl.", "Ellerbeker TV", "17-006" },
                    { 162, "Lampertheim", null, "WSV Lampertheim", "WSV Lampertheim", "07-047" },
                    { 161, "Lampertheim", null, "Wassersportverein 2002 am Leistungszentrum Mannheim e.V.", "WSV Mannheim", "01-075" },
                    { 17, "Berlin", null, "Wassersportclub Blau-Weiß Tegel e.V.", "BW Tegel", "03-029" },
                    { 160, "Lampertheim", null, "Kanu-Club Altrhein am Leistungszentrum Mannheim e.V.", "KC Altrhein Mannheim", "01-077" },
                    { 159, "Lampertheim", null, "Kajak-Team Hessen Lampertheim e.V.", "KTH Lampertheim", "07-113" },
                    { 158, "Lampertheim", null, "KC 1952 Lampertheim", "KC Lampertheim", "07-046" },
                    { 157, "Lampertheim", null, "Kanuakademie Lampertheim", "KA Lampertheim", "07-126" },
                    { 156, "Krefeld", null, "Krefelder Kanu-Klub 1927 e.V.", "Krefelder KK", "10-189" },
                    { 155, "Krefeld", null, "SC Bayer 05 Uerdingen e.V., Kanuabteilung", "SCB05 Uerdingen", "10-527" },
                    { 154, "Konstanz", null, "Kanu-Club Konstanz 1932 e.V.", "KC Konstanz", "01-027" },
                    { 153, "Köln", null, "Kanusport Köln-Mülheim e.V.", "KS Köln", "10-177" },
                    { 24, "Berlin", null, "Heiligenseer Kanu-Club e.V.", "Heiligenseer KC", "03-004" },
                    { 151, "Kleinheubach", null, "Wasser-Sport-Gemeinschaft Kleinheubach", "WSG Kleinheubach", "02-043" },
                    { 16, "Berlin", null, "Ruder- und Kanu-Verein 1928 e.V.", "RKV Berlin", "03-020" },
                    { 150, "Kirchmöser", null, "Eisenbahnersportverein Kirchmöser e.V. Kanuabt.", "ESV Kirchmöser", "04-024" },
                    { 132, "Herdecke", null, "Herdecker Kanu-Club 1925 e.V.", "Herdecker KC", "10-150" },
                    { 131, "Heilbronn", null, "Sportverein Union 08 Böckingen e.V. Kanu-Abtl.", "SV Böckingen", "01-103" },
                    { 14, "Berlin", null, "Berliner Kanu Club Rotation e. V.", "KC Rotation", "03-049" },
                    { 130, "Heilbronn", null, "TSG Heilbronn", "TSG Heilbronn", "01-112" },
                    { 111, "Hamburg", null, "Bergedorfer Kanu Club v. 1953 e.V.", "Bergedorfer KC", "06-005" },
                    { 12, "Berlin", null, "Kanusport-Verein Neu Ahlbeck e. V.", "KV Neu Ahlbeck", "03-060" },
                    { 110, "Hamburg", null, "Hanseat Verein für Wassersport e.V.", "Hanseat VfW", "06-012" },
                    { 109, "Hamburg", null, "Verein für Leibesübungen von 1893 e.V., Sparte Wassersport", "VfL Hamburg", "06-020" },
                    { 108, "Halle", null, "Hallescher Kanu-Club 54 e.V.", "Hallescher KC", "16-026" },
                    { 107, "Halle", null, "Kanuverein 96 Halle e.V.", "KV 96 Halle", "16-023" },
                    { 106, "Haldensleben", null, "WSV Haldensleben e.V. Abt. Kanu", "WSV Haldensleben", "16-007" },
                    { 105, "Güstrow", null, "Kanu-Sportverein Güstrow e.V.", "KSV Güstrow", "08-022" },
                    { 104, "Güsen", null, "Güsener Handball-Club e.V.", "Güsener HC", "16-045" },
                    { 103, "Göttingen", null, "Göttinger Paddler-Club e.V.", "Göttinger PC", "09-028" },
                    { 102, "Göttingen", null, "Turn- und Wassersportverein Göttingen von 1861 e.V.", "TuW Göttingen", "09-030" },
                    { 101, "Göttingen", null, "Vereinigung für Kanurennsport Nord (VKN)", "VKN Göttingen", "09-252" },
                    { 11, "Berlin", null, "Kanu-Gemeinschaft Tegel e. V.", "KG Tegel", "03-063" },
                    { 2, "Aschaffenburg", null, "SSKC Poseidon Aschaffenburg Kanuabt.", "Aschaffenburg", "02-002" },
                    { 1, "Ansbach", null, "Kanu-Sportclub Ansbach", "Ansbach", "02-001" },
                    { 112, "Hamburg", null, "Alster Canoe Club e.V.", "Alster CC", "06-002" },
                    { 163, "Langenprozelten", null, "Paddel-Sport-Verein Langenprozelten", "PSV Langenprozelten", "02-115" },
                    { 113, "Hamburg", null, "Freier Wassersportverein Vorwärts e.V.", "FWV Vorwärts", "06-009" },
                    { 115, "Hamburg", null, "Harburger Kanu-Club von 1922 e.V.", "Harburger KC", "06-013" },
                    { 129, "Heidelberg", null, "Wassersportclub 1931 Heidelberg-Neuenheim e.V.", "WSV Heidelberg", "01-013" },
                    { 128, "Havelberg", null, "Havelberger WSV e.V.", "Havelberger WSV", "16-009" },
                    { 127, "Hannover", null, "Sport Club Hannover e.V. -Kanu-", "SC Hannover", "09-238" },
                    { 126, "Hannover", null, "Kanu-Club Limmer e.V.", "KC Limmer", "09-037" },
                    { 125, "Hannover", null, "Hannoverscher Kanu-Club v. 1921 e.V.", "Hannoverscher KC", "09-036" },
                    { 124, "Hann. Münden", null, "Mündener Kanu-Club e.V.", "Mündener KC", "09-048" },
                    { 123, "Hamm", null, "Kanu-Verein Hamm e.V.", "KV Hamm", "10-141" },
                    { 122, "Hamm", null, "Kanu-Ring e.V. Hamm", "KR Hamm", "10-140" },
                    { 121, "Hamm", null, "Kanu-Verein 45 Herringen e.V.", "KV Herringen", "10-154" },
                    { 13, "Berlin", null, "Köpenicker Sport-Club e. V.", "Köpenicker SC", "03-043" },
                    { 120, "Hamm", null, "DJK Wassersport Hamm e.V.", "DJK Hamm", "10-137" },
                    { 119, "Hameln", null, "Kanu-Club Hameln e.V.", "KC Hameln", "09-034" },
                    { 118, "Hamburg", null, "Alstereck Verein für Wassersport e.V.", "Alstereck VfW", "06-003" },
                    { 117, "Hamburg", null, "Hamburger Kanu-Club e.V.", "Hamburger KC", "06-010" },
                    { 116, "Hamburg", null, "Oberalster Verein für Wassersport e.V.", "Oberalster VfW", "06-016" },
                    { 114, "Hamburg", null, "Sportvereinigung Polizei von 1920 e.V., Wassersportabteilung", "SVG Polizei HH", "06-018" },
                    { 164, "Leipzig", null, "Universitätssportclub Leipzig e. V.", "USC Leipzig", "15-052" },
                    { 152, "Koblenz", null, "Wassersportverein Koblenz-Metternich e.V.", "WSV Koblenz", "13-009" },
                    { 166, "Leipzig", null, "Sportgemeinschaft Leipziger Verkehrsbetriebe e.V. Kanuabt.", "SG LVB", "15-046" },
                    { 211, "Oberhausen", null, "Kanu-Team 2000 e.V.", "KT 2000", "10-483" },
                    { 165, "Leipzig", null, "Sportclub DHfK Leipzig e. V. - Abtl. Kanu -", "DHfK Leipzig", "15-008" },
                    { 210, "Nürnberg", null, "Kanu-Verein Nürnberg", "KV Nürnberg", "02-132" },
                    { 209, "Niegripp", null, "SG Blau-Weiß Niegripp e.V.", "SGBW Niegripp", "16-001" },
                    { 208, "Niederkassel", null, "Wassersportverein Blau-Weiß Rheidt", "WSV Rheidt", "10-261" },
                    { 207, "Neuwied", null, "Neuwieder Wassersportverein e.V.", "Neuwieder WSV", "13-014" },
                    { 212, "Oberhausen", null, "Turnclub Sterkrade 1869 e.V. Oberhausen", "TC Sterkrade", "10-248" },
                    { 206, "Neustrelitz", null, "Wassersportverein Einheit Neustrelitz, Abteilung Kanu", "WSV Neustrelitz", "08-005" },
                    { 204, "Neuruppin", null, "Kanu-Verein Neuruppin e.V.", "KV Neuruppin", "04-003" },
                    { 203, "Neumünster", null, "Erster Kanuklub Neumünster e.V.", "KK Neumünster", "17-021" },
                    { 202, "Neukloster", null, "VfL Blau-Weiß Neukloster", "VfL Blau-Weiß", "08-009" },
                    { 201, "Neuburg", null, "Donau-Ruder-Club Neuburg Kanu", "DRC Neuburg", "02-065" },
                    { 21, "Berlin", "webmaster@kanuklub-charlottenburg.de", "Kanuklub Charlottenburg e.V.", "KC Charlottenburg", "03-010" },
                    { 3, "Bad Dürrenberg", null, "KC Bad Dürrenberg e.V.", "Bad Dürrenberg", "16-025" },
                    { 205, "Neuss", null, "Holzheimer Sportgemeinschaft 1920 e.V.", "Holzheimer SG", "10-159" },
                    { 213, "Oberhausen", null, "Oberhausener Kanu-Verein v.1928 e.V.", "Oberhausender KV", "10-246" },
                    { 214, "Oberhausen", null, "Alstadener Kanu-Club e.V. Oberhausen", "Alstadener KC", "10-245" },
                    { 215, "Oberschleißheim", null, "Schleißheimer Paddelclub e.V.", "Schleißheimer PC", "02-166" },
                    { 229, "Rastatt", null, "Rastatter Kanu-Club 1925 e.V.", "Rastatter KC", "01-043" },
                    { 228, "Raisdorf", null, "Raisdorfer Kanu-Klub e.V.", "Raisdorfer KK", "17-031" },
                    { 227, "Radevormwald", null, "Kanusportverein Radevormwald/Remscheidt e.V.", "KV Radevormwald", "10-480" },
                    { 226, "Prenzlau", null, "Sport Club Blau Weiß Energie Prenzlau e.V.", "S BW Prenzlau", "04-032" },
                    { 225, "Preetz", null, "Preetzer Turn- und Sportverein e.V. - Kanuabt.", "Preetzer TuS", "17-026" },
                    { 224, "Potsdam", null, "Kanu Club Potsdam im OSC Luftschiffhafen e.V.", "KC Potsdam", "04-007" },
                    { 223, "Potsdam", null, "Wassersportfreunde Pirschheide e.V. Abtl. Kanu", "WSF Pirschheide", "04-018" },
                    { 222, "Potsdam", null, "Preussen-Kanu im OSC Luftschiffhafen e.V. Potsdam", "OSC LH Potsdam", "04-005" },
                    { 221, "Plön", null, "Wassersportverein Plön-Fegetasche e.V.", "WSV Plön", "17-024" },
                    { 23, "Berlin", null, "Pro Sport Berlin 24 e.V., Kanuabteilung (ehemals Post SV Berlin)", "Pro Sport Berlin", "03-017" },
                    { 220, "Pirna", null, "Sportverein Grün-Weiß Pirna e.V. Kanuabt.", "SV GW Prina", "15-031" },
                    { 219, "Petershagen", null, "KSV Kenterpreis Windheim e.V.", "KSV Windheim", "10-477" },
                    { 218, "Peitz", null, "Kanuverein Peitz e.V.", "KV Peitz", "04-035" },
                    { 217, "Parum", null, "SG Blau - Weiß Parum e.V.Sektion Kanu", "SG BW Parum", "08-032" },
                    { 216, "Osnabrück", null, "Wassersportverein Osnabrück e.V.", "WSV Osnabrück", "09-079" },
                    { 200, "Neubrandenburg", null, "Sportclub Neubrandenburg e.V., Abtl. Kanu", "SC Neubrandenburg", "08-012" },
                    { 199, "Nettetal", null, "Ruder-u.Kanu-Club Lobberich 1948 e.V.", "RKC Lobberich", "10-202" },
                    { 22, "Berlin", null, "Kanu Team Berlin e. V.", "KT Berlin", "03-064" },
                    { 197, "Neckarsulm", null, "Kanu-Team Baden-Württemberg", "KT BW", "01-157" },
                    { 179, "Magdeburg", null, "Kanu - Klub Börde Magdeburg e.V.", "KK Börde", "16-033" },
                    { 178, "Magdeburg", null, "Wassersportverein Buckau-Fermersleben e.V., Kanuabtl.", "WSV Buckau", "16-010" },
                    { 177, "Magdeburg", null, "Sportclub Magdeburg e.V.", "SC Magdeburg", "16-034" },
                    { 176, "Magdeburg", null, "Kanuteam Sachsen-Anhalt e.V.", "KT Sachsen-Anhalt", "16-059" },
                    { 175, "Magdeburg", null, "Wassersportverein Lok Magdeburg", "WSV Lok Magdeburg", "16-061" },
                    { 174, "Lünen", null, "Kanu- u. Ski-Club Lünen e.V. 1949", "KSC Lünen", "10-408" },
                    { 180, "Mainz", null, "Kanufreunde 1929 e.V. Mainz-Mombach", "KF Mainz", "12-009" },
                    { 173, "Lübeck", null, "Kanu-Club Lübeck e.V.", "KC Lübeck", "17-057" },
                    { 171, "Lübeck", null, "Lübecker Kanu- und Segelsport-Verein e.V.", "Lübecker KSV", "17-019" },
                    { 18, "Berlin", null, "Kajak-Club Nord-West 1925 e.V.", "KC Nord-West", "03-006" },
                    { 198, "Neckarsulm", null, "Neckarsulmer Sport-Union", "Neckarsulmer SU", "01-120" },
                    { 169, "Löcknitz", null, "SV Einheit Löcknitz", "SV Löcknitz", "08-006" },
                    { 168, "Limburg", null, "Kanuclub Limburg im ESV Blau Weiß", "KC Limburg", "07-049" },
                    { 167, "Lilienthal", null, "Turn- u. Sportverein Lilienthal v. 1862 e.V., Kanu-Abt.", "TuS Lilienthal", "09-134" },
                    { 172, "Lübeck", null, "Lübecker Motor-Yacht-Club e.V., Kanuabtl.", "Lübecker MYC", "17-056" },
                    { 19, "Berlin", null, "Paddelclub Gut Naß Tegel 1924 e.V.", "Gut Naß Tegel", "03-014" },
                    { 170, "Lohr", null, "TSV 1846 Lohr e.V. Kanuabt.", "TSV Lohr", "02-050" },
                    { 182, "Malchin", null, "Malchiner Kanu-Club e.V.", "Malchiner KC", "08-027" },
                    { 181, "Mainz", null, "Kanu- u. Ski-Gesellschaft 1921 Mainz-Mombach", "KSG Mainz", "12-005" },
                    { 196, "Nassau", null, "Nassauer Kanu-Club 1950 e.V.", "Nassauer KC", "13-012" },
                    { 195, "München", null, "MTV München von 1879 Abt. Kanu", "MTV München", "02-060" },
                    { 194, "München", null, "Kanu-Regattaverein München", "KRV München", "02-155" },
                    { 192, "Mülheim", null, "DJK Ruhrwacht e.V. Mülheim/Ruhr", "DJK Mülheim", "10-229" },
                    { 191, "Mittweida", "korehnke@hs-mittweida.de", "Sportgemeinschaft Lauenhain e.V./Abtl. Kanu", "SG Lauenhain", "15-065" },
                    { 20, "Berlin", null, "Turngemeinde in Berlin 1848 e.V., Kanuabteilung Oberspree", "Turngemeinde", "03-023_2" },
                    { 193, "Mülheim", null, "Mülheimer Kanusport-Verein e.V.", "Mülheimer KV", "10-234" },
                    { 189, "Mettlach", null, "Kanu-Freunde Mettlach", "KF Mettlach", "14-005" },
                    { 188, "Merzig", null, "Kanu-Club Merzig e.V.", "KC Merzig", "14-004" },
                    { 187, "Marl", null, "TSV Marl-Hüls 1912 e.V.,Kanuabteilung", "TSV Marl-Hüls", "10-208" },
                    { 186, "Markranstädt", null, "Kanu- und Freizeitclub Markranstädt e. V.", "KF Makranstädt", "15-021" },
                    { 185, "Mannheim", null, "WSV Mannheim-Sandhofen e.V.", "WSV Mannheim", "01-035" },
                    { 184, "Mannheim", null, "Paddel-Gesellschaft Mannheim e.V.", "PG Mannheim", "01-033" },
                    { 190, "Mittweida", "SKSV_Mittweida@web.de", "Sächsischer Kanusportverein Mittweida e. V.", "SKSV Mittweida", "15-012" },
                    { 183, "Mannheim", null, "Kanu-Gesellschaft Mannheim-Neckarau", "KG Mannheim", "01-030" }
                });

            migrationBuilder.InsertData(
                table: "Oldclasses",
                columns: new[] { "OldclassId", "FromAge", "Name", "ToAge" },
                values: new object[,]
                {
                    { 10, 50, "Senioren C", 59 },
                    { 1013, 0, "alle Klassen", 99 },
                    { 4, 13, "Schüler A", 14 },
                    { 5, 15, "Jugend", 16 },
                    { 9, 40, "Senioren B", 49 },
                    { 7, 19, "Leistungsklasse", 31 },
                    { 8, 32, "Senioren A", 39 },
                    { 3, 10, "Schüler B", 12 },
                    { 6, 17, "Junioren", 18 },
                    { 1012, 7, "Schüler C/B10", 10 },
                    { 1004, 10, "Schüler B10", 10 },
                    { 1010, 11, "Schüler B11", 11 },
                    { 1011, 12, "Schüler B12", 12 },
                    { 2, 7, "Schüler C", 9 },
                    { 11, 60, "Senioren D", 99 },
                    { 1002, 13, "Schüler A13", 13 },
                    { 1, 0, "Schüler D", 6 },
                    { 1007, 7, "Schüler C7", 7 },
                    { 1008, 8, "Schüler C8", 8 },
                    { 1009, 9, "Schüler C9", 9 },
                    { 1003, 14, "Schüler A14", 14 }
                });

            migrationBuilder.InsertData(
                table: "Raceclasses",
                columns: new[] { "RaceclassId", "Length", "Name" },
                values: new object[,]
                {
                    { 1005, 100, "100m" },
                    { 1, 200, "200m" },
                    { 2, 500, "500m" },
                    { 3, 1000, "1000m" },
                    { 1002, 2000, "2000m" },
                    { 1003, 4000, "4000m" },
                    { 1004, 6000, "6000m" },
                    { 1006, 250, "250m" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubCampingFees_ClubId",
                table: "ClubCampingFees",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_BoatclassId",
                table: "Competitions",
                column: "BoatclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_RaceclassId",
                table: "Competitions",
                column: "RaceclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Members_ClubId",
                table: "Members",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceDrawRules_RaceDrawId",
                table: "RaceDrawRules",
                column: "RaceDrawId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceDrawRules_RaceTypId",
                table: "RaceDrawRules",
                column: "RaceTypId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_BoatclassId",
                table: "Races",
                column: "BoatclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_OldclassId",
                table: "Races",
                column: "OldclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RaceTypId",
                table: "Races",
                column: "RaceTypId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RaceclassId",
                table: "Races",
                column: "RaceclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RacestatusId",
                table: "Races",
                column: "RacestatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_RegattaId",
                table: "Races",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegattaCampingFees_RegattaId",
                table: "RegattaCampingFees",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegattaClubs_RegattaId",
                table: "RegattaClubs",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegattaCompetitions_RegattaId",
                table: "RegattaCompetitions",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegattaOldclasses_RegattaId",
                table: "RegattaOldclasses",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regattas_ClubId",
                table: "Regattas",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Regattas_WaterId",
                table: "Regattas",
                column: "WaterId");

            migrationBuilder.CreateIndex(
                name: "IX_RegattaStartingFees_RegattaId",
                table: "RegattaStartingFees",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedRaces_CompetitionId",
                table: "ReportedRaces",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedRaces_OldclassId",
                table: "ReportedRaces",
                column: "OldclassId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedRaces_RegattaId",
                table: "ReportedRaces",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedStartboatMembers_MemberId",
                table: "ReportedStartboatMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedStartboats_ClubId",
                table: "ReportedStartboats",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedStartboats_CompetitionId",
                table: "ReportedStartboats",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedStartboats_RegattaId",
                table: "ReportedStartboats",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedStartboats_ReportedRaceId",
                table: "ReportedStartboats",
                column: "ReportedRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportedStartboatStandbys_MemberId",
                table: "ReportedStartboatStandbys",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_StartboatMembers_MemberId",
                table: "StartboatMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Startboats_ClubId",
                table: "Startboats",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Startboats_RaceId",
                table: "Startboats",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Startboats_RegattaId",
                table: "Startboats",
                column: "RegattaId");

            migrationBuilder.CreateIndex(
                name: "IX_Startboats_ReportedStartboatId",
                table: "Startboats",
                column: "ReportedStartboatId");

            migrationBuilder.CreateIndex(
                name: "IX_Startboats_StartboatstatusId",
                table: "Startboats",
                column: "StartboatstatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StartboatStandbys_MemberId",
                table: "StartboatStandbys",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_StartingFees_BoatclassId",
                table: "StartingFees",
                column: "BoatclassId");

            migrationBuilder.CreateIndex(
                name: "IX_StartingFees_OldclassId",
                table: "StartingFees",
                column: "OldclassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubCampingFees");

            migrationBuilder.DropTable(
                name: "DeletedStartboats");

            migrationBuilder.DropTable(
                name: "RaceDrawRules");

            migrationBuilder.DropTable(
                name: "RegattaCampingFees");

            migrationBuilder.DropTable(
                name: "RegattaClubs");

            migrationBuilder.DropTable(
                name: "RegattaCompetitions");

            migrationBuilder.DropTable(
                name: "RegattaOldclasses");

            migrationBuilder.DropTable(
                name: "RegattaStartingFees");

            migrationBuilder.DropTable(
                name: "ReportedStartboatMembers");

            migrationBuilder.DropTable(
                name: "ReportedStartboatStandbys");

            migrationBuilder.DropTable(
                name: "RRFreeStartslots");

            migrationBuilder.DropTable(
                name: "StartboatMembers");

            migrationBuilder.DropTable(
                name: "StartboatStandbys");

            migrationBuilder.DropTable(
                name: "RaceDraws");

            migrationBuilder.DropTable(
                name: "CampingFees");

            migrationBuilder.DropTable(
                name: "StartingFees");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Startboats");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "ReportedStartboats");

            migrationBuilder.DropTable(
                name: "Startboatstati");

            migrationBuilder.DropTable(
                name: "RaceTyps");

            migrationBuilder.DropTable(
                name: "Racestati");

            migrationBuilder.DropTable(
                name: "ReportedRaces");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Oldclasses");

            migrationBuilder.DropTable(
                name: "Regattas");

            migrationBuilder.DropTable(
                name: "Boatclasses");

            migrationBuilder.DropTable(
                name: "Raceclasses");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Waters");
        }
    }
}
