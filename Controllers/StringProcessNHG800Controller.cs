using Microsoft.AspNetCore.Mvc;
using NguyenHuongGiang800.Models;
namespace NguyenHuongGiang800.Controllers
{
    public class StringProcessNHG800Controller :Controller
    {
        StringProcessNHG800 strPro = new StringProcessNHG800();

        public IActionResult InHoa()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult InHoa(string strInput )
        { 
            ViewBag.thongbao="Chuyển chuỗi sang in hoa:  "+ strPro.LowerToUpper(strInput);
            return View();
        }
    }
}