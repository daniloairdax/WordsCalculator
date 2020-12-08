namespace WordsCalculatorApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WordsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TextModelDTOes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(),
                        WordsCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TextModelDTOes");
        }
    }
}
