using Actividad6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Actividad6.Stores;

namespace Actividad6.Stores
{
    internal class Store<T>: IStore <T> where T: Entity
    {
       
            private List<T> Register { get; set; }

            public Store()
            {
                Register = new List<T>();
            }

            public void Registrar(T obj)
            {

                obj.Id = "001";

                Register.Add(obj);
            }

        void IStore<T>.Register(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
