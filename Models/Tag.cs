﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KatherinePittsBlog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string BlogUserId { get; set; }
        

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be between {2} and {1} characters long", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Text { get; set; }

        //Navigation Properties
        public virtual Post Post { get; set; }
        public virtual BlogUser BlogUser { get; set; }
       
    }
}
