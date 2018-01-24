
using Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common.Services
{
    public class ContractTestsMenuService : IMenuService
    {

        public async Task<MenuItem> GetMenuItemAsync(long id)
        {
            MenuItem menuItem = new MenuItem
            {
                Id = 1,
                Name = "Foo",
                Price = 10.0f

            };
            return await Task.FromResult<MenuItem>(menuItem);

        }

        public async Task<List<MenuItem>> GetMenuItemsAsync()
        {
            MenuItem menuItem1 = new MenuItem
            {
                Id = 1,
                Name = "Foo",
                Price = 10.0f

            };
            MenuItem menuItem2 = new MenuItem
            {
                Id = 2,
                Name = "Bar",
                Price = 20.0f

            };
            return await Task.FromResult<List<MenuItem>>(new List<MenuItem>(new MenuItem[] { menuItem1, menuItem2 }));
        }

        public async Task SaveMenuItemAsync(MenuItem item, bool newOne = false)
        {
            await Task.Factory.StartNew(() => "");
        }

        public async Task DeleteMenuItemAsync(long id)
        {
            await Task.Factory.StartNew(() => "");
        }
    }
}
