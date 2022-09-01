using ActInterfaces.Accesorios;
using ActInterfaces.PiezasTapas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfaces.Outfits
{
    internal class Outfit
    {
        private IAccesorios Accesorio; //Agregacion
        private PiezasTapa TapaLateral; //Composicion



        public Outfit(IAccesorios accesorio)
        {
            Accesorio = accesorio;  //Agregacion
            this.TapaLateral = new TapaLateral("20x35","32"); //Composicion  (Cada vez que se cree una moto automaticamente se crea una nueva pieza)
        }
    }
}
