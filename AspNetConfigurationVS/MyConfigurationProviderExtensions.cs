namespace AspNetConfigurationVS
{
    using Microsoft.Extensions.Configuration;

    public static class MyConfigurationProviderExtensions
    {
        public static IConfigurationBuilder AddMyConfiguration(this IConfigurationBuilder builder)
        {
            return builder.Add(new MyConfigurationProvider());
        }
    }
}