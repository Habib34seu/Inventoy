
namespace INV.Application.Dto.InventoryDto.BasicDto
{
    public class CategoryEntityDto : BaseEntityDto
    {
        public string CategoryName { get; set; }
    }

    public class CategoryEntityCreateDto 
    {
        public string CategoryName { get; set; }
    }

    public class CategoryEntityUpdateDto : BaseEntityDto
    {
        public string CategoryName { get; set; }
    }

    public class CategoryEntityDeleteDto 
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }

}
