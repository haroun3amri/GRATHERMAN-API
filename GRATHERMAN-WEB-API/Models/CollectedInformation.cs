using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GRATHERMAN_WEB_API.Models
{

	public class CollectedInformation
    {
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email1 { get; set; }

        [Required]
        public string Email2 { get; set; }

        [Required]
        public int Turnover { get; set; }

        [Required]
        public int NumberOfWorkedDaysPerWeeks { get; set; }

        [Required]
        public int NumberOfFreeDayPerYear { get; set; }
    }
}
