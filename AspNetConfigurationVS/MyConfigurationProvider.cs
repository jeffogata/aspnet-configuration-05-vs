namespace AspNetConfigurationVS
{
    using Microsoft.Extensions.Configuration;

    public class MyConfigurationProvider : ConfigurationProvider
    {
        public override void Load()
        {
            Data["setting1"] = "Value 1 - Custom";

            Data["data:settingA"] = "Value A - Custom";
        }
    }
}