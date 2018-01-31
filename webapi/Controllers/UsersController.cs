using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Repository;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _repository;

        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Users>> GetAll()
        {
            return  await _repository.GetAllAsync();
        }

        // GET api/people/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _repository.FindAsync(id);
            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        // POST api/accounts
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Users item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.AddAsync(item);
            await _repository.SaveAsync();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Users value)
        {
            await _repository.UpdateAsync(value,id);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _repository.FindAsync(id);
            if (entity == null)
                return NotFound();
            _repository.RemoveAsync(entity);
            return Ok();
        }
    }
}