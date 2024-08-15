﻿using System.ComponentModel.DataAnnotations;

namespace CMSExample.DataAccess.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
