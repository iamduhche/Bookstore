using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreCafe.Data.Migrations
{
    public partial class UpdatedAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20561e21-6c83-4d0c-bfbd-0d4f00712fd2", "AQAAAAEAACcQAAAAEFfbpB7DPqkkqzeHs5pFHXVQ98XNK1tNgvINSLppTfk7ay7qWZ/azpWe142c0uOTjg==", "8bdf5e8f-1496-4fab-855c-d35818763b24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4bc382c-69a1-4547-a30a-0ca320d951b9", "AQAAAAEAACcQAAAAEIe2oDTKHwNhjBrsvJnB8qC+/fFnZ8R00/zik6t+52iWiRcWElPJId+jvDbNXwo5uQ==", "e724a8a0-6f5a-413e-b22e-ef9954f54f42" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1297764b-dd30-4c4a-be10-a188dde20808",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ebc0aba-c9e8-4dd9-8556-4a1665a28334", "AQAAAAEAACcQAAAAEFZUN4Ki7hkobl++975edqs+9NkhDCp9tOaKf3gDB3YQ2bf9twxg5RfDnCWZ3elxDg==", "5c320371-24df-46a4-bd67-75aa9a045084" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "574371A3-4F4E-409A-9A0E-B2F1EA03E1AB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06a6c5e8-31b3-4274-b29b-2b33d2afb363", "AQAAAAEAACcQAAAAENWw2Cqb+5VysvRvM7mAr791D0eER/aALD8dvh2qYDHWsf3opiGrEC12oSN5pA+qWw==", "1dc2d43f-10f3-4fb7-8078-d3bdb2a49017" });
        }
    }
}
