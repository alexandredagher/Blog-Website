using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Baseline.Models
{
    public class User
    {
        [Key]
        public int UserId
        {
            get;
            set;
        }

        [ForeignKey("RoleId")]
        public int RoleId
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(1000)]
        public string LastName
        {
            get;
            set;
        }
        [Required]
        [StringLength(1000)]
        public string EmailAddress
        {
            get;
            set;
        }
        [Required]
        [StringLength(1000)]
        public string Password
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        [Required]
        [StringLength(1000)]
        public string City
        {
            get;
            set;
        }
        [Required]
        [StringLength(1000)]
        public string Address
        {
            get;
            set;
        }
        [Required]
        [StringLength(6)]
        public string PostalCode
        {
            get;
            set;
        }
        [Required]
        [StringLength(1000)]
        public string Country
        {
            get;
            set;
        }


    }
}

