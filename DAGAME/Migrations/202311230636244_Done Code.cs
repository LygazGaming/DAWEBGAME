﻿namespace DAGAME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoneCode : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Product", "OriginalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "OriginalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
