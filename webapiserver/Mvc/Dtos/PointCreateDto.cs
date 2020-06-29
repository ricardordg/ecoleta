using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapiserver.Mvc.Dto
{
    public class PointCreateDto
    {
        [Required]
        public string Image { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Whatsapp { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Uf { get; set; }

        [Required]
        public float Latitude { get; set; }

        [Required]
        public float Longitude { get; set; }

        public List<int> Items { get; set; }
    }
}