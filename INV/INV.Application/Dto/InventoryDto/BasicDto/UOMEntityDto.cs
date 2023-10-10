

namespace INV.Application.Dto.InventoryDto.BasicDto
{
    public class UOMEntityDto : BaseEntityDto, IUOMEntityDto
    {
        public string UnitName { get; set; }
    }

    public class UOMEntityCreateDto: IUOMEntityDto 
    {
        public string UnitName { get; set; }
    }

    public class UOMEntityUpdateDto : BaseEntityDto, IUOMEntityDto
    {
        public string UnitName { get; set; }
    }

    public class UOMEntityDeleteDto 
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public string DeletedBy { get; set; }
        public string DeletedDate { get; set; }
    }

    public interface IUOMEntityDto
    {
        public string UnitName { get; set; }
    }
}
