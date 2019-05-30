using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace GRATHERMAN_WEB_API.Models
{
	public class TradeStatisticRepository: ITradersStatisticRepository
    {
        private static ConcurrentDictionary<string, TradersStatistics> items =
          new ConcurrentDictionary<string, TradersStatistics>();

        public TradeStatisticRepository()
        {
            Add(new TradersStatistics { Id = Guid.NewGuid().ToString(), MaximumGainOfAllTraders = 77, MeanGainOfAllTranders = 787874, MinimumGainOfAllTraders = 348488, MostGainingTraderId = 1, NumberOfTraderIdendified = 69 });
            Add(new TradersStatistics { Id = Guid.NewGuid().ToString(), MaximumGainOfAllTraders = 88, MeanGainOfAllTranders = 787874, MinimumGainOfAllTraders = 348488, MostGainingTraderId = 1, NumberOfTraderIdendified = 69 });
            Add(new TradersStatistics { Id = Guid.NewGuid().ToString(), MaximumGainOfAllTraders = 98, MeanGainOfAllTranders = 787874, MinimumGainOfAllTraders = 348488, MostGainingTraderId = 1, NumberOfTraderIdendified = 69 });
        }

        public IEnumerable<TradersStatistics> GetAll()
        {
            return items.Values;
        }

        public void Add(TradersStatistics item)
        {
            item.Id = Guid.NewGuid().ToString();
            items[item.Id] = item;
        }

        public TradersStatistics Get(string id)
        {
            TradersStatistics item;
            items.TryGetValue(id, out item);

            return item;
        }

        public TradersStatistics Remove(string id)
        {
            TradersStatistics item;
            items.TryRemove(id, out item);

            return item;
        }

        public void Update(TradersStatistics item)
        {
            items[item.Id] = item;
        }
    }
}
