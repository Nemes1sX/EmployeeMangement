using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMangement.Migrations
{
    public partial class EmployeeCreater : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Bosses_BossId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "BossId",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Pearlie", "Strosin" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Eda", "Spinka" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Otilia", "Zboncak" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dovie", "Abshire" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Matt", "Homenick" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1954, 1, 30, 18, 46, 9, 953, DateTimeKind.Local).AddTicks(5987), 5, new DateTime(2003, 1, 30, 18, 46, 9, 953, DateTimeKind.Local).AddTicks(6894), "Geo", "392 Hettie Court", "Eichmann", 3, 2646 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 30, 18, 46, 9, 953, DateTimeKind.Local).AddTicks(8869), 2, new DateTime(2012, 1, 30, 18, 46, 9, 953, DateTimeKind.Local).AddTicks(8899), "Jennifer", "718 Kuhlman Way", "Treutel", 3, 2660 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(915), 5, new DateTime(2019, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(946), "Berenice", "80838 Vern Oval", "Greenfelder", 1, 1228 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1960, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(2159), new DateTime(2017, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(2169), "Roslyn", "67852 Schoen Pike", "Kovacek", 2, 2732 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1957, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(3461), 4, new DateTime(2004, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(3471), "Grace", "7580 Quigley Ferry", "Nikolaus", 1, 2177 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(2002, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(5400), 5, new DateTime(2013, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(5410), "Katelyn", "266 Clifton Gateway", "Braun", 1769 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1970, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(6614), 1, new DateTime(2002, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(6624), "Clemmie", "12805 Altenwerth Run", "Okuneva", 3, 1625 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1957, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(7864), new DateTime(2020, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(7874), "Kaylah", "670 Thiel Place", "Jacobs", 5, 2258 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1973, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(9771), 1, new DateTime(2008, 1, 30, 18, 46, 9, 954, DateTimeKind.Local).AddTicks(9781), "Ova", "5759 Fausto Roads", "Rau", 1355 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1990, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(1716), 4, new DateTime(2009, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(1725), "Cornell", "1867 Syble Loop", "Nicolas", 1571 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1968, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(3600), 4, new DateTime(2004, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(3616), "Adrienne", "127 Hailey Creek", "Littel", 2518 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1959, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(4986), 5, new DateTime(2003, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(5005), "Eve", "590 Goyette Gardens", "Bartoletti", 5, 1183 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(6174), 5, new DateTime(2004, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(6184), "Bria", "37240 Cremin Ville", "Gulgowski", 5, 2872 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1988, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(8095), 4, new DateTime(2001, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(8106), "Mozelle", "426 Peyton Rapid", "Mann", 2, 1495 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1972, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(9557), new DateTime(2007, 1, 30, 18, 46, 9, 955, DateTimeKind.Local).AddTicks(9569), "Rachel", "52841 Ernser Center", "Simonis", 3, 2306 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1971, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(754), 4, new DateTime(2001, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(764), "Fidel", "9085 Hand Cove", "Auer", 3, 2459 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1992, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(2601), 2, new DateTime(2016, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(2611), "Giovani", "40289 Adalberto Brooks", "Parker", 1155 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1978, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(3815), 3, new DateTime(2017, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(3825), "Dan", "98234 Romaguera Prairie", "Nienow", 4, 2336 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1997, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(5863), 1, new DateTime(2022, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(5873), "Luz", "021 Bartholome Roads", "Schinner", 2856 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1985, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(7079), 2, new DateTime(2014, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(7089), "Emmy", "75256 Wintheiser Underpass", "Torphy", 1, 2807 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1959, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(8915), 5, new DateTime(2022, 1, 30, 18, 46, 9, 956, DateTimeKind.Local).AddTicks(8924), "Gordon", "069 Korbin Ramp", "Wisozk", 1, 1732 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1990, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(103), 3, new DateTime(2003, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(111), "Chaz", "04585 Schoen Gardens", "Balistreri", 4, 1530 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1989, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(1325), 1, new DateTime(2010, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(1335), "Elna", "044 Gutmann Walk", "Cassin", 3, 1629 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1954, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(2507), 5, new DateTime(2016, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(2516), "Furman", "50380 Beer Estates", "Labadie", 5, 1548 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1959, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(4370), 5, new DateTime(2011, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(4379), "Agustin", "399 Lucinda Drives", "Swaniawski", 1, 1762 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1980, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(6203), 1, new DateTime(2005, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(6213), "Rodrigo", "70159 Jessyca Divide", "Mitchell", 1821 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2004, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(8095), 2, new DateTime(2009, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(8105), "Edwina", "43846 Garrick Mountain", "Runolfsson", 4, 2532 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1986, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(9943), new DateTime(2020, 1, 30, 18, 46, 9, 957, DateTimeKind.Local).AddTicks(9953), "Hermann", "657 Wyman Ford", "Stracke", 1, 2698 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2003, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(1930), 1, new DateTime(2003, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(1941), "Adolph", "648 Kayli Run", "Schuppe", 1, 1833 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1968, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(3303), 3, new DateTime(2002, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(3314), "George", "44323 Howe Turnpike", "Heidenreich", 5, 2326 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1960, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(4537), 4, new DateTime(2003, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(4546), "Freeman", "2982 Hudson Port", "Hyatt", 4, 1744 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1973, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(5726), 3, new DateTime(2018, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(5735), "Billy", "578 Bergnaum Route", "Stehr", 4, 2402 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1994, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(6921), new DateTime(2021, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(6930), "Norene", "858 Mann Dam", "Abshire", 2, 2796 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1994, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(8095), 5, new DateTime(2015, 1, 30, 18, 46, 9, 958, DateTimeKind.Local).AddTicks(8104), "Hollie", "5240 Hane Crossroad", "Skiles", 2, 1315 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1982, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(125), new DateTime(2008, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(136), "Beatrice", "68960 Adalberto Ports", "Metz", 5, 2497 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1955, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(2011), 1, new DateTime(2010, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(2021), "Alexa", "16790 Aric Cape", "Hamill", 2, 1046 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1989, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(3232), 2, new DateTime(2003, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(3241), "Savannah", "66869 White Trace", "Volkman", 1, 1257 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1966, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(4463), 1, new DateTime(2008, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(4473), "Keyon", "77348 Witting Run", "Sanford", 5, 1028 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1975, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(5655), 4, new DateTime(2001, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(5664), "Odessa", "6149 Schinner Estate", "Kassulke", 2469 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1974, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(6862), 5, new DateTime(2018, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(6871), "Calista", "00518 Jones Locks", "Schamberger", 2015 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1959, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(8058), 1, new DateTime(2001, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(8068), "Rachelle", "9922 Keebler Islands", "Bechtelar", 3, 2101 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2000, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(9275), new DateTime(2020, 1, 30, 18, 46, 9, 959, DateTimeKind.Local).AddTicks(9285), "Bridget", "9772 Dach Club", "Kassulke", 2, 1321 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1992, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(1138), 1, new DateTime(2004, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(1148), "Buster", "61569 Destinee Station", "Beier", 2, 2362 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1954, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(3005), 1, new DateTime(2009, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(3014), "Oscar", "140 Rosetta Rapid", "Auer", 3, 1021 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1954, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(4888), 5, new DateTime(2014, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(4898), "Izaiah", "245 Geoffrey Mission", "Wolf", 2, 1618 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1992, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(6173), new DateTime(2016, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(6183), "Mabel", "67590 Gutkowski Port", "Schmitt", 4, 1531 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1987, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(8047), 1, new DateTime(2013, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(8057), "Simeon", "73448 Kiarra Ford", "Gislason", 1096 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1978, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(9252), 5, new DateTime(2001, 1, 30, 18, 46, 9, 960, DateTimeKind.Local).AddTicks(9262), "Luther", "4518 Brekke Villages", "Feest", 5, 2028 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1984, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(510), 5, new DateTime(2021, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(520), "Alana", "621 Hegmann Plaza", "Marks", 2, 2604 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(2511), 2, new DateTime(2018, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(2521), "Caleb", "1312 Ambrose Coves", "Walsh", 1, 2310 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1986, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(3753), 5, new DateTime(2009, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(3763), "Marta", "011 Reynolds Cliffs", "Satterfield", 1043 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1958, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(5706), 3, new DateTime(2018, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(5716), "Osvaldo", "0197 Korey Fords", "Kshlerin", 1614 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1976, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(6921), new DateTime(2003, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(6931), "Stan", "269 Hickle Fork", "Rosenbaum", 2, 1960 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1979, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(8275), 3, new DateTime(2020, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(8284), "Jason", "302 Schoen Skyway", "Bernhard", 4, 1380 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1958, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(9529), 4, new DateTime(2008, 1, 30, 18, 46, 9, 961, DateTimeKind.Local).AddTicks(9538), "Kieran", "214 McCullough Camp", "Ondricka", 3, 1204 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1976, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(1452), 5, new DateTime(2022, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(1462), "Celestine", "1780 Sid Way", "Pacocha", 5, 2847 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1990, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(2752), 5, new DateTime(2012, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(2761), "Demetris", "2887 Goodwin Common", "Gulgowski", 5, 2313 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(2001, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(4096), 5, new DateTime(2003, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(4106), "Dovie", "80956 Wunsch Island", "Keeling", 1041 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1963, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(6076), new DateTime(2012, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(6107), "Okey", "82722 Rosendo Pike", "Abshire", 4, 2918 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1955, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(7416), 4, new DateTime(2015, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(7425), "Amari", "7563 Schuster Village", "Glover", 1930 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1999, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(9373), 2, new DateTime(2009, 1, 30, 18, 46, 9, 962, DateTimeKind.Local).AddTicks(9382), "Anabelle", "8178 Oswald Motorway", "McGlynn", 4, 1229 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1984, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(1323), 1, new DateTime(2022, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(1333), "Brooke", "1088 Giles Ports", "Kuvalis", 5, 1679 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1982, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(3225), 4, new DateTime(2008, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(3235), "Stuart", "158 Anibal Plaza", "O'Connell", 1, 1019 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1992, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(4531), 3, new DateTime(2004, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(4540), "Davon", "4676 Powlowski Neck", "Leuschke", 5, 2543 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1985, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(5867), 4, new DateTime(2006, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(5877), "Jerrell", "2185 Bogisich Corner", "Runte", 5, 2815 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1990, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(7809), 4, new DateTime(2012, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(7818), "Kristofer", "7498 Axel Run", "Bode", 2351 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1989, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(9082), 3, new DateTime(2014, 1, 30, 18, 46, 9, 963, DateTimeKind.Local).AddTicks(9091), "Alex", "53210 Emard Burg", "McDermott", 1, 2363 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1959, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(413), 4, new DateTime(2017, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(422), "Abbigail", "748 Howell Mountain", "Grimes", 5, 2970 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1999, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(1669), 1, new DateTime(2003, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(1679), "Dino", "0408 Kertzmann Shores", "Stark", 2, 1766 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1975, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(3029), 1, new DateTime(2015, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(3039), "Bill", "10006 Schaefer Manors", "Brown", 2, 2485 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1986, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(4253), 2, new DateTime(2003, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(4263), "Samantha", "748 Grady Unions", "Pollich", 3, 1498 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1968, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(5482), 4, new DateTime(2016, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(5492), "Amelia", "003 Herman Turnpike", "Satterfield", 5, 2496 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1960, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(6744), 2, new DateTime(2018, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(6754), "Rozella", "73362 Wyman Fort", "Franecki", 4, 2421 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1953, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(8722), 5, new DateTime(2003, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(8731), "Elsa", "598 Audie Meadow", "Kling", 2, 2710 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1985, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(9948), 5, new DateTime(2008, 1, 30, 18, 46, 9, 964, DateTimeKind.Local).AddTicks(9957), "Dario", "59893 Cartwright Manor", "Orn", 1, 1520 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1995, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(1126), 1, new DateTime(2002, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(1135), "Vito", "44019 King Locks", "Quitzon", 2, 2069 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1998, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(2396), 4, new DateTime(2015, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(2405), "Alaina", "4915 Hagenes Lake", "Lubowitz", 5, 2911 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1998, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(3659), 4, new DateTime(2006, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(3669), "Carrie", "37832 Stroman Valley", "King", 4, 1513 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1993, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(5630), 5, new DateTime(2004, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(5640), "Naomi", "75359 Nico Lock", "Kulas", 1, 1957 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(6830), 2, new DateTime(2003, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(6839), "Lillie", "60955 Nolan Stravenue", "Buckridge", 3, 2939 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1971, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(8752), new DateTime(2008, 1, 30, 18, 46, 9, 965, DateTimeKind.Local).AddTicks(8762), "Randall", "452 Ian Rapids", "Dibbert", 4, 1212 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1967, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(52), 2, new DateTime(2019, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(62), "Nash", "967 Lesch Hill", "Denesik", 1, 1319 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1984, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(1299), 3, new DateTime(2021, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(1308), "Tobin", "6317 Friesen Ranch", "Kshlerin", 1, 1531 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1966, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(2525), 4, new DateTime(2002, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(2535), "Layne", "258 Hammes Radial", "Schmidt", 1523 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1974, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(3697), 2, new DateTime(2005, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(3706), "Jaycee", "126 Purdy Bypass", "Kreiger", 3, 2796 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(4874), 5, new DateTime(2002, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(4884), "Odell", "367 Zemlak Union", "Russel", 5, 2579 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1956, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(6105), new DateTime(2009, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(6115), "Hassie", "64061 Quigley Gateway", "O'Hara", 2, 2253 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1953, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(7412), 1, new DateTime(2018, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(7422), "Angie", "93409 Reynolds Wall", "Breitenberg", 1, 2252 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1958, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(8627), 4, new DateTime(2020, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(8637), "Brendon", "09510 Muller Inlet", "Stokes", 5, 1893 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1995, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(9780), 1, new DateTime(2017, 1, 30, 18, 46, 9, 966, DateTimeKind.Local).AddTicks(9789), "Niko", "718 Murray Land", "Brekke", 4, 1761 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(1601), 3, new DateTime(2014, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(1611), "Garett", "1789 Iva Bridge", "Ruecker", 3, 1663 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1980, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(2846), 2, new DateTime(2006, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(2856), "Marcos", "60390 Oberbrunner Meadow", "Altenwerth", 2, 1635 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1975, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(4785), 1, new DateTime(2015, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(4795), "Matilde", "95406 Dillan Parkways", "Friesen", 1, 1282 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1986, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(6618), 2, new DateTime(2001, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(6628), "Julio", "89700 Garnet Pass", "Predovic", 2, 1078 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1992, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(8471), 1, new DateTime(2020, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(8481), "Marina", "492 Jaime Extensions", "Bruen", 5, 2172 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2003, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(9766), new DateTime(2017, 1, 30, 18, 46, 9, 967, DateTimeKind.Local).AddTicks(9776), "Valentin", "0911 Treutel Heights", "Gleason", 3, 1191 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1999, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(1597), 1, new DateTime(2007, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(1607), "Brianne", "636 Jalon Tunnel", "Reilly", 1, 2144 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1968, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(3397), 2, new DateTime(2007, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(3406), "Adrien", "29238 Raleigh Trail", "Eichmann", 1, 1478 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1996, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(5355), 1, new DateTime(2010, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(5364), "Anastacio", "3668 Raphael Mill", "Heathcote", 3, 1512 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1957, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(6582), 3, new DateTime(2005, 1, 30, 18, 46, 9, 968, DateTimeKind.Local).AddTicks(6591), "Casey", "86349 Pagac Lodge", "Ledner", 1, 1719 });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Bosses_BossId",
                table: "Employees",
                column: "BossId",
                principalTable: "Bosses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Bosses_BossId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "BossId",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Adrian", "Tremblay" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Raleigh", "Altenwerth" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ferne", "Hagenes" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Geraldine", "Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "Bosses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Frieda", "Rowe" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1975, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(6007), 3, new DateTime(2004, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(6917), "Brisa", "212 Blick Corners", "Windler", 2, 2799 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2004, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(9438), 1, new DateTime(2016, 1, 28, 23, 54, 56, 144, DateTimeKind.Local).AddTicks(9465), "Jeanette", "83318 Mario Points", "Keeling", 5, 2553 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1990, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(1399), 3, new DateTime(2002, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(1410), "Leonie", "9241 Lacey Station", "Ritchie", 2, 2584 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1987, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(2853), new DateTime(2003, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(2862), "Karine", "26245 Raynor Port", "Daniel", 4, 2721 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2000, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(5395), 3, new DateTime(2010, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(5405), "Granville", "521 Cathrine Ferry", "McLaughlin", 2, 1013 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1994, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(7006), 4, new DateTime(2011, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(7016), "Freida", "19845 Yost Union", "Russel", 1412 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1972, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(8593), 3, new DateTime(2014, 1, 28, 23, 54, 56, 145, DateTimeKind.Local).AddTicks(8603), "Antoinette", "178 Zieme Light", "Mosciski", 2, 2674 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1966, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(759), new DateTime(2012, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(768), "Dominique", "25401 Retha Walks", "Johnson", 3, 1718 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1984, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(2848), 4, new DateTime(2013, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(2858), "Ruby", "170 Leonardo Street", "Hermiston", 1050 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1959, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(5002), 2, new DateTime(2009, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(5012), "Tobin", "2896 Carleton Islands", "Morar", 2044 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1979, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(7081), 2, new DateTime(2013, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(7091), "Paolo", "88514 Yazmin Ways", "Zemlak", 2735 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1975, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(8325), 1, new DateTime(2016, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(8335), "Maryam", "28734 Kub Rest", "Armstrong", 3, 1808 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(9535), 2, new DateTime(2018, 1, 28, 23, 54, 56, 146, DateTimeKind.Local).AddTicks(9545), "Don", "5002 Jewess Mountain", "Mueller", 2, 2587 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1988, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(1410), 5, new DateTime(2006, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(1420), "Polly", "839 Kaycee Harbor", "Erdman", 1, 1173 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1996, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(2652), new DateTime(2003, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(2662), "Kiarra", "9707 Douglas Green", "Lind", 4, 1556 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2001, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(3846), 3, new DateTime(2010, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(3855), "Amelia", "3940 Daugherty Fort", "Glover", 1, 1731 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1994, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(5435), 3, new DateTime(2007, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(5466), "Tyson", "527 Conroy Loop", "Kulas", 2443 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1967, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(6997), 2, new DateTime(2021, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(7009), "Erwin", "673 Kunze Mission", "Mosciski", 1, 1701 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1976, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(9311), 3, new DateTime(2011, 1, 28, 23, 54, 56, 147, DateTimeKind.Local).AddTicks(9323), "Reilly", "85819 Max Crescent", "Ritchie", 1600 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1966, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(1567), 5, new DateTime(2002, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(1579), "Adolfo", "696 Eladio Haven", "Toy", 2, 2032 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1998, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(3767), 3, new DateTime(2016, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(3780), "Napoleon", "11249 Fabian Streets", "Treutel", 3, 1664 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1958, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(5682), 1, new DateTime(2013, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(5691), "Kiarra", "524 Marisa Underpass", "Auer", 1, 1904 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(6836), 2, new DateTime(2009, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(6845), "Araceli", "34455 Zboncak Roads", "Kunze", 1, 1310 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1978, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(8655), 4, new DateTime(2013, 1, 28, 23, 54, 56, 148, DateTimeKind.Local).AddTicks(8664), "Samara", "5777 Braeden Causeway", "Wunsch", 1, 2610 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1970, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(458), 2, new DateTime(2002, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(467), "Ezequiel", "4720 Arturo Fall", "Hane", 4, 2651 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1981, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(2248), 5, new DateTime(2005, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(2257), "Santiago", "9281 Mohammad Motorway", "Schaefer", 1920 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1982, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(3403), 4, new DateTime(2008, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(3412), "Marques", "807 Schultz Passage", "Kuvalis", 5, 2517 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1990, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(4596), new DateTime(2019, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(4606), "Ethyl", "852 Bergstrom Drives", "Hermann", 5, 1731 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1991, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(5729), 3, new DateTime(2006, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(5738), "Cornell", "73085 Graham Landing", "Wolf", 3, 1686 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1974, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(7485), 1, new DateTime(2021, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(7494), "Modesto", "052 Joel Fords", "Emard", 2, 1539 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1972, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(9283), 3, new DateTime(2010, 1, 28, 23, 54, 56, 149, DateTimeKind.Local).AddTicks(9292), "Brennan", "47599 Amely Summit", "Langworth", 5, 2454 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1968, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(418), 2, new DateTime(2018, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(427), "Aisha", "36310 Bode Square", "Bernhard", 5, 1403 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1979, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(1562), new DateTime(2009, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(1571), "Alexandrine", "546 Ryan Stream", "Armstrong", 4, 2171 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1987, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(3340), 3, new DateTime(2003, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(3349), "Dominique", "847 Chet Port", "Armstrong", 3, 2283 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1971, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(5233), new DateTime(2008, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(5251), "Jamil", "008 Ethel Rue", "Swaniawski", 2, 2621 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1958, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(7091), 2, new DateTime(2003, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(7100), "Katrina", "46156 Nikolas Lock", "Wehner", 5, 2568 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1970, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(8878), 4, new DateTime(2002, 1, 28, 23, 54, 56, 150, DateTimeKind.Local).AddTicks(8888), "Anahi", "2746 Leda Courts", "Feil", 3, 1410 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1978, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(25), 4, new DateTime(2019, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(34), "Prince", "74851 Turcotte Spur", "Mann", 2, 2783 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1978, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(1833), 1, new DateTime(2019, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(1842), "Marjolaine", "1838 Else Branch", "Harber", 2616 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1974, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(3618), 1, new DateTime(2021, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(3627), "Myra", "84606 Randall Expressway", "Ritchie", 2876 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(5429), 4, new DateTime(2003, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(5438), "Blake", "25294 Barrett Gardens", "Gerlach", 2, 1496 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2000, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(6584), new DateTime(2017, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(6594), "Justyn", "382 Kunze Summit", "Flatley", 1, 2664 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1982, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(7770), 3, new DateTime(2017, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(7779), "Toy", "5840 Block Manors", "Orn", 3, 1714 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1996, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(8919), 4, new DateTime(2010, 1, 28, 23, 54, 56, 151, DateTimeKind.Local).AddTicks(8929), "Luella", "743 Toy Mill", "Gusikowski", 2, 2095 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1982, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(717), 4, new DateTime(2010, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(725), "Kristofer", "267 Natasha Ridge", "Hackett", 4, 1650 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1962, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(2507), new DateTime(2004, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(2517), "Peyton", "56431 Kallie Course", "Strosin", 5, 1157 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1956, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(3700), 3, new DateTime(2008, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(3710), "Reggie", "99150 Senger Island", "Walker", 2535 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1988, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(4884), 2, new DateTime(2010, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(4894), "Ronaldo", "92005 Kunde Brooks", "Gutkowski", 2, 1750 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1973, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(6694), 2, new DateTime(2007, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(6704), "Adrienne", "293 Brandt Creek", "Treutel", 5, 2099 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1956, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(7854), 1, new DateTime(2021, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(7863), "Trenton", "7866 Von Meadow", "Macejkovic", 2, 1190 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1990, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(9667), 4, new DateTime(2009, 1, 28, 23, 54, 56, 152, DateTimeKind.Local).AddTicks(9676), "Camron", "2323 Margaret Hollow", "Effertz", 2053 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1963, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(1472), 1, new DateTime(2001, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(1481), "Bria", "73000 Francesco Parkway", "McClure", 2012 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2003, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(2648), new DateTime(2010, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(2657), "Jack", "00418 Witting Springs", "Cummings", 1, 1878 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1997, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(3837), 1, new DateTime(2011, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(3847), "Hilton", "0749 Kub Brooks", "Kassulke", 5, 2134 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1997, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(5651), 5, new DateTime(2020, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(5660), "Magnolia", "16803 Rodger Trace", "Bernhard", 4, 2117 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1971, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(6805), 2, new DateTime(2020, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(6815), "Margarette", "818 Zemlak Stream", "Kilback", 3, 2430 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1997, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(7986), 2, new DateTime(2011, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(7995), "Esperanza", "4331 Bernier Mount", "Lemke", 1, 2626 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1984, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(9140), 2, new DateTime(2006, 1, 28, 23, 54, 56, 153, DateTimeKind.Local).AddTicks(9149), "Hortense", "89111 Heaney Radial", "Rolfson", 2223 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1979, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(960), new DateTime(2012, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(970), "Ashton", "4806 Ariel Trail", "Koch", 2, 2816 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1965, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(2776), 1, new DateTime(2018, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(2785), "Jeanne", "270 Zola Ferry", "Weimann", 1612 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1981, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(3950), 3, new DateTime(2005, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(3959), "Ramon", "524 Kuhic Forges", "Cronin", 5, 1315 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1980, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(5120), 2, new DateTime(2021, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(5129), "Amina", "8028 Ward Turnpike", "King", 2, 1017 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1960, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(6300), 5, new DateTime(2021, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(6309), "Jakayla", "9605 Jerde Dale", "Predovic", 2, 2507 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1956, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(7479), 2, new DateTime(2022, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(7488), "Isabel", "09412 Effertz Dale", "Parker", 1, 1124 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1972, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(8633), 2, new DateTime(2001, 1, 28, 23, 54, 56, 154, DateTimeKind.Local).AddTicks(8642), "Annamarie", "3433 Ruecker Rapid", "Shields", 4, 1433 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1975, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(445), 2, new DateTime(2005, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(454), "Kelvin", "973 Brice Skyway", "Bins", 1254 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1993, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(2254), 5, new DateTime(2011, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(2263), "Okey", "55146 Nestor Glens", "Connelly", 4, 2567 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(4359), 5, new DateTime(2021, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(4368), "Gianni", "466 Beaulah Loaf", "Marvin", 2, 1704 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2001, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(5550), 5, new DateTime(2020, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(5559), "Jace", "135 Wisozk Station", "Bechtelar", 3, 2310 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1993, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(7357), 4, new DateTime(2004, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(7367), "Brooklyn", "11177 Krystel Throughway", "Schuster", 1, 1283 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1998, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(8551), 3, new DateTime(2008, 1, 28, 23, 54, 56, 155, DateTimeKind.Local).AddTicks(8578), "Ethelyn", "07265 Kovacek Ports", "Watsica", 1, 2462 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1984, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(708), 1, new DateTime(2015, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(717), "Tyler", "4247 Josefina Road", "Hyatt", 1, 2093 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1956, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(3163), 5, new DateTime(2007, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(3173), "Martin", "95418 Justyn Turnpike", "Kozey", 5, 2639 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(4711), 1, new DateTime(2013, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(4721), "Ruthie", "75115 Hermiston Keys", "Gusikowski", 4, 2267 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1991, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(6329), 4, new DateTime(2010, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(6338), "Wilhelmine", "57009 Larkin Unions", "Hickle", 3, 1063 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2001, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(8301), 5, new DateTime(2019, 1, 28, 23, 54, 56, 156, DateTimeKind.Local).AddTicks(8311), "Zella", "196 Preston Union", "Turcotte", 3, 2646 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1955, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(416), 2, new DateTime(2007, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(425), "Cydney", "0006 Chesley Shores", "Padberg", 3, 1587 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1972, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(2470), 3, new DateTime(2011, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(2479), "Jaqueline", "24178 Felipe Expressway", "McKenzie", 1, 2988 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1998, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(3842), 4, new DateTime(2006, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(3851), "Chanelle", "95314 Senger Lakes", "Reilly", 5, 1582 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1997, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(5692), 1, new DateTime(2001, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(5702), "Ross", "0502 Chauncey Loaf", "Steuber", 1, 2847 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1970, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(6851), new DateTime(2020, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(6861), "Timmy", "7520 Kshlerin Brook", "Terry", 2, 2514 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1959, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(8084), 5, new DateTime(2018, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(8093), "Bette", "332 Beier Circles", "Kuhn", 5, 2731 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1977, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(9959), 2, new DateTime(2004, 1, 28, 23, 54, 56, 157, DateTimeKind.Local).AddTicks(9968), "Coralie", "96960 Rocky Drive", "Barton", 4, 2187 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "Salary" },
                values: new object[] { new DateTime(1959, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(1095), 5, new DateTime(2009, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(1104), "Alexandrea", "7597 Gorczany Square", "Little", 1671 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1965, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(2260), 1, new DateTime(2016, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(2269), "Cali", "494 Braun Passage", "Cummings", 4, 2096 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1969, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(3457), 3, new DateTime(2014, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(3466), "Trevor", "07818 Greenfelder Street", "Ratke", 3, 2308 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1992, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(4662), new DateTime(2002, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(4671), "Nannie", "53913 Hodkiewicz Dam", "Crona", 3, 2124 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(2000, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(6434), 2, new DateTime(2005, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(6443), "Sheila", "80844 Stacey Mountains", "Huels", 2, 1311 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1985, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(8215), 3, new DateTime(2020, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(8224), "Clarissa", "7866 Kaleigh Prairie", "Wiegand", 2, 1676 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1998, 1, 28, 23, 54, 56, 158, DateTimeKind.Local).AddTicks(9992), 4, new DateTime(2019, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(1), "Cornelius", "21895 Myron Throughway", "Runte", 2, 1190 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1985, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(1781), 1, new DateTime(2011, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(1790), "Destinee", "5242 Greta Court", "Jacobs", 1, 1103 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1966, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(3542), 5, new DateTime(2021, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(3551), "Sandra", "474 Dahlia Neck", "Maggio", 1, 2933 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1958, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(5344), 4, new DateTime(2013, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(5354), "Hilbert", "4280 Max Lane", "Hamill", 3, 2741 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1960, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(7126), 1, new DateTime(2011, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(7136), "Libbie", "3118 Allison Fort", "Abernathy", 5, 1248 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1958, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(8895), 5, new DateTime(2017, 1, 28, 23, 54, 56, 159, DateTimeKind.Local).AddTicks(8904), "Idell", "624 Danika Lakes", "Brakus", 2, 2999 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BirthDate", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1955, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(686), new DateTime(2015, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(695), "Gracie", "69202 Carlo Lane", "Maggio", 1, 1517 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1955, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(1824), 3, new DateTime(2017, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(1833), "Malvina", "143 Kshlerin Fort", "Carter", 3, 1108 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1995, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(2987), 1, new DateTime(2001, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(2996), "Alan", "8269 Ryan Estates", "Goldner", 3, 2843 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1964, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(4155), 5, new DateTime(2018, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(4163), "Jairo", "13144 Zulauf Stravenue", "Gaylord", 1, 1186 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BirthDate", "BossId", "EmploymentDate", "FirstName", "HomeAddress", "LastName", "RoleId", "Salary" },
                values: new object[] { new DateTime(1962, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(5329), 2, new DateTime(2020, 1, 28, 23, 54, 56, 160, DateTimeKind.Local).AddTicks(5338), "Sylvester", "1285 Ankunding Haven", "Leannon", 3, 2567 });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Bosses_BossId",
                table: "Employees",
                column: "BossId",
                principalTable: "Bosses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
