using dotnet_mvc.Models;

namespace dotnet_mvc.Data.Services
{
    public interface IHomeServices
    {
        List<tblT_Personal> GenerateSeed();
    }
}