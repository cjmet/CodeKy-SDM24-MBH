namespace SDM24MBH.Data
{
    public class Product : IProduct
    {
        public Int32 Id { get; set; }
        public Boolean isSelected { get; set; } = false;
     
        //public String Department { get; set; } = "";
        //public String Category { get; set; } = "";
        //public String SubCategory { get; set; } = "";
        //public String Section { get; set; } = "";
        //public String SubSection { get; set; } = "";


        public String Brand { get; set; } = "";
        public String Name { get; set; } = "";
        public String Description { get; set; } = "";
        public Decimal Price { get; set; }
        public Int32 Quantity { get; set; }
        
        //public Dictionary<string, string> Specifications { get; set; } = new Dictionary<string, string>();
    }
}