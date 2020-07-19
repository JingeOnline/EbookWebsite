using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EbookWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EbookWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private List<TestModel> testModels;
        public TestController()
        {
            testModels = new List<TestModel>()
            {
                new TestModel{Id=0,Name="test0" },
                new TestModel{Id=1,Name="test1" },
                new TestModel{Id=2,Name="test2" },
                new TestModel{Id=3,Name="test3" },
                new TestModel{Id=4,Name="test4" },
            };
        }

        [HttpGet]
        //会自动json序列化
        public IEnumerable<TestModel> Get()
        {
            return testModels;
        }

        [Route("{id}")]
        [HttpGet]
        public TestModel GetTestModel1(int id)
        {
            return testModels.Find(x=>x.Id==id);
        }

        [Route("query")]
        [HttpGet]
        public TestModel GetTestModel2([FromQuery]int id)
        {
            return testModels.Find(x => x.Id == id);
        }
    }
}
