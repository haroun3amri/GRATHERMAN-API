using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GRATHERMAN_WEB_API.Models;


namespace GRATHERMAN_WEB_API.Controllers
{
	[Route("api/info")]
	[ApiController]
	public class CollectedInfomrationController : ControllerBase
    {
        private readonly ICollectedInformationRepository CollectedInformationRepository;

        public CollectedInfomrationController(ICollectedInformationRepository collectedInformationRepository)
        {
            CollectedInformationRepository = collectedInformationRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<CollectedInformation>> List()
        {
            return CollectedInformationRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<CollectedInformation> GetItem(string id)
        {
            CollectedInformation item = CollectedInformationRepository.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<CollectedInformation> Create([FromBody]CollectedInformation item)
        {
            CollectedInformationRepository.Add(item);
            return CreatedAtAction(nameof(GetItem), new { item.Id }, item);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Edit([FromBody] CollectedInformation collectedInformation)
        {
            try
            {
                CollectedInformationRepository.Update(collectedInformation);
            }
            catch (Exception)
            {
                return BadRequest("Error while creating");
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(string id)
        {
            CollectedInformation item = CollectedInformationRepository.Remove(id);

            if (item == null)
                return NotFound();

            return Ok();
        }
    }
}
