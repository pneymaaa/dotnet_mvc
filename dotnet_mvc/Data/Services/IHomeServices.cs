using dotnet_mvc.Models;

namespace dotnet_mvc.Data.Services
{
    public interface IHomeServices
    {
        List<udt_Personal>? GetDataTable();
        void InsertDataTable(List<udt_Personal> udt_Personals, out string errorMessage);
    }
}