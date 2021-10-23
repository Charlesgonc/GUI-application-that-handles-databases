// <copyright file="MapperFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace NBA.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;

    /// <summary>
    /// Responsible to create mapper instances.
    /// </summary>
    public class MapperFactory
    {
        // It is usually located on a service folder but it works fine in the models as well.

        /// <summary>
        /// Creates the mapper.
        /// </summary>
        /// <returns>Mapper instance.</returns>
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // this is a class translation / mapping.
                cfg.CreateMap<NBA.Data.Player, NBA.Web.Models.Player>().
                ForMember(dest => dest.PlayerId, map => map.MapFrom(src => src.PlayerId)).
                ForMember(dest => dest.PlayerAge, map => map.MapFrom(src => src.PlayerAge)).
                ForMember(dest => dest.PlayerHeight, map => map.MapFrom(src => src.PlayerHeight)).
                ForMember(dest => dest.PlayerWeight, map => map.MapFrom(src => src.PlayerWeight)).
                ForMember(dest => dest.PlayerFieldGoal, map => map.MapFrom(src => src.PlayerFieldGoal)).
                ForMember(dest => dest.PlayerDraftDate, map => map.MapFrom(src => src.PlayerDraftDate)).
                ForMember(dest => dest.PlayerSalary, map => map.MapFrom(src => src.PlayerSalary)).
                ForMember(dest => dest.PlayerPosition, map => map.MapFrom(src => src.PlayerPosition)).
                ForMember(dest => dest.PlayerName, map => map.MapFrom(src => src.PlayerName)).
                ForMember(dest => dest.PlayerIsSelected, map => map.MapFrom(src => src.PlayerIsSelected));

                // ReverseMap();
            });
            return config.CreateMapper();

            // creates the automapper instance, that will have everything preconfigured.
        }
    }
}
