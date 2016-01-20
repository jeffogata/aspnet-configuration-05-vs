namespace AspNetConfigurationVS
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;
    using Microsoft.Extensions.Configuration;

    public class Startup
    {
        private readonly IConfigurationRoot _configuration;

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddMyConfiguration();

            _configuration = builder.Build();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            app.Run(async context =>
            {
                await context.Response.WriteAsync(
                    "<html><body>" +
                    $"Setting 1: {_configuration["setting1"]}<br>" +
                    $"Setting 2: {_configuration["setting2"]}<br>" +
                    $"Setting 3: {_configuration["setting3"]}<br><br>" +
                    $"Data Setting A: {_configuration["data:settingA"]}<br>" +
                    $"Data Setting B: {_configuration["data:settingB"]}<br>" +
                    $"Data Setting C: {_configuration["data:settingC"]}" +
                    "</body></html>");
            });
        }
    }
}