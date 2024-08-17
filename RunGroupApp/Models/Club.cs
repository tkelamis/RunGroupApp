﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RunGroupApp.Data.Enum;

namespace RunGroupApp.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public Address? Address { get; set; }
        public ClubCategory ClubCategory { get; set; }
        public AppUser? AppUser { get; set; }

        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }

    }
}
