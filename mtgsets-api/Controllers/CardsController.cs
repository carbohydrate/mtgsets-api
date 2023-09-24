using Microsoft.AspNetCore.Mvc;
using Mtgsets.Data;
using Mtgsets.Models;
using Mtgsets.Models.Generated;

namespace Mtgsets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly MtgsetsContext _context;

        public CardsController(MtgsetsContext context)
        {
            _context = context;
        }

        // GET: api/Cards
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        //{
        //  if (_context.Cards == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.Cards.ToListAsync();
        //}

        // GET: api/Cards/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return card;
        }
    }
}
