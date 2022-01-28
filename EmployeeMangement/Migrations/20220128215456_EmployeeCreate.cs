using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMangement.Migrations
{
    public partial class EmployeeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    EmploymentDate = table.Column<DateTime>(nullable: false),
                    HomeAddress = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    BossId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Bosses_BossId",
                        column: x => x.BossId,
                        principalTable: "Bosses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Adrian", "Tremblay" },
                    { 2, "Raleigh", "Altenwerth" },
                    { 3, "Ferne", "Hagenes" },
                    { 4, "Geraldine", "Runolfsdottir" },
                    { 5, "Frieda", "Rowe" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CEO" },
                    { 2, "Senior Specialist" },
                    { 3, "Intermediate Specialist" },
                    { 4, "Junior Specialist" },
                    { 5, "Entry-level specialist" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[,]
                {
                    { 14, new DateTime(1988, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(1410), 5, new DateTime(2006, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(1420), "Polly", "839 Kaycee Harbor", "Erdman", 1, 1173 },
                    { 26, new DateTime(1981, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(2248), 5, new DateTime(2005, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(2257), "Santiago", "9281 Mohammad Motorway", "Schaefer", 4, 1920 },
                    { 25, new DateTime(1970, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(458), 2, new DateTime(2002, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(467), "Ezequiel", "4720 Arturo Fall", "Hane", 4, 2651 },
                    { 15, new DateTime(1996, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(2652), 2, new DateTime(2003, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(2662), "Kiarra", "9707 Douglas Green", "Lind", 4, 1556 },
                    { 11, new DateTime(1979, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(7081), 2, new DateTime(2013, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(7091), "Paolo", "88514 Yazmin Ways", "Zemlak", 4, 2735 },
                    { 4, new DateTime(1987, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(2853), 2, new DateTime(2003, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(2862), "Karine", "26245 Raynor Port", "Daniel", 4, 2721 },
                    { 100, new DateTime(1962, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(5329), 2, new DateTime(2020, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(5338), "Sylvester", "1285 Ankunding Haven", "Leannon", 3, 2567 },
                    { 98, new DateTime(1995, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(2987), 1, new DateTime(2001, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(2996), "Alan", "8269 Ryan Estates", "Goldner", 3, 2843 },
                    { 97, new DateTime(1955, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(1824), 3, new DateTime(2017, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(1833), "Malvina", "143 Kshlerin Fort", "Carter", 3, 1108 },
                    { 93, new DateTime(1958, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(5344), 4, new DateTime(2013, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(5354), "Hilbert", "4280 Max Lane", "Hamill", 3, 2741 },
                    { 87, new DateTime(1992, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(4662), 3, new DateTime(2002, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(4671), "Nannie", "53913 Hodkiewicz Dam", "Crona", 3, 2124 },
                    { 86, new DateTime(1969, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(3457), 3, new DateTime(2014, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(3466), "Trevor", "07818 Greenfelder Street", "Ratke", 3, 2308 },
                    { 84, new DateTime(1959, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(1095), 5, new DateTime(2009, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(1104), "Alexandrea", "7597 Gorczany Square", "Little", 3, 1671 },
                    { 77, new DateTime(1955, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(416), 2, new DateTime(2007, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(425), "Cydney", "0006 Chesley Shores", "Padberg", 3, 1587 },
                    { 76, new DateTime(2001, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(8301), 5, new DateTime(2019, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(8311), "Zella", "196 Preston Union", "Turcotte", 3, 2646 },
                    { 75, new DateTime(1991, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(6329), 4, new DateTime(2010, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(6338), "Wilhelmine", "57009 Larkin Unions", "Hickle", 3, 1063 },
                    { 69, new DateTime(2001, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(5550), 5, new DateTime(2020, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(5559), "Jace", "135 Wisozk Station", "Bechtelar", 3, 2310 },
                    { 60, new DateTime(1965, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(2776), 1, new DateTime(2018, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(2785), "Jeanne", "270 Zola Ferry", "Weimann", 3, 1612 },
                    { 58, new DateTime(1984, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(9140), 2, new DateTime(2006, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(9149), "Hortense", "89111 Heaney Radial", "Rolfson", 3, 2223 },
                    { 56, new DateTime(1971, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(6805), 2, new DateTime(2020, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(6815), "Margarette", "818 Zemlak Stream", "Kilback", 3, 2430 },
                    { 43, new DateTime(1982, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(7770), 3, new DateTime(2017, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(7779), "Toy", "5840 Block Manors", "Orn", 3, 1714 },
                    { 39, new DateTime(1978, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(1833), 1, new DateTime(2019, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(1842), "Marjolaine", "1838 Else Branch", "Harber", 3, 2616 },
                    { 33, new DateTime(1979, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(1562), 1, new DateTime(2009, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(1571), "Alexandrine", "546 Ryan Stream", "Armstrong", 4, 2171 },
                    { 37, new DateTime(1970, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(8878), 4, new DateTime(2002, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(8888), "Anahi", "2746 Leda Courts", "Feil", 3, 1410 },
                    { 45, new DateTime(1982, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(717), 4, new DateTime(2010, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(725), "Kristofer", "267 Natasha Ridge", "Hackett", 4, 1650 },
                    { 55, new DateTime(1997, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(5651), 5, new DateTime(2020, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(5660), "Magnolia", "16803 Rodger Trace", "Bernhard", 4, 2117 },
                    { 79, new DateTime(1998, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(3842), 4, new DateTime(2006, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(3851), "Chanelle", "95314 Senger Lakes", "Reilly", 5, 1582 },
                    { 73, new DateTime(1956, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(3163), 5, new DateTime(2007, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(3173), "Martin", "95418 Justyn Turnpike", "Kozey", 5, 2639 },
                    { 61, new DateTime(1981, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(3950), 3, new DateTime(2005, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(3959), "Ramon", "524 Kuhic Forges", "Cronin", 5, 1315 },
                    { 54, new DateTime(1997, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(3837), 1, new DateTime(2011, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(3847), "Hilton", "0749 Kub Brooks", "Kassulke", 5, 2134 },
                    { 52, new DateTime(1963, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(1472), 1, new DateTime(2001, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(1481), "Bria", "73000 Francesco Parkway", "McClure", 5, 2012 },
                    { 49, new DateTime(1973, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(6694), 2, new DateTime(2007, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(6704), "Adrienne", "293 Brandt Creek", "Treutel", 5, 2099 },
                    { 46, new DateTime(1962, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(2507), 2, new DateTime(2004, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(2517), "Peyton", "56431 Kallie Course", "Strosin", 5, 1157 },
                    { 36, new DateTime(1958, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(7091), 2, new DateTime(2003, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(7100), "Katrina", "46156 Nikolas Lock", "Wehner", 5, 2568 },
                    { 32, new DateTime(1968, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(418), 2, new DateTime(2018, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(427), "Aisha", "36310 Bode Square", "Bernhard", 5, 1403 },
                    { 31, new DateTime(1972, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(9283), 3, new DateTime(2010, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(9292), "Brennan", "47599 Amely Summit", "Langworth", 5, 2454 },
                    { 28, new DateTime(1990, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(4596), 1, new DateTime(2019, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(4606), "Ethyl", "852 Bergstrom Drives", "Hermann", 5, 1731 },
                    { 27, new DateTime(1982, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(3403), 4, new DateTime(2008, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(3412), "Marques", "807 Schultz Passage", "Kuvalis", 5, 2517 },
                    { 17, new DateTime(1994, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(5435), 3, new DateTime(2007, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(5466), "Tyson", "527 Conroy Loop", "Kulas", 5, 2443 },
                    { 9, new DateTime(1984, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(2848), 4, new DateTime(2013, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(2858), "Ruby", "170 Leonardo Street", "Hermiston", 5, 1050 },
                    { 2, new DateTime(2004, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(9438), 1, new DateTime(2016, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(9465), "Jeanette", "83318 Mario Points", "Keeling", 5, 2553 },
                    { 85, new DateTime(1965, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(2260), 1, new DateTime(2016, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(2269), "Cali", "494 Braun Passage", "Cummings", 4, 2096 },
                    { 83, new DateTime(1977, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(9959), 2, new DateTime(2004, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(9968), "Coralie", "96960 Rocky Drive", "Barton", 4, 2187 },
                    { 74, new DateTime(1969, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(4711), 1, new DateTime(2013, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(4721), "Ruthie", "75115 Hermiston Keys", "Gusikowski", 4, 2267 },
                    { 67, new DateTime(1993, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(2254), 5, new DateTime(2011, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(2263), "Okey", "55146 Nestor Glens", "Connelly", 4, 2567 },
                    { 66, new DateTime(1975, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(445), 2, new DateTime(2005, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(454), "Kelvin", "973 Brice Skyway", "Bins", 4, 1254 },
                    { 65, new DateTime(1972, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(8633), 2, new DateTime(2001, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(8642), "Annamarie", "3433 Ruecker Rapid", "Shields", 4, 1433 },
                    { 51, new DateTime(1990, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(9667), 4, new DateTime(2009, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(9676), "Camron", "2323 Margaret Hollow", "Effertz", 4, 2053 },
                    { 34, new DateTime(1987, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(3340), 3, new DateTime(2003, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(3349), "Dominique", "847 Chet Port", "Armstrong", 3, 2283 },
                    { 29, new DateTime(1991, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(5729), 3, new DateTime(2006, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(5738), "Cornell", "73085 Graham Landing", "Wolf", 3, 1686 },
                    { 21, new DateTime(1998, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(3767), 3, new DateTime(2016, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(3780), "Napoleon", "11249 Fabian Streets", "Treutel", 3, 1664 },
                    { 5, new DateTime(2000, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(5395), 3, new DateTime(2010, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(5405), "Granville", "521 Cathrine Ferry", "McLaughlin", 2, 1013 },
                    { 3, new DateTime(1990, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(1399), 3, new DateTime(2002, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(1410), "Leonie", "9241 Lacey Station", "Ritchie", 2, 2584 },
                    { 1, new DateTime(1975, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(6007), 3, new DateTime(2004, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(6917), "Brisa", "212 Blick Corners", "Windler", 2, 2799 },
                    { 99, new DateTime(1964, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(4155), 5, new DateTime(2018, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(4163), "Jairo", "13144 Zulauf Stravenue", "Gaylord", 1, 1186 },
                    { 96, new DateTime(1955, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(686), 4, new DateTime(2015, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(695), "Gracie", "69202 Carlo Lane", "Maggio", 1, 1517 },
                    { 92, new DateTime(1966, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(3542), 5, new DateTime(2021, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(3551), "Sandra", "474 Dahlia Neck", "Maggio", 1, 2933 },
                    { 91, new DateTime(1985, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(1781), 1, new DateTime(2011, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(1790), "Destinee", "5242 Greta Court", "Jacobs", 1, 1103 },
                    { 80, new DateTime(1997, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(5692), 1, new DateTime(2001, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(5702), "Ross", "0502 Chauncey Loaf", "Steuber", 1, 2847 },
                    { 78, new DateTime(1972, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(2470), 3, new DateTime(2011, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(2479), "Jaqueline", "24178 Felipe Expressway", "McKenzie", 1, 2988 },
                    { 72, new DateTime(1984, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(708), 1, new DateTime(2015, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(717), "Tyler", "4247 Josefina Road", "Hyatt", 1, 2093 },
                    { 71, new DateTime(1998, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(8551), 3, new DateTime(2008, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(8578), "Ethelyn", "07265 Kovacek Ports", "Watsica", 1, 2462 },
                    { 70, new DateTime(1993, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(7357), 4, new DateTime(2004, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(7367), "Brooklyn", "11177 Krystel Throughway", "Schuster", 1, 1283 },
                    { 64, new DateTime(1956, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(7479), 2, new DateTime(2022, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(7488), "Isabel", "09412 Effertz Dale", "Parker", 1, 1124 },
                    { 57, new DateTime(1997, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(7986), 2, new DateTime(2011, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(7995), "Esperanza", "4331 Bernier Mount", "Lemke", 1, 2626 },
                    { 53, new DateTime(2003, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(2648), 5, new DateTime(2010, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(2657), "Jack", "00418 Witting Springs", "Cummings", 1, 1878 },
                    { 42, new DateTime(2000, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(6584), 2, new DateTime(2017, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(6594), "Justyn", "382 Kunze Summit", "Flatley", 1, 2664 },
                    { 24, new DateTime(1978, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(8655), 4, new DateTime(2013, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(8664), "Samara", "5777 Braeden Causeway", "Wunsch", 1, 2610 },
                    { 23, new DateTime(1969, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(6836), 2, new DateTime(2009, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(6845), "Araceli", "34455 Zboncak Roads", "Kunze", 1, 1310 },
                    { 22, new DateTime(1958, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(5682), 1, new DateTime(2013, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(5691), "Kiarra", "524 Marisa Underpass", "Auer", 1, 1904 },
                    { 18, new DateTime(1967, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(6997), 2, new DateTime(2021, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(7009), "Erwin", "673 Kunze Mission", "Mosciski", 1, 1701 },
                    { 16, new DateTime(2001, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(3846), 3, new DateTime(2010, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(3855), "Amelia", "3940 Daugherty Fort", "Glover", 1, 1731 },
                    { 6, new DateTime(1994, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(7006), 4, new DateTime(2011, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(7016), "Freida", "19845 Yost Union", "Russel", 2, 1412 },
                    { 7, new DateTime(1972, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(8593), 3, new DateTime(2014, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(8603), "Antoinette", "178 Zieme Light", "Mosciski", 2, 2674 },
                    { 13, new DateTime(1969, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(9535), 2, new DateTime(2018, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(9545), "Don", "5002 Jewess Mountain", "Mueller", 2, 2587 },
                    { 19, new DateTime(1976, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(9311), 3, new DateTime(2011, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(9323), "Reilly", "85819 Max Crescent", "Ritchie", 2, 1600 },
                    { 12, new DateTime(1975, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(8325), 1, new DateTime(2016, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(8335), "Maryam", "28734 Kub Rest", "Armstrong", 3, 1808 },
                    { 10, new DateTime(1959, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(5002), 2, new DateTime(2009, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(5012), "Tobin", "2896 Carleton Islands", "Morar", 3, 2044 },
                    { 8, new DateTime(1966, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(759), 5, new DateTime(2012, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(768), "Dominique", "25401 Retha Walks", "Johnson", 3, 1718 },
                    { 95, new DateTime(1958, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(8895), 5, new DateTime(2017, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(8904), "Idell", "624 Danika Lakes", "Brakus", 2, 2999 },
                    { 90, new DateTime(1998, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(9992), 4, new DateTime(2019, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(1), "Cornelius", "21895 Myron Throughway", "Runte", 2, 1190 },
                    { 89, new DateTime(1985, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(8215), 3, new DateTime(2020, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(8224), "Clarissa", "7866 Kaleigh Prairie", "Wiegand", 2, 1676 },
                    { 88, new DateTime(2000, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(6434), 2, new DateTime(2005, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(6443), "Sheila", "80844 Stacey Mountains", "Huels", 2, 1311 },
                    { 81, new DateTime(1970, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(6851), 2, new DateTime(2020, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(6861), "Timmy", "7520 Kshlerin Brook", "Terry", 2, 2514 },
                    { 68, new DateTime(1964, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(4359), 5, new DateTime(2021, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(4368), "Gianni", "466 Beaulah Loaf", "Marvin", 2, 1704 },
                    { 63, new DateTime(1960, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(6300), 5, new DateTime(2021, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(6309), "Jakayla", "9605 Jerde Dale", "Predovic", 2, 2507 },
                    { 82, new DateTime(1959, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(8084), 5, new DateTime(2018, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(8093), "Bette", "332 Beier Circles", "Kuhn", 5, 2731 },
                    { 62, new DateTime(1980, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(5120), 2, new DateTime(2021, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(5129), "Amina", "8028 Ward Turnpike", "King", 2, 1017 },
                    { 50, new DateTime(1956, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(7854), 1, new DateTime(2021, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(7863), "Trenton", "7866 Von Meadow", "Macejkovic", 2, 1190 },
                    { 48, new DateTime(1988, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(4884), 2, new DateTime(2010, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(4894), "Ronaldo", "92005 Kunde Brooks", "Gutkowski", 2, 1750 },
                    { 47, new DateTime(1956, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(3700), 3, new DateTime(2008, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(3710), "Reggie", "99150 Senger Island", "Walker", 2, 2535 },
                    { 44, new DateTime(1996, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(8919), 4, new DateTime(2010, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(8929), "Luella", "743 Toy Mill", "Gusikowski", 2, 2095 },
                    { 41, new DateTime(1969, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(5429), 4, new DateTime(2003, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(5438), "Blake", "25294 Barrett Gardens", "Gerlach", 2, 1496 },
                    { 40, new DateTime(1974, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(3618), 1, new DateTime(2021, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(3627), "Myra", "84606 Randall Expressway", "Ritchie", 2, 2876 },
                    { 38, new DateTime(1978, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(25), 4, new DateTime(2019, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(34), "Prince", "74851 Turcotte Spur", "Mann", 2, 2783 },
                    { 35, new DateTime(1971, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(5233), 5, new DateTime(2008, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(5251), "Jamil", "008 Ethel Rue", "Swaniawski", 2, 2621 },
                    { 30, new DateTime(1974, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(7485), 1, new DateTime(2021, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(7494), "Modesto", "052 Joel Fords", "Emard", 2, 1539 },
                    { 20, new DateTime(1966, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(1567), 5, new DateTime(2002, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(1579), "Adolfo", "696 Eladio Haven", "Toy", 2, 2032 },
                    { 59, new DateTime(1979, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(960), 3, new DateTime(2012, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(970), "Ashton", "4806 Ariel Trail", "Koch", 2, 2816 },
                    { 94, new DateTime(1960, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(7126), 1, new DateTime(2011, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(7136), "Libbie", "3118 Allison Fort", "Abernathy", 5, 1248 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BossId",
                table: "Employees",
                column: "BossId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleId",
                table: "Employees",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
