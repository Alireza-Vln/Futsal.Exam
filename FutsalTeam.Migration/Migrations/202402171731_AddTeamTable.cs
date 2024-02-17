using FluentMigrator;


namespace FutsalTeam.Migrations.Migrations
{
    [Migration(202402171731)]
    public class _202402171731_AddTeamTable : Migration
    {
        public override void Up()
        {
            Create.Table("Teams")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("TeamName").AsString(50).NotNullable()
                .WithColumn("MainColor").AsInt32().NotNullable()
                .WithColumn("SecondaryColor").AsInt32().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Teams");
        }

      
    }
}
