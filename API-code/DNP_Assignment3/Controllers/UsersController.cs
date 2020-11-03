using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DNP_Assignment3.Models;
using SQLitePCL;

namespace DNP_Assignment3.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        // GET: api/Users/5
        [HttpGet("{userName}")]
        public async Task<ActionResult<UserDTO>> GetUser(string userName)
        {
            User admin = new User
            {
                Id = 1,
                City = "Horsens",
                Domain = "assignment1.family",
                Password = "111111",
                Role = "Admin",
                BirthYear = 1997,
                SecurityLevel = 4,
                UserName = "Admin"
            };

            if (admin.UserName.Equals(userName))
            {
                return ItemToDTO(admin);
            }
            else
            {
                return NotFound();
            }
        }


        private bool UserExists(string userName)
        {
            return _context.Users.Any(e => e.UserName == userName);
        }
        private static UserDTO ItemToDTO(User user) =>
        new UserDTO
        {
            UserName = user.UserName,
            Domain = user.Domain,
            City = user.City,
            BirthYear = user.BirthYear,
            Role = user.Role,
            SecurityLevel = user.SecurityLevel,
            Password = user.Password
        };
    }
}
