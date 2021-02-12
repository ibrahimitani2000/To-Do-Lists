using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_List.ViewModel
{
    public class AlterTaskViewModel
    {
        public int Id { get; set; }
        [Required,MaxLength(10)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }

    }
}
