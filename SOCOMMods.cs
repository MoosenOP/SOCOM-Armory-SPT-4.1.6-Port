using Version = SemanticVersioning.Version;
using Range = SemanticVersioning.Range;
using System.Reflection;
using SemanticVersioning;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace SOCOM;

// Test 14: register SOCOM custom items after Epic AIO (100003-100006), within Preload.
// Retain original release content unchanged; trader service migration follows.
public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.mtmilitia.socom";
    public string Name { get; init; } = "SOCOM Armory";
    public string Author { get; init; } = "MT_Militia";
    public List<string> Contributors { get; init; } = ["Srispt", "EpicRangeTime"];
    public Version Version { get; init; } = new(typeof(ModMetadata).Assembly.GetName().Version?.ToString(3) ?? "2.0.3");
    public Range SptVersion { get; init; } = new("~4.1.6");
    public Dictionary<string, Range> ModDependencies { get; init; } = new()
    {
        ["com.wtt.commonlib"] = new Range("~3.0.6"),
        ["com.epicrangetime.aio"] = new Range("~5.0.3")
    };
    public bool HasPrepatcher { get; init; } = false;
    public List<string> Incompatibilities { get; init; } = [];
    public string? Url { get; init; } = null;
    public string License { get; init; } = "See bundled LICENSE";
}

[Injectable(TypePriority = OnLoadOrder.Preload + 7)]
public class SOCOM(WTTServerCommonLib.WTTServerCommonLib wttCommon) : IOnLoad
{
    public async Task OnLoadAsync(CancellationToken cancellationToken)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        await wttCommon.CustomItemServiceExtended.CreateCustomItems(assembly);
    }
}
