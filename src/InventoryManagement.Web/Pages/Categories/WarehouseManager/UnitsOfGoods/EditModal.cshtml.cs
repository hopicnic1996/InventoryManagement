using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods
{
    public class EditModalModel : InventoryManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditUnitsOfGoodsViewModel ViewModel { get; set; }

        private readonly IUnitsOfGoodsAppService _service;

        public EditModalModel(IUnitsOfGoodsAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<UnitsOfGoodsDto, CreateEditUnitsOfGoodsViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitsOfGoodsViewModel, CreateUpdateUnitsOfGoodsDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}