using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            try
            {
                List<User> users = await _userService.Get();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van alle gebruikers", null, 500, ex.Message);
            }
        }

        // GET: api/users/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            try
            {
                User? user = await _userService.GetByIDString(id);

                if (user == null)
                {
                    return NotFound(); // Return 404 als de gebruiker niet is gevonden
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een gebruiker", null, 500, ex.Message);
            }
        }

        // POST: api/users
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var createdUser = await _userService.Create(user);
                return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het maken van een gebruiker", null, 500, ex.Message);
            }
        }

        // PUT: api/users/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                User? oldUser = await _userService.GetByID(id);
                if (oldUser == null)
                {
                    return NotFound(); // Return 404 als de gebruiker niet is gevonden
                }

                await _userService.Update(id, user);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een gebruiker", null, 500, ex.Message);
            }
        }

        // DELETE: api/users/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                User? user = await _userService.GetByID(id);
                if (user == null)
                {
                    return NotFound(); // Return 404 als de gebruiker niet is gevonden
                }

                await _userService.Delete(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een gebruiker", null, 500, ex.Message);
            }
        }
        // Aanvullende methoden voor Employee, Admin, Specialist
        // GET: api/users/admins/{id}
        [HttpGet("admins/{id}")]
        public async Task<ActionResult<Administrator>> GetAdmin(int id)
        {
            try
            {
                User? admin = await _userService.GetByID(id);
                if (admin == null)
                {
                    return NotFound(); // Return 404 als de administrator niet is gevonden
                }
                return Ok(admin);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een administrator", null, 500, ex.Message);
            }
        }

        // POST: api/users/admins
        [HttpPost("admins")]
        public async Task<ActionResult<Administrator>> CreateAdmin([FromBody] Administrator admin)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var createdAdmin = await _userService.CreateAdmin(admin);
                return CreatedAtAction(nameof(GetAdmin), new { id = createdAdmin.Id }, createdAdmin);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het maken van een administrator", null, 500, ex.Message);
            }
        }

        // PUT: api/users/admins/{id}
        [HttpPut("admins/{id}")]
        public async Task<IActionResult> UpdateAdmin(int id, [FromBody] Administrator admin)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                User? oldAdmin = await _userService.GetByID(id);
                if (oldAdmin == null)
                {
                    return NotFound(); // Return 404 als de administrator niet is gevonden
                }
                await _userService.UpdateAdmin(id, admin);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een administrator", null, 500, ex.Message);
            }
        }

        // DELETE: api/users/admins/{id}
        [HttpDelete("admins/{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            try
            {
                User? admin = await _userService.GetByID(id);
                if (admin == null)
                {
                    return NotFound(); // Return 404 als de administrator niet is gevonden
                }
                await _userService.Delete(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een administrator", null, 500, ex.Message);
            }
        }
        // ...

        // Aanvullende methoden voor Employee, Admin, Specialist

        // GET: api/users/specialists/{id}
        [HttpGet("specialists/{id}")]
        public async Task<ActionResult<Specialist>> GetSpecialist(int id)
        {
            try
            {
                User? specialist = await _userService.GetByID(id);
                if (specialist == null)
                {
                    return NotFound(); // Return 404 als de specialist niet is gevonden
                }
                return Ok(specialist);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een specialist", null, 500, ex.Message);
            }
        }

        // POST: api/users/specialists
        [HttpPost("specialists")]
        public async Task<ActionResult<Specialist>> CreateSpecialist([FromBody] Specialist specialist)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var createdSpecialist = await _userService.CreateSpecialist(specialist);
                return CreatedAtAction(nameof(GetSpecialist), new { id = createdSpecialist.Id }, createdSpecialist);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het maken van een specialist", null, 500, ex.Message);
            }
        }

        // PUT: api/users/specialists/{id}
        [HttpPut("specialists/{id}")]
        public async Task<IActionResult> UpdateSpecialist(int id, [FromBody] Specialist specialist)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                User? oldSpecialist = await _userService.GetByID(id);
                if (oldSpecialist == null)
                {
                    return NotFound(); // Return 404 als de specialist niet is gevonden
                }
                await _userService.UpdateSpecialist(id, specialist);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een specialist", null, 500, ex.Message);
            }
        }

        // DELETE: api/users/specialists/{id}
        [HttpDelete("specialists/{id}")]
        public async Task<IActionResult> DeleteSpecialist(int id)
        {
            try
            {
                User? specialist = await _userService.GetByID(id);
                if (specialist == null)
                {
                    return NotFound(); // Return 404 als de specialist niet is gevonden
                }
                await _userService.Delete(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een specialist", null, 500, ex.Message);
            }
        }
        // GET: api/users/employees/{id}
        [HttpGet("employees/{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                User? employee = await _userService.GetByID(id);
                if (employee == null)
                {
                    return NotFound(); // Return 404 als de employee niet is gevonden
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een employee", null, 500, ex.Message);
            }
        }

        // POST: api/users/employees
        [HttpPost("employees")]
        public async Task<ActionResult<Employee>> CreateEmployee([FromBody] Employee employee)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var createdEmployee = await _userService.CreateEmployee(employee);
                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het maken van een employee", null, 500, ex.Message);
            }
        }

        // PUT: api/users/employees/{id}
        [HttpPut("employees/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                User? oldEmployee = await _userService.GetByID(id);
                if (oldEmployee == null)
                {
                    return NotFound(); // Return 404 als de employee niet is gevonden
                }
                await _userService.UpdateEmployee(id, employee);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een employee", null, 500, ex.Message);
            }
        }

        // DELETE: api/users/employees/{id}
        [HttpDelete("employees/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                User? employee = await _userService.GetByID(id);
                if (employee == null)
                {
                    return NotFound(); // Return 404 als de employee niet is gevonden
                }
                await _userService.Delete(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een employee", null, 500, ex.Message);
            }
        }
        
    }
}
