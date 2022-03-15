using Microsoft.EntityFrameworkCore;
using SocialMediaManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaManagement.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemAction> MenuItemActions { get; set; }
    }
}