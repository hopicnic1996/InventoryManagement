using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Units.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Units
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditUnitsViewModel ViewModel { get; set; }

        private readonly IUnitsAppService _service;

        public CreateModalModel(IUnitsAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitsViewModel, CreateUpdateUnitsDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}