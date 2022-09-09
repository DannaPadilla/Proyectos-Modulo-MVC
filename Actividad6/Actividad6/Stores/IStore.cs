using Actividad6.Entities;

namespace Actividad6.Stores
{
    internal interface IStore<T> where T : Entity
    {
        public void Register(T obj);
    }
}