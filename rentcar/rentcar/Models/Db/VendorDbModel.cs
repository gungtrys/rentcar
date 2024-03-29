﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace rentcar.Models.Db
{
	public class VendorDbModel
	{
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        [StringLength(450)]
        public string Id_User { get; set; } = "";

        [StringLength(200)]
        public string Nama { get; set; } = "";

        [StringLength(500)]
        public string? Alamat { get; set; }

        public IdentityUser User { get; set; } = default!;
    }
}