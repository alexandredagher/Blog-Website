using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Baseline.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostId
        {
            get;
            set;
        }
        public int UserId
        {
            get;
            set;
        }
        [ForeignKey("UserId")]
        public User User
        {
            get;
            set;
        }


        [Required]
        [StringLength(1000)]
        public string Title
        {
            get;
            set;
        }
        [Required]
        [StringLength(2000)]
        public string ShortDescription
        {
            get;
            set;
        }

        [Required]
        [StringLength(5000)]
        public string Content
        {
            get;
            set;
        }
        [DataType(DataType.Date)]
        public DateTime Posted
        {
            get;
            set;
        }
        [Required]
        public bool IsAvailable
        {
            get;
            set;
        }

    }
}

