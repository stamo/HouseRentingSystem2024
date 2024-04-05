using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("Title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image url")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Monthly price")]
        [Column(TypeName = "decimal(18,2)")]
        //[Range(typeof(decimal), HouseRentingPriceMinimum, HouseRentingPriceMaximum, ConvertValueInInvariantCulture = true)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Agent identifier")]
        public int AgentId { get; set; }

        [Comment("User id of the renterer")]
        public string? RenterId { get; set; }

        [Comment("Is house approved by admin")]
        public bool IsApproved { get; set; }

        public Category Category { get; set; } = null!;

        public Agent Agent { get; set; } = null!;

        [ForeignKey(nameof(RenterId))]
        public ApplicationUser? Renter { get; set; }
    }
}
