using InventoryManagement.Categories.ProductGroup;
using InventoryManagement.Categories.ProductGroup.Dtos;
using InventoryManagement.Categories.Unit;
using InventoryManagement.Categories.Unit.Dtos;
using InventoryManagement.Products.Product;
using InventoryManagement.Products.Product.Dtos;
using InventoryManagement.Inventories.Inventory;
using InventoryManagement.Inventories.Inventory.Dtos;
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
            CreateMap<Unit, UnitDto>();
            CreateMap<CreateUpdateUnitDto, Unit>(MemberList.Source);
            CreateMap<Product, ProductDto>();
            CreateMap<CreateUpdateProductDto, Product>(MemberList.Source);
            CreateMap<Unit, ProductUnitLookUpDto>(MemberList.Source);
            CreateMap<ProductGroup, ProductGroupLookUpDto>(MemberList.Source);
            CreateMap<Inventory, InventoryDto>();
            CreateMap<CreateUpdateInventoryDto, Inventory>(MemberList.Source);
    }
}
