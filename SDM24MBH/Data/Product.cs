namespace SDM24MBH.Data
{
    public class Product : IProduct
    {
        public Int32 Id { get; set; }
        public Boolean isSelected { get; set; } = false;
        public String Brand { get; set; } = "";
        public String Name { get; set; } = "";
        public String Description { get; set; } = "";
        public Decimal Price { get; set; }
        public Int32 Quantity { get; set; }
    }
}