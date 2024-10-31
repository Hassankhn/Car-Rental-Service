using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spareparts.Models;

namespace UserAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MyDbContext _context;
        public UsersController(MyDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Register")]

        public IActionResult register(UserDTO userModel)
        {

            if (userModel == null||!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _context.Users.FirstOrDefault(x => x.Email == userModel.Email);

            if (user != null) {

                return BadRequest("User already exists with this email");
            }

            _context.Users.Add(new User
            {
                Name = userModel.Name,
                Email = userModel.Email,
                Password = userModel.Password,
                Address = userModel.Address,
                UserCNIC = userModel.UserCNIC,
                CreatedOn = DateTime.Now,

            });

           

            _context.SaveChanges();
            return Ok("User Registered Successfully");

        }


        [HttpPost]
        [Route("Login")]

        public IActionResult Login(LoginDTO loginDTO) {
            if (loginDTO == null||!ModelState.IsValid) { 
                return BadRequest(ModelState);
            }
            var user = _context.Users.FirstOrDefault(x=>x.Email == loginDTO.Email && x.Password==loginDTO.Password);

            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest("Invalid credentials");
        
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok(_context.Users.ToList());
        }

        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUser(int id)
        {
            if (id == 0) { 
            return BadRequest();
            }
            var user = _context.Users.FirstOrDefault(x=>x.UserId == id);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest("User Not Found");
        }
    }
}
