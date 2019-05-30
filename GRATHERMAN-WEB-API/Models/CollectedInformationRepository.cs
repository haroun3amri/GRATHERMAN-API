using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace GRATHERMAN_WEB_API.Models
{
	public class CollectedInformationRepository: ICollectedInformationRepository
    {
        private static ConcurrentDictionary<string, CollectedInformation> collectedInformations =
          new ConcurrentDictionary<string, CollectedInformation>();

        public CollectedInformationRepository()
        {
            Add(new CollectedInformation { Id = Guid.NewGuid().ToString(), FirstName = "Samir", LastName= "Wafi" , PhoneNumber = "77304512", Email1 = "User1Mail@hotmail.fr" , Email2= "User1Mail2@hotmail.fr", Turnover = 84848484, NumberOfWorkedDaysPerWeeks = 5 , NumberOfFreeDayPerYear = 25 });
            Add(new CollectedInformation { Id = Guid.NewGuid().ToString(), FirstName = "Bruno", LastName = "Mars", PhoneNumber = "77304512", Email1 = "User1Mail@hotmail.fr", Email2 = "User1Mail2@hotmail.fr", Turnover = 84848484, NumberOfWorkedDaysPerWeeks = 5, NumberOfFreeDayPerYear = 25 });
            Add(new CollectedInformation { Id = Guid.NewGuid().ToString(), FirstName = "Will", LastName = "Smith", PhoneNumber = "77304512", Email1 = "User1Mail@hotmail.fr", Email2 = "User1Mail2@hotmail.fr", Turnover = 84848484, NumberOfWorkedDaysPerWeeks = 5, NumberOfFreeDayPerYear = 25 });
        }

        public IEnumerable<CollectedInformation> GetAll()
        {
            return collectedInformations.Values;
        }

        public void Add(CollectedInformation collectedInformation)
        {
            collectedInformation.Id = Guid.NewGuid().ToString();
            collectedInformations[collectedInformation.Id] = collectedInformation;
        }

        public CollectedInformation Get(string id)
        {
            CollectedInformation collectedInformation;
            collectedInformations.TryGetValue(id, out collectedInformation);

            return collectedInformation;
        }

        public CollectedInformation Remove(string id)
        {
            CollectedInformation collectedInformation;
            collectedInformations.TryRemove(id, out collectedInformation);

            return collectedInformation;
        }

        public void Update(CollectedInformation collectedInformation)
        {
            collectedInformations[collectedInformation.Id] = collectedInformation;
        }

    }
}
