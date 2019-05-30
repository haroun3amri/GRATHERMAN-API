using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRATHERMAN_WEB_API.Models
{
	public interface ITradersStatisticRepository
    {
        void Add(TradersStatistics tradersStatistics);
        void Update(TradersStatistics tradersStatistics);
        TradersStatistics Remove(string key);
        TradersStatistics Get(string id);
        IEnumerable<TradersStatistics> GetAll();
    }
}
