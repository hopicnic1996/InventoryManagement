using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class GoodsAppService : CrudAppService<Goods, GoodsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGoodsDto, CreateUpdateGoodsDto>,
        IGoodsAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.Goods.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.Goods.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.Goods.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.Goods.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.Goods.Delete;

        private readonly IGoodsRepository _repository;
        
        public GoodsAppService(IGoodsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
