namespace Inventory.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; }

        public string Category { get; set; }

        public string Manufacturer { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public int Quantity { get; set; }
    }
}