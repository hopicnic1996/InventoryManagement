using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditUnitsOfGoodsViewModel ViewModel { get; set; }

        private readonly IUnitsOfGoodsAppService _service;

        public CreateModalModel(IUnitsOfGoodsAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitsOfGoodsViewModel, CreateUpdateUnitsOfGoodsDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}