﻿using BlogSN.Models;
using Microsoft.EntityFrameworkCore;
using Models.ModelsIdentity.IdentityAuth;

namespace BlogSN.Backend.Data;

public class BlogSnDbContext: DbContext
{
    public BlogSnDbContext(DbContextOptions<BlogSnDbContext> options) : base(options)
    {
        
    }
    


    public DbSet<ApplicationUser> AspNetUsers { get; set; }
    
    public DbSet<Post> Post { get; set; }
    
    public DbSet<Category> Category { get; set; }
    
}