using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.Unit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.Unit
{
    public class UnitAppService : CrudAppService<Unit, UnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitDto, CreateUpdateUnitDto>,
        IUnitAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.Unit.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.Unit.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.Unit.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.Unit.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.Unit.Delete;

        private readonly IUnitRepository _repository;
        
        public UnitAppService(IUnitRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
