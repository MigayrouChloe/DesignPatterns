using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrairieAbstractFactory.Models;

namespace AbstractFactory.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            catalogue.LoadCatalogue();
        }
    }
}
