﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class SocialDbContext : DbContext
{
    public SocialDbContext(DbContextOptions opt) : base(opt)
    {

    }

    public DbSet<Post> Post { get; set; }
}
