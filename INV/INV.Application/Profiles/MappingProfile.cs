using AutoMapper;
using INV.Application.Dto.InventoryDto.BasicDto;
using INV.Domain.Entities.InventoryEntity.BasicEntity;

namespace INV.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region UOM
                CreateMap<UOMEntity, UOMEntityDto>().ReverseMap();
                CreateMap<UOMEntity, UOMEntityCreateDto>().ReverseMap();
                CreateMap<UOMEntity, UOMEntityDeleteDto>().ReverseMap();
                CreateMap<UOMEntity, UOMEntityDeleteDto>().ReverseMap();
            #endregion
        }

    }
}
