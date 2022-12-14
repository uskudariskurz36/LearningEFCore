﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningEFCore.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string? FullName { get; set; }
        public string? Username { get; set; }

        // Navigation property
        public List<BlogPost> BlogPosts { get; set; }
    }
}
