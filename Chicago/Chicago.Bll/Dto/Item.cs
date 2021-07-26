using Daytona.Dto;
using System.ComponentModel.DataAnnotations;

namespace Chicago.Bll.Dto
{
    public class Item : BaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Only positive numbers are allowd")]
        public int Type { get; set; }
        public string TypeValue { get; set; }

    }
}
