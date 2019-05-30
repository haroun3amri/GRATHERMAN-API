using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GRATHERMAN_WEB_API.Models
{
	public class Trader
    {
        public string Id { get; set; }

        [Required]
        public string ImageURI { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int DailyGain { get; set; }
    }
}
