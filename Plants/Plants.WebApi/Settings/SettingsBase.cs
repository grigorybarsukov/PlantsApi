using System.Runtime.CompilerServices;

namespace Plants.WebApi.Settings;

public abstract class SettingsBase
{
    protected readonly IConfiguration Config;
    private readonly string section;

    protected SettingsBase(IConfiguration config, string section)
    {
        Config = config;
        this.section = section;
    }

    protected T GetValue<T>([CallerMemberName] string? key = null)
    {
        return Config.GetRequiredSection(section).GetValue<T>(key);
    }
}