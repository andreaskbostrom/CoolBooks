﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoolBooks.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Books = new HashSet<Books>();
        }

        [Key]
        public int GenerID { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [InverseProperty("Gener")]
        public virtual ICollection<Books> Books { get; set; }
    }
}