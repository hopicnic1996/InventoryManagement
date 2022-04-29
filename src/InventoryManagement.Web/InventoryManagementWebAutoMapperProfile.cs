using InventoryManagement.Categories.ProductGroup.Dtos;
using InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup.ViewModels;
using InventoryManagement.Categories.Unit.Dtos;
using InventoryManagement.Web.Pages.Categories.Unit.Unit.ViewModels;
using InventoryManagement.Products.Product.Dtos;
using InventoryManagement.Web.Pages.Products.Product.Product.ViewModels;
using InventoryManagement.Inventories.Inventory.Dtos;
using InventoryManagement.Web.Pages.Inventories.Inventory.Inventory.ViewModels;
using AutoMapper;

namespace InventoryManagement.Web;

public class InventoryManagementWebAutoMapperProfile : Profile
{
    public InventoryManagementWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
            CreateMap<ProductGroupDto, CreateEditProductGroupViewModel>();
            CreateMap<CreateEditProductGroupViewModel, CreateUpdateProductGroupDto>();
            CreateMap<UnitDto, CreateEditUnitViewModel>();
            CreateMap<CreateEditUnitViewModel, CreateUpdateUnitDto>();
            CreateMap<ProductDto, CreateEditProductViewModel>();
            CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();
            CreateMap<InventoryDto, CreateEditInventoryViewModel>();
            CreateMap<CreateEditInventoryViewModel, CreateUpdateInventoryDto>();
    }
}
