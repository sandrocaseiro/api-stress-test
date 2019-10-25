using Microsoft.AspNetCore.Mvc;
using PerfTest.Domain;
using PerfTest.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PerfTest.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly MockDataService _mockDataService;

        public TestController(MockDataService mockDataService)
        {
            _mockDataService = mockDataService;
        }

        [HttpGet("/test/{idSearch:int}")]
        public Task<List<MockData>> FindAllByIdSearchAsync(int idSearch)
        {
            return _mockDataService.FindAllByIdSearchAsync(idSearch);
        }

        [HttpGet("/test-dapper/{idSearch:int}")]
        public Task<IEnumerable<MockData>> FindAllByIdSearchDapperAsync(int idSearch)
        {
            return _mockDataService.FindAllByIdSearchAsyncDapper(idSearch);
        }
    }
}