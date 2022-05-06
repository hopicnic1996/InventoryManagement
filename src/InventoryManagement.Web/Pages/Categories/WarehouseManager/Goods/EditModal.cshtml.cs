using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.WarehouseManager;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.Goods.ViewModels;
using InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Goods
{
    public class EditModalModel : InventoryManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditGoodsViewModel ViewModel { get; set; }

        private readonly IGoodsAppService _service;
        private readonly IUnitsAppService _unitsService;
        private readonly IUnitsOfGoodsAppService _unitsOfGoodsService;

        public EditModalModel(IGoodsAppService service, IUnitsAppService unitsService, IUnitsOfGoodsAppService unitsOfGoodsService)
        {
            _service = service;
            _unitsService = unitsService;
            _unitsOfGoodsService = unitsOfGoodsService;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<GoodsDto, CreateEditGoodsViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditGoodsViewModel, CreateUpdateGoodsDto>(ViewModel);
            var goodsVal = await _service.UpdateAsync(Id, dto);

            await _unitsOfGoodsService.DeleteNotInListAsync(ViewModel.UnitOfGood, goodsVal.Id);

            if(!ViewModel.UnitOfGood.IsNullOrWhiteSpace())
            {
                var unitsId = ViewModel.UnitOfGood.Split(",");

                foreach (var item in unitsId)
                {
                    if (!item.IsNullOrWhiteSpace())
                    {
                        if (!_unitsOfGoodsService.CheckUnitOfGoodsExist(Guid.Parse(item), goodsVal.Id).Result)
                        {
                            var unitVal = await _unitsService.GetAsync(Guid.Parse(item));
                            CreateEditUnitsOfGoodsViewModel createEditUnitsOfGoodsViewModel = new CreateEditUnitsOfGoodsViewModel();
                            createEditUnitsOfGoodsViewModel.UnitId = unitVal.Id;
                            createEditUnitsOfGoodsViewModel.UnitName = unitVal.Name;
                            createEditUnitsOfGoodsViewModel.GoodsId = goodsVal.Id;
                            var unitOfGoodsDto = ObjectMapper.Map<CreateEditUnitsOfGoodsViewModel, CreateUpdateUnitsOfGoodsDto>(createEditUnitsOfGoodsViewModel);
                            await _unitsOfGoodsService.CreateAsync(unitOfGoodsDto);
                        }
                    }
                }
            }
            return NoContent();
        }
    }
}