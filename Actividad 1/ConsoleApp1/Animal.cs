using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal: Entidad
    {
        public string NameAnimal { get; private set; }
        public Animal(string NameAnimal): base (NameAnimal)
        {
            this.NameAnimal = NameAnimal;
        }

    }
}
