using System;
using System.Threading.Tasks;
using BoatService.Web.DataAccess.Contracts;
using BoatService.Web.DataAccess.Implementations.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoatService.Web.Controllers
{
    [ApiController]
    [Route("order")]
    public class TripOrderController : Controller
    {
        private readonly IDbRepository<TripOrder> _tripOrderRepository;

        public TripOrderController(IDbRepository<TripOrder> tripOrderRepository)
        {
            _tripOrderRepository = tripOrderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var collection = await _tripOrderRepository.Get().ToListAsync();
            
            return Ok(collection);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _tripOrderRepository.Get().FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                return BadRequest("TripOrder not found");
            }
            
            return Ok(entity);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Post(TripOrder tripOrder)
        {
            if (tripOrder == null)
            {
                return BadRequest("TripOrder is null");
            }
            
            await _tripOrderRepository.Create(tripOrder);
            
            return Ok("TripOrder created");
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(TripOrder tripOrder)
        {
            if (tripOrder == null)
            {
                return BadRequest("TripOrder is null");
            }
            
            await _tripOrderRepository.Update(tripOrder);

            return Ok("TripOrder updated");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(TripOrder tripOrder)
        {
            if (tripOrder == null)
            {
                return BadRequest("TripOrder is null");
            }
            
            await _tripOrderRepository.Delete(tripOrder);

            return Ok("TripOrder deleted");
        }
    }
}