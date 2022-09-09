namespace WebApplicationProyectoFinal.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        protected Entity() //Para Entity Framework
        {

        }
        public Entity (Guid id)
        {
            Id = id;
        }
    }
}
