using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GRATHERMAN_WEB_API.Models;


namespace GRATHERMAN_WEB_API.Controllers
{
	[Route("api/trader")]
    [ApiController]
    public class TraderController : ControllerBase
    {
        private readonly ITraderRepository TraderRepository;

        public TraderController(ITraderRepository traderRepository)
        {
            TraderRepository = traderRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Trader>> List()
        {
            return TraderRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Trader> GetItem(string id)
        {
            Trader item = TraderRepository.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Trader> Create([FromBody]Trader item)
        {
            TraderRepository.Add(item);
            return CreatedAtAction(nameof(GetItem), new { item.Id }, item);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Edit([FromBody] Trader trader)
        {
            try
            {
                TraderRepository.Update(trader);
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
            Trader item = TraderRepository.Remove(id);

            if (item == null)
                return NotFound();

            return Ok();
        }
    }
}
