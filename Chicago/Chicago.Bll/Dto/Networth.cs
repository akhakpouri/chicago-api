using Daytona.Dto;
using System;
using System.Collections.Generic;

namespace Chicago.Bll.Dto
{
    public class Networth : BaseDto
    {
        public DateTime CapturedDate { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
