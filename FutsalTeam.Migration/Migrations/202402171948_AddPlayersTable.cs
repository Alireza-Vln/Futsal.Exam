using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Migrations.Migrations
{
    [Migration(202402171948)]
    public class _202402171948_AddPlayersTable : Migration
    {
        public override void Up()
        {

            Create.Table("Players")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity().PrimaryKey()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Age").AsDateTime().NotNullable()
                .WithColumn("TeamId").AsInt32().ForeignKey();
        }
        public override void Down()
        {
            Delete.Table("Players");
        }

      
    }
}
