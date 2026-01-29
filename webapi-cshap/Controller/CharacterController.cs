    using Microsoft.AspNetCore.Mvc;
    using webapi_cshap.Data;
    using webapi_cshap.Models;

    namespace webapi_cshap.Controller;

    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public CharacterController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

      [HttpPost]
        public async Task<IActionResult> AddCharacter(Character character)
        {
            if (character == null)
            {
                return BadRequest();
            }

            
            _dbContext.Characters.Add(character);
            await _dbContext.SaveChangesAsync();
            
            return Ok(character);
        }
    };