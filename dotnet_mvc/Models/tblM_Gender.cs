using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc.Models
{
    public class tblM_Gender
    {
        [Key]
        public int Id {get; set; }
        public string? Name { get; set; }

        public List<tblT_Personal>? tblT_Personals {get; set; }
    }
}