﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BackendInl.Models
{
	public class CustomerRequest
	{

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}

