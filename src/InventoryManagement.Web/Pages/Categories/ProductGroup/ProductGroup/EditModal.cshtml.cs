using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.ProductGroup;
using InventoryManagement.Categories.ProductGroup.Dtos;
using InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup
{
    public class EditModalModel : InventoryManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditProductGroupViewModel ViewModel { get; set; }

        private readonly IProductGroupAppService _service;

        public EditModalModel(IProductGroupAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ProductGroupDto, CreateEditProductGroupViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductGroupViewModel, CreateUpdateProductGroupDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}