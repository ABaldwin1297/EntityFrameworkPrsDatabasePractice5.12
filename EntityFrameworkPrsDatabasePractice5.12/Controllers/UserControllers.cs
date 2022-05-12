using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPrsDatabasePractice5._12.Controllers;
using EntityFrameworkPrsDatabasePractice5._12.Models;
using Microsoft.Data.SqlClient;

namespace EntityFrameworkPrsDatabasePractice5._12.Controllers {
    public class UserControllers  {
        private AppDbContext _context = new AppDbContext();

        public List<User> GetUsers() {
            return _context.Users.ToList();
        }
        public User GetUserByPk(int id) {
            return _context.Users.Find(id)!;
        }
        public User AddUser(User user) {
            _context.Users.Add(user);
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1) {
                throw new Exception("Add User failed!");
            }
            return user;
        }

        public void UpdateUser(User user) {
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1) {
                throw new Exception("Update User failed!");
            }
        }

        public void DeleteUser(int id) {
            var user = GetUserByPk(id);
            if(user is null) {
                throw new Exception("User not found!");
            }
            _context.Users.Remove(user);
            var rowsAffected = _context.SaveChanges();
            if(rowsAffected != 1) {
                throw new Exception("Delete User Failed");
            }
        }
    }
}
