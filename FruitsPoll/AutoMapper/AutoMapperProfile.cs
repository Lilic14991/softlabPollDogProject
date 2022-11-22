// -------------------------------------------------------------------------------
// <copyright file="SurveyResultProfile.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API.AutoMapper
{
    using global::AutoMapper;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Models = WebAPI.Core.Models;

    /// <summary>SurveyResult mapper profile class.</summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>Initializes a new instance of the <see cref="AutoMapperProfile" /> class.</summary>
        public AutoMapperProfile()
        {
            this.CreateMap<DTO.SurveyResult, Models.SurveyResult>();
        }
    }
}
