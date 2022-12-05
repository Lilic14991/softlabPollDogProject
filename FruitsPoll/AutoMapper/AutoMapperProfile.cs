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
        /// <summary>Initializes a new instance of the <see cref="AutoMapperProfile" /> class.</summary>
        public AutoMapperProfile()
        {
            this.CreateMap<DTO.CreateSurveyResult, Models.SurveyResult>()
                .ForMember(dest => dest.Stars, opt => opt.MapFrom(src => src.Rating)).ReverseMap();
            this.CreateMap<DTO.Product, Models.Product>();
            this.CreateMap<Models.ProductAverageRatings, DTO.ProductAverageRatings>();
            this.CreateMap<DTO.CreateProduct, Models.Product>();
            this.CreateMap<DTO.Brand, Models.Brand>();
            this.CreateMap<DTO.CreateBrand, Models.Brand>();
        }
    }
}
