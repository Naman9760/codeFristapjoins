namespace codeFristapjoins.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Empoyes",
                c => new
                    {
                        Eid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Mobile = c.String(),
                        Department_id = c.Int(),
                    })
                .PrimaryKey(t => t.Eid)
                .ForeignKey("dbo.Departments", t => t.Department_id)
                .Index(t => t.Department_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empoyes", "Department_id", "dbo.Departments");
            DropIndex("dbo.Empoyes", new[] { "Department_id" });
            DropTable("dbo.Empoyes");
            DropTable("dbo.Departments");
        }
    }
}
