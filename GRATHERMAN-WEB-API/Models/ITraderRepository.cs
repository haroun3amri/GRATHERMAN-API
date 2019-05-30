using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRATHERMAN_WEB_API.Models
{
	public interface ITraderRepository
    {
        void Add(Trader trader);
        void Update(Trader trader);
        Trader Remove(string key);
        Trader Get(string id);
        IEnumerable<Trader> GetAll();
    }
}
