using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NguyenHuongGiang800.Models
{
    public class NHG0800 {
        [Key]
        public string NHGId {get; set;}
  
        public string NHGName {get; set;}

 	   public bool NHGGender {get; set;}

    }
}
