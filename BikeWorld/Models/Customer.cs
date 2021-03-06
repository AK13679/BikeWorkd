﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BikeWorld.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        
        [Min18years]
        [Display(Name = "Date of Birth")]
        public DateTime? Dob { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mobile No.")]
        public string mobno { get; set; }
    }
}