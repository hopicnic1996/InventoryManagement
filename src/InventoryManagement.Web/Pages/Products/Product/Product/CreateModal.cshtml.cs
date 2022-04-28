using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Products.Product;
using InventoryManagement.Products.Product.Dtos;
using InventoryManagement.Web.Pages.Products.Product.Product.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using InventoryManagement.Categories.Unit;
using InventoryManagement.Categories.ProductGroup;

namespace InventoryManagement.Web.Pages.Products.Product.Product
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditProductViewModel ViewModel { get; set; }

        public List<SelectListItem> ProductGroupListItems { get; set; }
        public List<SelectListItem> UnitListItems { get; set; }

        public List<SelectListItem> ReferenceUnitListItems { get; set; }

        private readonly IProductAppService _service;
        private readonly IProductGroupAppService _productGroupService;
        private readonly IUnitAppService _unitService;

        public CreateModalModel(IProductAppService service, IUnitAppService unitService, IProductGroupAppService productGroupService)
        {
            _service = service;
            _productGroupService = productGroupService;
            _unitService = unitService;
        }

        public async Task OnGetAsync()
        {
            var unitLookup = await _service.GetProductUnitLookupAsync();
            UnitListItems = unitLookup.Items.Select(x => new SelectListItem(x.UnitName, x.Id.ToString())).ToList();
            ReferenceUnitListItems = unitLookup.Items.Select(x => new SelectListItem(x.UnitName, x.Id.ToString())).ToList();

            var productGroupLookup = await _service.GetProductGroupLookupAsync();
            ProductGroupListItems = productGroupLookup.Items.Select(x => new SelectListItem(x.ProductGroupName, x.Id.ToString())).ToList();
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var productGroupItem = _productGroupService.GetAsync(ViewModel.ProductGroupId);
            ViewModel.ProductGroupName = productGroupItem.Result.productGroupName;
            var unitItem = _unitService.GetAsync(ViewModel.UnitId);
            ViewModel.UnitName = unitItem.Result.UnitName;
            var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}