using Microsoft.AspNetCore.Mvc;
using Mtgsets.Data;
using Mtgsets.Models;
using Mtgsets.Models.Generated;

namespace Mtgsets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetsController : ControllerBase
    {
        private readonly MtgsetsContext _context;

        public SetsController(MtgsetsContext context)
        {
            _context = context;
        }

        // GET: api/Sets
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        //{
        //    if (_context.Cards == null)
        //    {
        //        return NotFound();
        //    }
        //    return await _context.Cards.ToListAsync();
        //}

        // GET: api/Sets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SetDTO>> GetSet(int id)
        {
            var set = await _context.Sets.FindAsync(id);

            if (set == null)
            {
                return NotFound();
            }

            return SetToDTO(set);
        }

        private static SetDTO SetToDTO(Set set)
        {
            var dto = new SetDTO
            {
                Id = set.Id,
                Name = set.Name
            };
            return dto;
        }
    }
}
