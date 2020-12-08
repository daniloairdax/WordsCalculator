namespace WordsCalculatorApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TextModelDTOes", "WordsCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TextModelDTOes", "WordsCount", c => c.Int(nullable: false));
        }
    }
}
