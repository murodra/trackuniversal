using TrackUniversal.Dtos;
using TrackUniversal.Entities;

namespace TrackUniversal
{
    public static class Extensions{
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                CreatedDate = item.CreatedDate
            };
        }
    }
}