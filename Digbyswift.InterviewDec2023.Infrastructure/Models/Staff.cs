using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digbyswift.InterviewDec2023.Infrastructure.Models
{    public class Staff
    {
        [Key]
        public int Id { get; set; }
        [Required,Range(1,100)]
        public string FullName { get; set; }
        [Required, Range(1, 100)]
        public string Email { get; set; }
        [Required, Range(1, 100)]
        public string JobTitle { get; set; }
        [Required]
        public string[] Likes { get; set; }
    }
}
