using Playnite.SDK;

namespace RomM
{
	internal interface IRomM
	{
		ILogger Logger { get; }
		IPlayniteAPI Playnite { get; }
		Settings.SettingsViewModel Settings { get; }
		string GetPluginUserDataPath();
	}
}