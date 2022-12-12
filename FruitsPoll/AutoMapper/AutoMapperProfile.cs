// -------------------------------------------------------------------------------
// <copyright file="AutoMapperProfile.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.AutoMapper
{
    using global::AutoMapper;
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
                .ReverseMap();
            this.CreateMap<Models.Product, DTO.Product>().ReverseMap();
            this.CreateMap<Models.Product, DTO.ProductAverageRating>()
                .ForMember(
                    dest => dest.ProductName,
                    opt => opt.MapFrom(src => src.Name));
            this.CreateMap<DTO.ProductCreate, Models.Product>();
            this.CreateMap<Models.Brand, DTO.Brand>().ReverseMap();
            this.CreateMap<DTO.BrandCreate, Models.Brand>();
        }

        #endregion
    }
}
