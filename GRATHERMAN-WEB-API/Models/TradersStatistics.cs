using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GRATHERMAN_WEB_API.Models
{
	public class TradersStatistics
    {
        public string Id { get; set; }

        [Required]
        public int NumberOfTraderIdendified { get; set; }

        [Required]
        public int MaximumGainOfAllTraders { get; set; }

        [Required]
        public int MinimumGainOfAllTraders { get; set; }

        [Required]
        public int MeanGainOfAllTranders { get; set; }

        [Required]
        public int MostGainingTraderId { get; set; }
    }
}
