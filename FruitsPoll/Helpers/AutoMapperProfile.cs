// -------------------------------------------------------------------------------
// <copyright file="AutoMapperProfile.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.Helpers
{
    using AutoMapper;
    using DTO = PollDog.API.DTO;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult mapper profile class.</summary>
    public class AutoMapperProfile : Profile
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="AutoMapperProfile" /> class.</summary>
        public AutoMapperProfile()
        {
            this.CreateMap<DTO.SurveyResultCreate, Models.SurveyResult>()
                .ForMember(
                    dest => dest.Stars,
                    opt => opt.MapFrom(src => src.Rating))
                .ForMember(
                    dest => dest.Product,
                    opt => opt.MapFrom(src => new Models.Product() { Id = src.Product.Id }));
            this.CreateMap<Models.Product, DTO.ProductResponse>();
            this.CreateMap<DTO.ProductResponse, Models.Product>();
            this.CreateMap<DTO.ProductRequest, Models.Product>();
            this.CreateMap<Models.Product, DTO.ProductAverageRating>()
                .ForMember(
                    dest => dest.ProductName,
                    opt => opt.MapFrom(src => src.Name));
            this.CreateMap<Models.Brand, DTO.Brand>().ReverseMap();
        }

        #endregion
    }
}
