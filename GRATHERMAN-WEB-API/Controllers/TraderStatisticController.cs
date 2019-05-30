using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GRATHERMAN_WEB_API.Models;


namespace GRATHERMAN_WEB_API.Controllers
{
	[Route("api/stat")]
    [ApiController]
    public class TraderStatisticController : ControllerBase
    {
        private readonly ITradersStatisticRepository TradersStatisticRepository;

        public TraderStatisticController(ITradersStatisticRepository tradersStatisticRepository)
        {
            TradersStatisticRepository = tradersStatisticRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<TradersStatistics>> List()
        {
            return TradersStatisticRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TradersStatistics> GetItem(string id)
        {
            TradersStatistics item = TradersStatisticRepository.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TradersStatistics> Create([FromBody]TradersStatistics item)
        {
            TradersStatisticRepository.Add(item);
            return CreatedAtAction(nameof(GetItem), new { item.Id }, item);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Edit([FromBody] TradersStatistics tradersStatistics)
        {
            try
            {
                TradersStatisticRepository.Update(tradersStatistics);
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
            TradersStatistics item = TradersStatisticRepository.Remove(id);

            if (item == null)
                return NotFound();

            return Ok();
        }
    }
}
