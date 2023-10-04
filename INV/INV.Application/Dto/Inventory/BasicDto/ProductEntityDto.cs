
namespace INV.Application.Dto.Inventory.BasicDto
{
    public class ProductEntityDto :BaseEntityDto
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int Price { get; set; }
        public int UnitId { get; set; }
        public int OpeningQnty { get; set; }
    }
}
