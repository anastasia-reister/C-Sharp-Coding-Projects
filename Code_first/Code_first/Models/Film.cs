using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_first.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Director Director { get; set; }
        public Genre Genre { get; set; }

    }
}