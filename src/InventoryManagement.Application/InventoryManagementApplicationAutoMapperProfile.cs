using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using AutoMapper;

namespace InventoryManagement;

public class InventoryManagementApplicationAutoMapperProfile : Profile
{
    public InventoryManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
            CreateMap<Units, UnitsDto>();
            CreateMap<CreateUpdateUnitsDto, Units>(MemberList.Source);
            CreateMap<UnitsOfGoods, UnitsOfGoodsDto>();
            CreateMap<CreateUpdateUnitsOfGoodsDto, UnitsOfGoods>(MemberList.Source);
            CreateMap<Goods, GoodsDto>();
            CreateMap<CreateUpdateGoodsDto, Goods>(MemberList.Source);

        CreateMap<Units, LookUpDto>(MemberList.Source);
    }
}
