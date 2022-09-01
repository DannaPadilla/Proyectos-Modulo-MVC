using ActividadPatronesDeDiseño.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPatronesDeDiseño.Stores
{
    internal class Secundaria : Principal

    {
        public Entity BuildCalzadoGamaAlta(int id, bool Cuero)
        {
            return new CalzadoGamaAlta(id, Cuero);
        }

        public Entity BuildCalzadoGamaBaja(int id)
        {
            return new CalzadoGamaBaja(id);
        }
    }
}
