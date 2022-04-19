using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Categories.Unit;
using InventoryManagement.Categories.Unit.Dtos;
using InventoryManagement.Web.Pages.Categories.Unit.Unit.ViewModels;

namespace InventoryManagement.Web.Pages.Categories.Unit.Unit
{
    public class EditModalModel : InventoryManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditUnitViewModel ViewModel { get; set; }

        private readonly IUnitAppService _service;

        public EditModalModel(IUnitAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<UnitDto, CreateEditUnitViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditUnitViewModel, CreateUpdateUnitDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}