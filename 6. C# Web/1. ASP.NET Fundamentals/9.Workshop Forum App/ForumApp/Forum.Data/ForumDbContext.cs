﻿using Forum.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using static Forum.Common.Validations.ValidationsConstants;

namespace Forum.Data;

public class ForumDbContext : DbContext
{
	public ForumDbContext(DbContextOptions<ForumDbContext> options)
		: base(options)
	{
	}

	public DbSet<Post> Posts { get; set; } = null!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new PostEntityConfiguration());

		base.OnModelCreating(modelBuilder);
	}
}
