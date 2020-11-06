using System;
using System.Threading.Tasks;
using BoatService.Web.DataAccess.Contracts;
using BoatService.Web.DataAccess.Implementations.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoatService.Web.Controllers
{
    public class TripOrderRequestController : Controller
    {
        private readonly IDbRepository<TripOrderRequest> _tripOrderRequestRepository;

        public TripOrderRequestController(IDbRepository<TripOrderRequest> tripOrderRequestRepository)
        {
            _tripOrderRequestRepository = tripOrderRequestRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var collection = await _tripOrderRequestRepository.Get().ToListAsync();
            
            return Ok(collection);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _tripOrderRequestRepository.Get().FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                return BadRequest("TripOrderRequest not found");
            }
            
            return Ok(entity);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Post(TripOrderRequest tripOrderRequest)
        {
            if (tripOrderRequest == null)
            {
                return BadRequest("TripOrderRequest is null");
            }
            
            await _tripOrderRequestRepository.Create(tripOrderRequest);
            
            return Ok("TripOrderRequest created");
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(TripOrderRequest tripOrderRequest)
        {
            if (tripOrderRequest == null)
            {
                return BadRequest("TripOrderRequest is null");
            }
            
            await _tripOrderRequestRepository.Update(tripOrderRequest);

            return Ok("TripOrderRequest updated");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(TripOrderRequest tripOrderRequest)
        {
            if (tripOrderRequest == null)
            {
                return BadRequest("TripOrderRequest is null");
            }
            
            await _tripOrderRequestRepository.Delete(tripOrderRequest);

            return Ok("TripOrderRequest deleted");
        }
    }
}