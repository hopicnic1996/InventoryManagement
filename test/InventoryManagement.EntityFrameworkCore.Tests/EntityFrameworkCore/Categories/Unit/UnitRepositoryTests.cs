using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.Unit;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Categories.Unit
{
    public class UnitRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IUnitRepository _unitRepository;

        public UnitRepositoryTests()
        {
            _unitRepository = GetRequiredService<IUnitRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
