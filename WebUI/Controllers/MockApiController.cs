using Application.ProductRichData.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class MockApiController : ApiControllerBase
    {
        [HttpPost("/api/hcproducts/rich/{token}")]
        public async Task<ActionResult<int>> ProductRichData(GetProductRichDataQuery command ,[FromQuery] string token)
        {
            var query = new GetProductRichDataQuery();
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
