using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapiserver.Domain.Entities
{
    public class Item
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        public string Image { get; set; }

         public ICollection<PointItem> PointItems { get; set; } 
    }
}