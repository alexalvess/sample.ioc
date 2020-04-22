using System;
using Sample.IoC.Domain.Entities;
using Sample.IoC.Domain.Entities.DTOs;
using Sample.IoC.Domain.Interfaces;

namespace Sample.IoC.Services
{
    public class ServiceClub : IServiceClub
    {
        public Club CalculatePercentage(ClubDTO clubDTO)
        {
            var percentage = (Convert.ToDouble(clubDTO.PointsEarned) / Convert.ToDouble(clubDTO.GamesPlayed * 3)) * 100;

            return new Club
            {
                Name = clubDTO.Name,
                Percentage = percentage
            };
        }
    }
}


