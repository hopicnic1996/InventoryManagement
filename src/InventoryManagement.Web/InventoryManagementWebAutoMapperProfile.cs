using InventoryManagement.Categories.ProductGroup.Dtos;
using InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup.ViewModels;
using InventoryManagement.Categories.Unit.Dtos;
using InventoryManagement.Web.Pages.Categories.Unit.Unit.ViewModels;
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
    }
}
