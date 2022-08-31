using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Entidad
    {
        public string Name { get; set; }

        protected Entidad (string name)
        {
            this.Name = name;
        }
    }
}
