using Microsoft.AspNetCore.Mvc;
using NumberUtils;

namespace SparkfishWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class listify : ControllerBase
    {
        [HttpGet(Name = "listify")]
        public ActionResult<int> Get(int begin,int end, int index)
        {
            var list = new Listify(begin,end);
            try
            {
                return (int)list[index];
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}