namespace HouseU.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course_Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseTitle = c.String(),
                        CourseDescription = c.String(),
                        CreditHours = c.Int(nullable: false),
                        Location = c.String(),
                        Section = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.DateTime(nullable: false),
                        ContactNumber = c.String(),
                        OnCampus = c.Boolean(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course_Student", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Course_Student", "CourseID", "dbo.Courses");
            DropIndex("dbo.Course_Student", new[] { "StudentID" });
            DropIndex("dbo.Course_Student", new[] { "CourseID" });
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.Course_Student");
        }
    }
}
