using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Baseline.Models
{
    public class Role
    {
        [Key]
        public int RoleId
        {
            get;
            set;
        }

        [Required]
        [StringLength(100)]
        public string Name
        {
            get;
            set;

        }
    }
}
