using MyWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUser(ApplicationUser applicationUser)
        {
            var user = new ApplicationUser
            {
                FirstName = applicationUser.FirstName,
                LastName = applicationUser.LastName,
                DateOfBirth = applicationUser.DateOfBirth,
                Address = applicationUser.Address,
                CellNumber = applicationUser.CellNumber,
                EmailAddress = applicationUser.EmailAddress
            };
            _context.AppUsers.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<ApplicationUser> ListUsers
        {
            get
            {
                return _context.AppUsers;
            }
        }
    }
}
