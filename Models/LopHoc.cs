using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2526_2221050573_BaiThi.Models.Entities
{
    public class LopHoc
    {
        [Key]
        public string? MaLop{get;set;}

        public string? TenLop{get;set;}

    }
}