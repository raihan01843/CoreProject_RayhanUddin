﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject_Raihan.Models
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        public long ID { get; set; }

        [Required, Display(Name = "Publisher")]
        public string Name { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}
