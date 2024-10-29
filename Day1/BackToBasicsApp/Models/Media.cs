using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasicsApp.Models
{
    public enum ProductMediaType
    {
        Image,Video, Audio
    }
    public class Media : IEquatable<Media>, IComparable<Media>
    { 
        public Media()
        {
            //MediaUrl = string.Empty;
        }
        public int Id { get; set; }
        public string? MediaUrl { get; set; } 
        public int ProductId { get; set; }
        public ProductMediaType MediaType { get; set; }

        public int CompareTo(Media? other)
        {
            var media = other??new Media();
            return media.Id.CompareTo(media.Id);
        }

        public bool Equals(Media? other)
        {
            var media = other ?? new Media();
            return media.Id.Equals(media.Id);
        }

        public override string ToString()
        {
            return $"Id {Id} \tMediaUrl {MediaUrl??"No image present"} \tType: {MediaType}";
        }
    }
    public class UpdatedMedia:Media
    {
        public DateOnly CreatedDate { get; set; }
        public UpdatedMedia()
        {
            
        }
        public UpdatedMedia(DateOnly createdDate):base()
        {
            CreatedDate = createdDate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t Created Date :{CreatedDate}";
        }
    }
}
