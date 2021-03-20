namespace WorkAssistantFV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name_company = c.String(unicode: false),
                        date_created = c.Int(nullable: false),
                        adress_company = c.String(unicode: false),
                        owner_company = c.String(unicode: false),
                        CEO_company = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Company_Users",
                c => new
                    {
                        company_id = c.Int(nullable: false),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.company_id)
                .ForeignKey("dbo.Company", t => t.company_id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.company_id)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        first_name = c.String(unicode: false),
                        last_name = c.String(unicode: false),
                        username = c.String(unicode: false),
                        email = c.String(unicode: false),
                        password = c.String(unicode: false),
                        phone_number_contact = c.String(unicode: false),
                        company_name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Overtime",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        short_description = c.String(unicode: false),
                        start_time = c.String(unicode: false),
                        end_time = c.String(unicode: false),
                        overtime_date = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.User_Tasks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        task_title = c.String(unicode: false),
                        task_description = c.String(unicode: false),
                        task_time = c.String(unicode: false),
                        task_date = c.String(unicode: false),
                        percentage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Tasks", "user_id", "dbo.Users");
            DropForeignKey("dbo.Overtime", "user_id", "dbo.Users");
            DropForeignKey("dbo.Company_Users", "user_id", "dbo.Users");
            DropForeignKey("dbo.Company_Users", "company_id", "dbo.Company");
            DropIndex("dbo.User_Tasks", new[] { "user_id" });
            DropIndex("dbo.Overtime", new[] { "user_id" });
            DropIndex("dbo.Company_Users", new[] { "user_id" });
            DropIndex("dbo.Company_Users", new[] { "company_id" });
            DropTable("dbo.User_Tasks");
            DropTable("dbo.Overtime");
            DropTable("dbo.Users");
            DropTable("dbo.Company_Users");
            DropTable("dbo.Company");
        }
    }
}
