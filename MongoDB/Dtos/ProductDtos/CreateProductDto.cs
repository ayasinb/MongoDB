namespace MongoDB.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
