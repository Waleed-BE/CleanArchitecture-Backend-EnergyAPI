using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Live_Initial_MigrationDBCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 0,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 7, 18, 51, 44, 337, DateTimeKind.Utc).AddTicks(8459), new Guid("aa1c916a-42d3-4f74-8d47-502711ee8998") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 7, 18, 51, 44, 337, DateTimeKind.Utc).AddTicks(8468), new Guid("15dcb340-9ef2-4ad0-b9ed-42855d69cf63") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 7, 18, 51, 44, 337, DateTimeKind.Utc).AddTicks(8471), new Guid("293cd076-df96-434c-81a3-7f4b9f65603c") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 7, 18, 51, 44, 337, DateTimeKind.Utc).AddTicks(8486), new Guid("292143e5-a88b-4900-90b2-83d4b584ba94") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 7, 18, 51, 44, 337, DateTimeKind.Utc).AddTicks(8489), new Guid("699cb650-7a40-41f9-bc1b-153520371a75") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 0,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 6, 19, 2, 52, 334, DateTimeKind.Utc).AddTicks(2981), new Guid("229da05a-1b09-481c-a444-1d128cf262a0") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 6, 19, 2, 52, 334, DateTimeKind.Utc).AddTicks(2986), new Guid("2c0225d8-5c92-4323-bdc5-de2b3a010a10") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 6, 19, 2, 52, 334, DateTimeKind.Utc).AddTicks(2989), new Guid("ecf8830f-8fa3-4756-a270-3a4873e7df78") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 6, 19, 2, 52, 334, DateTimeKind.Utc).AddTicks(2991), new Guid("0ae7befb-ab40-4937-afce-2b96d6b0ab9d") });

            migrationBuilder.UpdateData(
                table: "TblStatus",
                keyColumn: "StatusId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Id" },
                values: new object[] { new DateTime(2025, 3, 6, 19, 2, 52, 334, DateTimeKind.Utc).AddTicks(2995), new Guid("6b3703cb-b0d8-4943-8ac6-ee91499d33d7") });
        }
    }
}
