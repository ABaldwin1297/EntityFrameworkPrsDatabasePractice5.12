using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPrsDatabasePractice5._12.Controllers;
using EntityFrameworkPrsDatabasePractice5._12.Models;
using Microsoft.Data.SqlClient;

namespace EntityFrameworkPrsDatabasePractice5._12.Controllers {
    public class VendorControllers : UserControllers {
        private AppDbContext _context = new AppDbContext();

        public List<Vendor> GetVendors() {
            return _context.Vendors.ToList();
        }
        public Vendor GetVendorByPk(int id) {
            return _context.Vendors.Find(id)!;
        }
        public Vendor AddVendor(Vendor vendor) {
            _context.Vendors.Add(vendor);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("Add Vendor failed!");
            }
            return vendor;
        }
        public void UpdateVendor(Vendor vendor) {
            _context.Entry(vendor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("Update Vendor failed!");
            }
        }
        public void DeleteVendor(int id) {
            var vendor = GetVendorByPk(id);
            if (vendor is null) {
                throw new Exception("Vendor not found!");
            }
            _context.Vendors.Remove(vendor);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1) {
                throw new Exception("Delete Vendor Failed");
            }
        }
    }
}
