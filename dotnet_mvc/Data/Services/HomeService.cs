using dotnet_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc.Data.Services
{
    public class HomeService : IHomeServices
    {
        private readonly AppDbContext _context;

        public HomeService(AppDbContext context)
        {
            _context = context;
        }

        public List<tblT_Personal> GenerateSeed()
        {
            var list = new List<tblT_Personal>();
            //_context.Database.ExecuteSql();
            return list;
        }
    }
}