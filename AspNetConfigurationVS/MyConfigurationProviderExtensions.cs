namespace AspNetConfigurationVS
{
    using Microsoft.Extensions.Configuration;

    public static class MyConfigurationProviderExtensions
    {
        public static IConfigurationBuilder AddMyConfiguration(this IConfigurationBuilder builder)
        {
            builder.Add(new MyConfigurationProvider());

            return builder;
        }
    }
}