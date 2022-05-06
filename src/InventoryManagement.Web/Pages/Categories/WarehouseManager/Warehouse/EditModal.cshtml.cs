using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Warehouse.ViewModels;
using Volo.Abp.Users;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Warehouse
{
    public class EditModalModel : InventoryManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditWarehouseViewModel ViewModel { get; set; }
        public List<SelectListItem> TenantListItems { get; set; }

        public bool checkTenantId { get; set; } = false;

        private readonly IWarehouseAppService _service;
        private readonly ICurrentUser _currentUser;

        public EditModalModel(IWarehouseAppService service, ICurrentUser currentUser)
        {
            _service = service;
            _currentUser = currentUser;
        }

        public virtual async Task OnGetAsync()
        {
            if (_currentUser.TenantId == null)
            {
                checkTenantId = true;
            }
            //var dto = await _service.GetAsync(Id);
            var dto = await _service.GetByIdAsync(Id);
            ViewModel = ObjectMapper.Map<WarehouseDto, CreateEditWarehouseViewModel>(dto);
            var tenantLookup = await _service.GetTenantLookupAsync();
            TenantListItems = tenantLookup.Items.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseViewModel, CreateUpdateWarehouseDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}