using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.Unit;
using InventoryManagement.Categories.Unit.Dtos;
using InventoryManagement.Web.Pages.Categories.Unit.Unit.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.Unit.Unit
{
    public class CreateModalModel : InventoryManagementPageModel
    {
        [BindProperty]
        public CreateEditUnitViewModel ViewModel { get; set; }

        private readonly IUnitAppService _service;

        public CreateModalModel(IUnitAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitViewModel, CreateUpdateUnitDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}