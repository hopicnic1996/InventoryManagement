using InventoryManagement.Categories.ProductGroup;
using InventoryManagement.Categories.ProductGroup.Dtos;
using AutoMapper;

namespace InventoryManagement;

public class InventoryManagementApplicationAutoMapperProfile : Profile
{
    public InventoryManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
            CreateMap<ProductGroup, ProductGroupDto>();
            CreateMap<CreateUpdateProductGroupDto, ProductGroup>(MemberList.Source);
    }
}
