using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.ProductGroup;
using InventoryManagement.Categories.ProductGroup.Dtos;
using InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditProductGroupViewModel ViewModel { get; set; }

        private readonly IProductGroupAppService _service;

        public CreateModalModel(IProductGroupAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductGroupViewModel, CreateUpdateProductGroupDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}