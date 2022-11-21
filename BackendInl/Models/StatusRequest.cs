using System;
using System.ComponentModel.DataAnnotations;

namespace BackendInl.Models
{
	public class StatusRequest
	{
        [Required]
        public string Status { get; set; }
    }
}

