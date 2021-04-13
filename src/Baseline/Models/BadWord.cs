using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Baseline.Models
{
    public class BadWord
    {
        [Key]
        public int BadWordId
        {
            get;
            set;
        }

        [StringLength(1000)]
        public string Word
        {
            get;
            set;
        }
    }
}
