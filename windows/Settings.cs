using System.Security.Cryptography;
using System.Text.Json;

namespace Remco;

/// <summary>
/// Portable settings: stored in a "RC-Ranya-data" folder next to Remco.exe (so the
/// whole thing can live on a USB stick). Falls back to %LOCALAPPDATA%\Remco when
/// the exe's folder is read-only.
/// </summary>
internal sealed class Settings
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N")[..12];
    public string Pin { get; set; } = RandomNumberGenerator.GetInt32(1000, 10000).ToString();
    public bool AutoHotspot { get; set; }
    public string PhoneIp { get; set; } = "";

    public static string DataDir { get; private set; } = "";
    private static string FilePath => Path.Combine(DataDir, "settings.json");

    public static Settings Load()
    {
        DataDir = PickDataDir();
        try
        {
            if (File.Exists(FilePath))
                return JsonSerializer.Deserialize<Settings>(File.ReadAllText(FilePath)) ?? new Settings();
        }
        catch { }
        var s = new Settings();
        s.Save();
        return s;
    }

    public void Save()
    {
        try { File.WriteAllText(FilePath, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true })); }
        catch { }
    }

    private static string PickDataDir()
    {
        try
        {
            string exeDir = AppContext.BaseDirectory;
            string dir = Path.Combine(exeDir, "RC-Ranya-data");
            // keep using settings from an older version (UOR-RC, then Remco) if they are there
            foreach (string oldName in new[] { "UOR-RC-data", "Remco-data" })
            {
                string old = Path.Combine(exeDir, oldName);
                if (!Directory.Exists(dir) && Directory.Exists(old)) { dir = old; break; }
            }
            Directory.CreateDirectory(dir);
            string probe = Path.Combine(dir, ".write-test");
            File.WriteAllText(probe, "ok");
            File.Delete(probe);
            return dir;
        }
        catch
        {
            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RC-Ranya");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }
}
