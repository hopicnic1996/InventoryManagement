using System;
using InventoryManagement.Permissions;
using InventoryManagement.Inventories.Inventory.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Inventories.Inventory
{
    public class InventoryAppService : CrudAppService<Inventory, InventoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInventoryDto, CreateUpdateInventoryDto>,
        IInventoryAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.Inventory.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.Inventory.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.Inventory.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.Inventory.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.Inventory.Delete;

        private readonly IInventoryRepository _repository;
        
        public InventoryAppService(IInventoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
