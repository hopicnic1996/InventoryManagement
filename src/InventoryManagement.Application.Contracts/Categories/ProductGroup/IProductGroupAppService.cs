using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.ProductGroup.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.ProductGroup
{
    //public interface IProductGroupAppService :
    //    ICrudAppService< 
    //        ProductGroupDto, 
    //        Guid, 
    //        PagedAndSortedResultRequestDto,
    //        CreateUpdateProductGroupDto,
    //        CreateUpdateProductGroupDto>
    //{

    //}
    public interface IProductGroupAppService : IApplicationService
    {
        Task<ProductGroupDto> GetAsync(Guid id);

        Task<PagedResultDto<ProductGroupDto>> GetListAsync(GetListProductGroupDto input);

        Task<ProductGroupDto> CreateAsync(CreateUpdateProductGroupDto input);

        Task UpdateAsync(Guid id, CreateUpdateProductGroupDto input);

        Task DeleteAsync(Guid id);
    }
}