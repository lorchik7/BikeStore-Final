﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TheStoreFinal.Models

{
    [Table("stores", Schema = "sales")]
    public class Store
    {
        [Key]
        [Column("store_id", TypeName = "int")]
        public int Id { get; set; } = 0;

        [Required]
        //[MaxLength(40)]
        [Column("store_name", TypeName = "varchar")]
        public string StoreName { get; set; }

        [Column("city", TypeName = "varchar")]
        public string City { get; set; }
    }
}
