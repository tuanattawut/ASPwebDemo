using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Display(Name = "รหัสภาพยนต์")]
        public int Id { get; set; }
        [Display(Name = "ชื่อภาพยนต์")]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "วันที่ออกอากาศ")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "ประเภท")]
        public string Genre { get; set; }
        [Display(Name = "ราคา")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }



    }
}