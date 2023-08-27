using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xela_api_pariss.Migrations
{
    public partial class AdminRol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "AspNetUsers");

            migrationBuilder.Sql(@"
        IF NOT EXISTS(SELECT id from [AspNetRoles] where id='bb79dce0-bfd7-4b46-86f2-9904fd2db72c')
        BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('bb79dce0-bfd7-4b46-86f2-9904fd2db72c','Admin','ADMIN')
        END
        IF NOT EXISTS(SELECT id from [AspNetRoles] where id='0baedfbe-99e7-49b2-ba85-7e52e8198d6d')
        BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('0baedfbe-99e7-49b2-ba85-7e52e8198d6d','Consulta1','CONSULTA1')
        END
        IF NOT EXISTS(SELECT id from [AspNetRoles] where id='e7100a62-a126-4321-95d7-e6f2992de4cc')
        BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('e7100a62-a126-4321-95d7-e6f2992de4cc','Consulta2','CONSULTA2')
        END
        BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('5e7fac69-bc57-4f84-850c-8d83983d3f2f','Adminpariss','ADMINPARISS')
        END

		BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('682a1446-b829-4d36-ba65-27755314d12f','AdminSaludV','ADMINSALUDV')
        END

		BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('ef922f16-d306-4c71-ab61-f1f198718d1b','SaludVconsulta1','SALUDVCONSULTA1')
        END

        BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('a91c5e7d-3ea9-483c-b120-88ad5a763ac8','ConsultaSYC','CONSULTASYC')
        END

        BEGIN
        insert into [dbo].[AspNetRoles](id,[Name],NormalizedName)
        valueS('355bda9d-d768-4516-9b9e-045dbcf7fa79','AdminNomina','ADMINNOMINA')
        END
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.Sql(@"
            delete from [AspNetRoles] where id='bb79dce0-bfd7-4b46-86f2-9904fd2db72c'
            delete  from [AspNetRoles] where id='e7100a62-a126-4321-95d7-e6f2992de4cc'
            delete  from [AspNetRoles] where id='0baedfbe-99e7-49b2-ba85-7e52e8198d6d'
            delete  from [AspNetRoles] where id='5e7fac69-bc57-4f84-850c-8d83983d3f2f'
		    delete  from [AspNetRoles] where id='682a1446-b829-4d36-ba65-27755314d12f'
		    delete  from [AspNetRoles] where id='ef922f16-d306-4c71-ab61-f1f198718d1b'
            delete  from [AspNetRoles] where id='a91c5e7d-3ea9-483c-b120-88ad5a763ac8'
            delete  from [AspNetRoles] where id='355bda9d-d768-4516-9b9e-045dbcf7fa79'
            ");
        }
    }
}
