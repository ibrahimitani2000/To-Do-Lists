using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_List.Models
{
    public class Task
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
