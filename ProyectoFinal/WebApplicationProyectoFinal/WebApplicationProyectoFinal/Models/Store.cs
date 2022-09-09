namespace WebApplicationProyectoFinal.Models
{
    public class Store: Entity
    {
        public string Name { get; private set; }
        public string Street { get; private set; }
        public List <Product> Products { get; private set; }
        private Store() : base() { }//Para EF
        private Store(Guid id, string name, string street) : base(id)
        {
            Name = name;
            Street = street; 
        }
        public Store Build(Guid id, string name, string street)
        {
            return new Store(id, name, street);
        }
    }
}
