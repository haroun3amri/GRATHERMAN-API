using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRATHERMAN_WEB_API.Models
{
	public interface ICollectedInformationRepository
    {
        void Add(CollectedInformation c);
        void Update(CollectedInformation item);
        CollectedInformation Remove(string key);
        CollectedInformation Get(string id);
        IEnumerable<CollectedInformation> GetAll();
    }
}
