﻿using System.ComponentModel.DataAnnotations;

namespace ApiHollowKnight.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
