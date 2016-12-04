using Shop1.Service;
using Shop1.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shop1.Web.Api
{
    [RoutePrefix("api/statistic")]
    public class StatisticController : ApiControllerBase
    {
        IStatisticService _statisticService;
        public StatisticController(IStatisticService statisticService, IErrorService errorService):base(errorService)
        {
            _statisticService = statisticService;
        }
        [Route("getrevenue")]
        [HttpGet]
        public HttpResponseMessage GetRevenueStatistic(HttpRequestMessage request,string fromDate,string toDate)
        {
            return CreateHttpResponse(request, () =>
            {
                var model = _statisticService.GetRevenueStatistic(fromDate, toDate);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, model);
                return response;
            });
        }
    }
}
