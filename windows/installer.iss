; RC-Ranya — normal Windows installer (the portable .exe stays the default download)
#define AppName "RC-Ranya"
#define AppVer  GetEnv("UORRC_VERSION")
#if AppVer == ""
  #define AppVer "1.0.0"
#endif

[Setup]
AppName={#AppName}
AppVersion={#AppVer}
AppPublisher=University of Raparin - English Department
DefaultDirName={autopf}\{#AppName}
DefaultGroupName={#AppName}
DisableProgramGroupPage=yes
OutputDir=.
OutputBaseFilename=RC-Ranya-Setup
SetupIconFile=..\windows\remco.ico
UninstallDisplayIcon={app}\RC-Ranya.exe
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
PrivilegesRequiredOverridesAllowed=dialog
ArchitecturesInstallIn64BitMode=x64compatible

[Files]
Source: "RC-Ranya.exe"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#AppName}"; Filename: "{app}\RC-Ranya.exe"
Name: "{autodesktop}\{#AppName}"; Filename: "{app}\RC-Ranya.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Create a desktop shortcut"; GroupDescription: "Shortcuts:"
Name: "startup"; Description: "Start RC-Ranya when Windows starts"; GroupDescription: "Options:"; Flags: unchecked

[Registry]
Root: HKCU; Subkey: "Software\Microsoft\Windows\CurrentVersion\Run"; ValueType: string; ValueName: "RC-Ranya"; \
  ValueData: """{app}\RC-Ranya.exe"""; Flags: uninsdeletevalue; Tasks: startup

[Run]
Filename: "{app}\RC-Ranya.exe"; Description: "Open RC-Ranya now"; Flags: nowait postinstall skipifsilent
