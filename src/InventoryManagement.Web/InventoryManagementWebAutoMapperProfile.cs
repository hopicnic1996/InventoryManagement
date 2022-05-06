using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Units.ViewModels;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods.ViewModels;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Goods.ViewModels;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Warehouse.ViewModels;
using AutoMapper;

namespace InventoryManagement.Web;

public class InventoryManagementWebAutoMapperProfile : Profile
{
    public InventoryManagementWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
            CreateMap<UnitsDto, CreateEditUnitsViewModel>();
            CreateMap<CreateEditUnitsViewModel, CreateUpdateUnitsDto>();
            CreateMap<UnitsOfGoodsDto, CreateEditUnitsOfGoodsViewModel>();
            CreateMap<CreateEditUnitsOfGoodsViewModel, CreateUpdateUnitsOfGoodsDto>();
            CreateMap<GoodsDto, CreateEditGoodsViewModel>();
            CreateMap<CreateEditGoodsViewModel, CreateUpdateGoodsDto>();
            CreateMap<WarehouseDto, CreateEditWarehouseViewModel>();
            CreateMap<CreateEditWarehouseViewModel, CreateUpdateWarehouseDto>();
    }
}
