using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Display(Name = "รหัสภาพยนต์")]
        public int Id { get; set; }
        [Display(Name = "ชื่อภาพยนต์")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "วันที่ออกอากาศ")]
        [DisplayFormat(DataFormatString="{0:d MMMM yyyy} ")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "ประเภท")]
        public string? Genre { get; set; }
        [Display(Name = "รายได้")]
        [DisplayFormat(DataFormatString = "{0:N2} ล้านบาท")]
        public decimal Price { get; set; }
        public string? Url {get;set;}
        public string? youtube {get;set;}
    }
}