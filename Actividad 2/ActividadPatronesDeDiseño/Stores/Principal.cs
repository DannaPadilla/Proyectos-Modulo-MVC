using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadPatronesDeDiseño.Entities;

namespace ActividadPatronesDeDiseño.Stores
{
    internal interface Principal
    {
        public Entity BuildCalzadoGamaAlta(int id, bool Cuero);
        public Entity BuildCalzadoGamaBaja(int id);

    }
}
