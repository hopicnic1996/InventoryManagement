using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Warehouse.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Volo.Abp.Users;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Warehouse
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditWarehouseViewModel ViewModel { get; set; }
        public List<SelectListItem> TenantListItems { get; set; }
        public bool checkTenantId { get; set; } = false;

        private readonly IWarehouseAppService _service;
        private readonly ICurrentUser _currentUser;

        public CreateModalModel(IWarehouseAppService service, ICurrentUser currentUser)
        {
            _service = service;
            _currentUser = currentUser;
        }

        public async Task OnGetAsync()
        {
            if(_currentUser.TenantId == null)
            {
                checkTenantId = true;
            }
            var tenantLookup = await _service.GetTenantLookupAsync();
            TenantListItems = tenantLookup.Items.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditWarehouseViewModel, CreateUpdateWarehouseDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}