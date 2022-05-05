using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Goods.ViewModels;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods.ViewModels;
using System;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Goods
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditGoodsViewModel ViewModel { get; set; }

        private readonly IGoodsAppService _service;
        private readonly IUnitsAppService _unitsService;
        private readonly IUnitsOfGoodsAppService _unitsOfGoodsService;

        public CreateModalModel(IGoodsAppService service, IUnitsAppService unitsService, IUnitsOfGoodsAppService unitsOfGoodsService)
        {
            _service = service;
            _unitsService = unitsService;
            _unitsOfGoodsService = unitsOfGoodsService;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            ViewModel.GoodsCode = "code";
            var dto = ObjectMapper.Map<CreateEditGoodsViewModel, CreateUpdateGoodsDto>(ViewModel);
            var goodsVal = await _service.CreateAsync(dto);
            var unitsId = ViewModel.UnitOfGood.Split(",");
            foreach(var item in unitsId)
            {
                var unitVal = await _unitsService.GetAsync(Guid.Parse(item));
                CreateEditUnitsOfGoodsViewModel createEditUnitsOfGoodsViewModel = new CreateEditUnitsOfGoodsViewModel();
                createEditUnitsOfGoodsViewModel.UnitId = unitVal.Id;
                createEditUnitsOfGoodsViewModel.UnitName = unitVal.Name;
                createEditUnitsOfGoodsViewModel.GoodsId = goodsVal.Id;
                var unitOfGoodsDto = ObjectMapper.Map<CreateEditUnitsOfGoodsViewModel, CreateUpdateUnitsOfGoodsDto>(createEditUnitsOfGoodsViewModel);
                await _unitsOfGoodsService.CreateAsync(unitOfGoodsDto);
            }
            return NoContent();
        }
    }
}