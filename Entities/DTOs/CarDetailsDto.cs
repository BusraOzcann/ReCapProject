using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsDto
    {
        public string CarDescription { get; set; }
        public int BrandId { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
