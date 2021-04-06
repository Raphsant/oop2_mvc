using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaphMVC.Models
{
    public interface IMedium
    {
        string Name { get; set; }
        string Genre { get; set; }
        int Year { get; set; }


        string About();
        
    }
}
