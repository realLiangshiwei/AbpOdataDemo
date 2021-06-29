using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Qc.Pages
{
    public class Index_Tests : QcWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
