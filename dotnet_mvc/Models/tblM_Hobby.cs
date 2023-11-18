using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_mvc.Models
{
    public class tblM_Hobby
    {
        [Key]
        public char Id {get; set; }

        public string? Name { get; set; }
        
        public List<tblT_Personal>? tblT_Personals {get; set; }
    }
}