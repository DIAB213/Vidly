namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'730abfad-92ae-4460-9d88-ad99629a87d0', N'admin@vidly.com', 0, N'AA4f6LVQXIO+h5ipxJVlM/WSlBPo7+PdzqSv9cl6Wvf1Xb+AZAD1NOYY9fA+3rCFDQ==', N'f13db747-cb25-46d5-ac34-fdc07cb7153e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f756dbb6-9eff-4fc3-b06b-4c52a06f8acc', N'guest@vidly.com', 0, N'ALy5+m1rrkU3MAYrsd0oQ/zaKU7V6wAgGZ5uHg4eDq8tr3rmlTRns0yATp14RSHIQg==', N'f5ebd939-6af3-4bc8-9091-bd7f7ab83818', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3ac449a2-3a5f-41da-ad14-1849da350adc', N'CanManageMovie')
       
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'730abfad-92ae-4460-9d88-ad99629a87d0', N'3ac449a2-3a5f-41da-ad14-1849da350adc')

");
        }
        
        public override void Down()
        {
        }
    }
}
