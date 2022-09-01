using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfaces.Accesorios
{
    internal class Bufanda : IAccesorios
    {
        public void Agregar()
        {
            Console.WriteLine("Se incluye bufanda");
        }
    }
}
