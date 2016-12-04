using Shop1.Common.ViewModels;
using Shop1.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop1.Service
{
    public interface IStatisticService
    {
        IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate);
    }
    public class StatistictService: IStatisticService
    {
        IOrderRepository _oderRepository;
        public StatistictService(IOrderRepository orderRepository)
        {
            this._oderRepository = orderRepository;
        }

        public IEnumerable<RevenueStatisticViewModel> GetRevenueStatistic(string fromDate, string toDate)
        {
            return _oderRepository.GetRevenueStatistic(fromDate, toDate);
        }
    }
}
