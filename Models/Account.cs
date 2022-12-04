using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL4_project.Models
{
    public class Account
    {
        [Remote("CheckAccountNumber", "Home")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, long.MaxValue, ErrorMessage = "Account number cannot be negative or zero")]

        public int AccountNumber { get; set; }

        [StringLength(byte.MaxValue, MinimumLength = 2, ErrorMessage = "Minimum length must be 2")]
        [Required(ErrorMessage = "Name must be specified")]
        public string Name { get; set; }

        [Range(500, long.MaxValue, ErrorMessage = "Match Points must be specified")]
        public double Points{ get; set; }
     

    }
}