
namespace INV.Application.Dto.InventoryDto.BasicDto
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

    public class ProductEntityCreateDto 
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int Price { get; set; }
        public int UnitId { get; set; }
        public int OpeningQnty { get; set; }
    }

    public class ProductEntityUpdateDto : BaseEntityDto
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int Price { get; set; }
        public int UnitId { get; set; }
        public int OpeningQnty { get; set; }
    }
    public class ProductEntityDeleteDto 
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }
}
