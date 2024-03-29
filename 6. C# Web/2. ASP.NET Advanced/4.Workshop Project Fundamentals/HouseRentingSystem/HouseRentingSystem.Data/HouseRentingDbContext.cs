﻿#nullable disable

using HouseRentingSystem.Data.Configurations;
using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HouseRentingSystem.Data
{
	public class HouseRentingDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{
		public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
			: base(options)
		{
		}

		public DbSet<Agent> Agents { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<House> Houses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
			Assembly configAssembly = Assembly.GetAssembly(typeof(HouseEntityConfigurations)) ?? 
								Assembly.GetExecutingAssembly();
			builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}
