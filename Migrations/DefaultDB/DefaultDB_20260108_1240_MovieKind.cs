using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20260108_124000)]
    public class DefaultDB_20260108_1240_MovieKind : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Movie")
           .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
        } 
    }
}