using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenHuongGiang800.Models
{
    public class CompanyNHG800 {
        [Key]
        public string CompanyId {get; set;}
  
        public string CompanyName {get; set;}
    }
}

