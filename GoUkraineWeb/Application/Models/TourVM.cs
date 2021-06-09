using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Models
{
    public class TourVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string DeparturePlace { get; set; }
        public string ArivalFromPlace { get; set; }
        public string FoodSupplyType { get; set; }
        public string TravelerTypes { get; set; }
        public int PeopleCount { get; set; }
        public int HotelStars { get; set; }
        public double Costs { get; set; }

        public Carousel Carousel { get; set; } = new Carousel();
        public List<TourService> Services { get; set; } = new List<TourService>();
        public List<TourInfoBlock> InfoBlocks { get; set; } = new List<TourInfoBlock>();

        public bool IsInfoBlockActive(int infoBlockId)
        {
            return InfoBlocks.FirstOrDefault().Id == infoBlockId;
        }
    }
    public class Carousel
    {
        public int ThumbPageSize { get; set; } = 6;
        public int ThumbPagesCount
        {
            get
            {
                return (ThumbList.Count / ThumbPageSize) + 1;
            }
        }
        public List<CarouselImg> ImgList { get; set; } = new List<CarouselImg>();
        public List<CarouselThumb> ThumbList { get; set; } = new List<CarouselThumb>();


        public List<CarouselThumb> GetThumbPage(int page)
        {
            return ThumbList.Skip(page * ThumbPageSize).Take(ThumbPageSize).ToList();
        }
        public bool IsImgActive(int imgId)
        {
            return ImgList.FirstOrDefault().Id == imgId;
        }
        public bool IsThumbSelected(int thumbId)
        {
            return ThumbList.FirstOrDefault().Id == thumbId;
        }
    }
    public class CarouselImg
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public string Alt { get; set; }
        public string DataRemote { get; set; }
        public string DataType { get; set; }
        public string DataToggle { get; set; }
        public string DataGallery { get; set; }
    }
    public class CarouselThumb
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public string Alt { get; set; }
    }
    public class TourService
    {
        public string Img { get; set; }
        public string Text { get; set; }
    }
    public class TourInfoBlock
    {
        public int Id { get; set; }
        public string NavName { get; set; }
        public string NavTitle { get; set; }
        public string HtmlContent { get; set; }
    }

}
