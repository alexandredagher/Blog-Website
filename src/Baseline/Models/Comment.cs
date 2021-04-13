using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Baseline.Models
{
    public class Comment
    {
        [Key]
        public int CommentId
        {
            get;
            set;
        }
        public int BlogPostId
        {
            get;
            set;
        }
        [ForeignKey("BlogPostId")]
        public BlogPost BlogPost
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
        public string Content
        {
            get;
            set;
        }
        [Required]
        [Range(1, 5)]
        public int Rating
        {
            get;
            set;
        }
    }
}


