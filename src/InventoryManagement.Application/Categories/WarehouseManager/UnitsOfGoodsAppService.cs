using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsOfGoodsAppService : CrudAppService<UnitsOfGoods, UnitsOfGoodsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitsOfGoodsDto, CreateUpdateUnitsOfGoodsDto>,
        IUnitsOfGoodsAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.UnitsOfGoods.Delete;

        private readonly IUnitsOfGoodsRepository _repository;
        
        public UnitsOfGoodsAppService(IUnitsOfGoodsRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<bool> CheckUnitOfGoodsExist(Guid unitId, Guid goodsId)
        {
            IQueryable<UnitsOfGoods> unitOfGoodsQueryAble = await _repository.GetQueryableAsync();
            var query = unitOfGoodsQueryAble.Where(x => x.UnitId == unitId && x.GoodsId == goodsId).ToList();
            if(query.Count > 0)
            {
                return true;
            }

            return false;
        }

        public async Task DeleteNotInListAsync(string StrUnitId, Guid goodsId)
        {
            IQueryable<UnitsOfGoods> unitOfGoodsQueryAble = await _repository.GetQueryableAsync();
            if (StrUnitId.IsNullOrWhiteSpace()) StrUnitId = "";
            var query = unitOfGoodsQueryAble.Where(x => !StrUnitId.Contains(x.UnitId.ToString()) && x.GoodsId == goodsId).ToList();
            if(query.Count > 1)
            {
                List<Guid> ListId = new List<Guid>();
                foreach (var item in query)
                {
                    ListId.Add(item.Id);
                }
                await _repository.DeleteManyAsync(ListId);
            }
            else
            {
                foreach (var item in query)
                {
                    await _repository.DeleteAsync(item.Id);
                }
            }
        }
    }
}
