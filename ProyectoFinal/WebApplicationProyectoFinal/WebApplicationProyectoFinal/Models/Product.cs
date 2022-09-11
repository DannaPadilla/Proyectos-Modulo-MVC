namespace WebApplicationProyectoFinal.Models
{
    public class Product: Entity
    {
     

        public string Name { get; private set; }
        public string Presentation { get; private set; }
        public string Material { get; private set; }
        public float Value { get; private set; }
        public Guid StoreId { get; private set; }
        public Store Store { get; private set; }
        private Product (): base() { }
        private Product(Guid id,string name, string presentation, string material, float value, 
            Guid storeId) : base(id)
        {
            Name = name;
            Presentation = presentation;
            Material = material;
            Value = value;
            StoreId = storeId;
        }
        public static Product Build(Guid id, string name, string presentation, string material, float value, Guid storeId)
        {
            return new Product(id, name, presentation, material, value, storeId);
        }
    }
}
