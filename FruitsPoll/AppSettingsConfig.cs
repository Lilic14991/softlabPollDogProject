// -------------------------------------------------------------------------------
// <copyright file="AppSettingsConfig.cs" company="SoftLab">
// Copyright (c) www.SoftLab.rs. All rights reserved.
// </copyright>
// -------------------------------------------------------------------------------
namespace PollDog.API
{
    /// <summary>statting class AppSettingsConfig.</summary>
    public static class AppSettingsConfig
    {
        /// <summary>The configuration.</summary>
        private static IConfiguration? config;

        /// <summary>Gets the configuration.</summary>
        /// <value>The configuration.</value>
        public static IConfiguration Configuration
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                config = builder.Build();
                return config;
            }
        }
    }
}
