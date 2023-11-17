using System.ComponentModel.DataAnnotations;

namespace dotnet_mvc.Models
{
    public class tblT_Personal
    {
        [Key]
        public int Id {get; set; }
        public string? Name { get; set; }
        public char IdHobby { get; set; }
        [ForeignKey("IdHobby")]
        public tblM_Hobby? tblM_Hobby { get; set; }

        public int IdGender { get; set; }
        [ForeignKey("IdGender")]
        public tblM_Gender? tblM_Gender { get; set; }

        public int Age { get; set; }
        [ForeignKey("Age")]
        public tblT_Age? tblT_Age { get; set; }
    }
}