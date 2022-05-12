
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPrsDatabasePractice5._12.Models;

void Main() { };

var db = new AppDbContext();

db.Users.ToList().ForEach(x => Console.WriteLine(x));