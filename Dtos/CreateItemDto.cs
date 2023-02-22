using System.ComponentModel.DataAnnotations;

namespace TrackUniversal.Dtos
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }
    }
}