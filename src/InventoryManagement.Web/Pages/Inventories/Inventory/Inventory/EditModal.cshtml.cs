using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Inventories.Inventory;
using InventoryManagement.Inventories.Inventory.Dtos;
using InventoryManagement.Web.Pages.Inventories.Inventory.Inventory.ViewModels;

namespace InventoryManagement.Web.Pages.Inventories.Inventory.Inventory
{
    public class EditModalModel : InventoryManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditInventoryViewModel ViewModel { get; set; }

        private readonly IInventoryAppService _service;

        public EditModalModel(IInventoryAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<InventoryDto, CreateEditInventoryViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditInventoryViewModel, CreateUpdateInventoryDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}