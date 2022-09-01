using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesDeDiseño.Entities
{
    internal class CalzadoGamaAlta : Entity
    {

        public  bool Cuero { get; private set; }
        public CalzadoGamaAlta(int id, bool Cuero) : base(id)
        {
            this.Cuero = Cuero;
        }
    }
}
