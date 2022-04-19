﻿using Models.ModelsIdentity.IdentityAuth;
using System.ComponentModel.DataAnnotations;

namespace BlogSN.Models;

public class Post
{

    public Post()
    {
        DateCreated = DateTime.UtcNow;
    }

    [Key]
    public int Id { get; set; }
    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }

    public DateTime DateCreated { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; }

    public string? ApplicationUserId { get; set; }


}