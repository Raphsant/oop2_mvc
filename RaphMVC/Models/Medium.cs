using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaphMVC.Models
{
    public class Medium : IMedium
    {
        private string name { get; set; }
        private string genre { get; set; }
        private int year { get; set; }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Genre
        {
            get => genre;
            set => genre = value;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }



        public string About()
        {
            return $"{this.Name} is a {this.Genre} {this} released in {this.Year}";
        }
    }
}
