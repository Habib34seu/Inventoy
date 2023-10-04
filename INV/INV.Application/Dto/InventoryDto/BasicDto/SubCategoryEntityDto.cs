
namespace INV.Application.Dto.InventoryDto.BasicDto
{
    public class SubCategoryEntityDto : BaseEntityDto
    {
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
    }

    public class SubCategoryEntityCreateDto 
    {
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
    }

    public class SubCategoryEntityUpdateDto : BaseEntityDto
    {
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
    }
    public class SubCategoryEntityDeleteDto 
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }
}
