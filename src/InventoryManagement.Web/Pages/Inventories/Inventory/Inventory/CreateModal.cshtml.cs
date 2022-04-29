using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Inventories.Inventory;
using InventoryManagement.Inventories.Inventory.Dtos;
using InventoryManagement.Web.Pages.Inventories.Inventory.Inventory.ViewModels;

namespace InventoryManagement.Web.Pages.Inventories.Inventory.Inventory
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditInventoryViewModel ViewModel { get; set; }

        private readonly IInventoryAppService _service;

        public CreateModalModel(IInventoryAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditInventoryViewModel, CreateUpdateInventoryDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}