using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.SeedDb
{
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new IdentityUser[] { data.AgentUser, data.GuestUser });
        }
    }
}
