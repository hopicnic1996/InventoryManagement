using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsOfGoodsAppService : CrudAppService<UnitsOfGoods, UnitsOfGoodsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitsOfGoodsDto, CreateUpdateUnitsOfGoodsDto>,
        IUnitsOfGoodsAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Delete;

        private readonly IUnitsOfGoodsRepository _repository;
        
        public UnitsOfGoodsAppService(IUnitsOfGoodsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
