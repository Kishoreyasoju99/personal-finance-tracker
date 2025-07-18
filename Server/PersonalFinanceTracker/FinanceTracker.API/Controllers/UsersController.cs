using FinanceTracker.API.Data;
using FinanceTracker.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly FinanceDbContext _dbContext;
        public UsersController(FinanceDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int userId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]

        public async Task<ActionResult> SaveUser(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(User user)
        { 
            var userToUpdate= _dbContext.Users.Find(user.Id);
            if (userToUpdate != null)
            {
                _dbContext.Users.Update(userToUpdate);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int userId)
        {

            var user = await _dbContext.Users.FindAsync(userId);
            if (user == null)
            { 
              return NotFound();
            }

            _dbContext.Users.Remove(user);  
            await _dbContext.SaveChangesAsync();
            return NoContent();

        }

    }
}
