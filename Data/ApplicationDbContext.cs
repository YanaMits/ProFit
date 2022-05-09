using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProFit.Models;
using ProFit.Utility;

namespace ProFit.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = StaticDetail.AdminRole,
                NormalizedName = StaticDetail.AdminRole,
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            var email = "yana.pressa@gmail.com";
            var appUser = new User
            {
                Id = ADMIN_ID,
                Email = email,
                EmailConfirmed = true,
                Name = "Yana_admin",
                Phone = "0765689464",
                UserName = email,
                Role = StaticDetail.AdminRole,
                NormalizedUserName = email.ToUpper()
            };

            //set user password
            PasswordHasher<User> ph = new PasswordHasher<User>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Yana123!");
            //AQAAAAEAACcQAAAAEKFyuBEPhFdOunKemWs6vkzyhznSbmKOfzjVIMWEXAV8xPj8h4on / rfvDQFBd6YizA ==

            //seed user
            builder.Entity<User>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
