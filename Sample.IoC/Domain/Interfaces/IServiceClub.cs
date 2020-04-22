using Sample.IoC.Domain.Entities;
using Sample.IoC.Domain.Entities.DTOs;

namespace Sample.IoC.Domain.Interfaces
{
    public interface IServiceClub
    {
        Club CalculatePercentage(ClubDTO clubDTO);
    }
}

