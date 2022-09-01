using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActInterfaces.PartesOutfit
{
    internal abstract  class PartesOutfit
    {


        public string talla { get; protected set; }  //Atributo
        public string color { get; protected set; }  //Atributo


        protected PartesOutfit(string talla, string color)   //Constructor de las partes del outfit
        {
            this.talla = talla;
            this.color = color;
        }



        public void Juntar()   //Metodo de piezas tapas
        {
            Console.WriteLine("Armado del outfit");
    }

        public abstract void ColorTapas();   //Metodo abstracto de partes del outfit
    }
}
