using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context) : base()
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers() => _context.Users.ToList();

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id) => _context.Users.Find(id);
    }
}
