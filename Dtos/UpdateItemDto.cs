using System.ComponentModel.DataAnnotations;

namespace TrackUniversal.Dtos
{
    public record UpdateItemDto
    {
        [Required]
        public string Name { get; init; }
    }
}