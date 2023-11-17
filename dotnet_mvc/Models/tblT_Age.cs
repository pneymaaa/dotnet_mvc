using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc.Models
{
    public class tblT_Age
    {
        [Key]
        public int Age {get; set; }
        public int Total {get; set; }
        public List<tblT_Personal>? tblT_Personals {get; set; }
    }
}