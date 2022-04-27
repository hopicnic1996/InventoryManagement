using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Products.Product;
using InventoryManagement.Products.Product.Dtos;
using InventoryManagement.Web.Pages.Products.Product.Product.ViewModels;

namespace InventoryManagement.Web.Pages.Products.Product.Product
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditProductViewModel ViewModel { get; set; }

        private readonly IProductAppService _service;

        public CreateModalModel(IProductAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}