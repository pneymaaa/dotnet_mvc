using dotnet_mvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace dotnet_mvc.Data.Services
{
    public class HomeService : IHomeServices
    {
        private readonly AppDbContext _context;

        public HomeService(AppDbContext context)
        {
            _context = context;
        }

        private DataTable? GenerateDataTable()
        {
            var personalDt = new DataTable();
            personalDt.Columns.Add("Name", typeof(string));
            personalDt.Columns.Add("IdHobby", typeof(char));
            personalDt.Columns.Add("NameHobby", typeof(string));
            personalDt.Columns.Add("IdGender", typeof(int));
            personalDt.Columns.Add("GenderName", typeof(string));
            personalDt.Columns.Add("Age", typeof(int));
            var rd = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                var gender = Helper.CreateRandomGender(rd);
                var hobby = Helper.CreateRandomHobby(rd);
                var age = rd.Next(18,41);
                personalDt.Rows.Add(Helper.CreateRandomName(rd, (5,25)),hobby.Id,hobby.Name,gender.Id,gender.Name,age);
            }
            return personalDt;
        }

        public List<udt_Personal>? GetDataTable()
        {
            try
            {
                var parameter = new SqlParameter("@Udt", SqlDbType.Structured)
                {
                    Value = GenerateDataTable(),
                    TypeName = "dbo.udt_Personal"
                };
                var res = _context.Set<udt_Personal>().FromSqlRaw("exec sp_getDataTable @Udt", parameter).ToList();
                return res;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void InsertDataTable(List<udt_Personal> udt_Personals, out string errorMessage) 
        {
            errorMessage = string.Empty;
            try
            {
                var parameter = new SqlParameter("@Udt", SqlDbType.Structured)
                {
                    Value = udt_Personals.ToDataTable(),
                    TypeName = "dbo.udt_Personal"
                };
                _context.Database.ExecuteSqlRaw("exec sp_insertDataTable @Udt", parameter);
                _context.Database.ExecuteSqlRaw("exec sp_update_tblT_Ages");
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }
    }
}