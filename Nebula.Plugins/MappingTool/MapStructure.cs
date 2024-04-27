﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MappingTool
{
    public class MapStructure
    {
        public class Project
        {
            public Settings Settings = new Settings();
            public Window Window = new Window();
            public RuntimeOptions RuntimeOptions = new RuntimeOptions();
            public Values Values = new Values();
            public Events Events = new Events();
            public About About = new About();
            public Windows Windows = new Windows();
            public Frame[] Frames = new Frame[0];
            public ObjectInfo[] ObjectInfos = new ObjectInfo[0];
        }

        public class Settings
        {
            public GraphicMode GraphicMode = GraphicMode.C16Mil;
            public BuildType BuildType = BuildType.WindowsEXE;
            public string BuildFilename = string.Empty;
            public bool ShowDeprecatedBuildTypes = false;
            public CompressionLevel CompressionLevel = CompressionLevel.Normal;
            public bool CompressSounds = false;
            public bool DisplayBuildWarningMessages = true;
            public string CommandLine = string.Empty;
            public bool EnableDebuggerShortcuts = true;
            public bool ShowDebugger = true;
            public bool CrashDisplayLastEvent = true;
            public bool EnableProfiler = false;
            public bool StartProfilingAtStartOfFrame = true;
            public bool ProfileTopLevelConditionsOnly = false;
            public bool RecordSlowestAppLoops = false;
            public bool OptimizeEvents = true;
            public bool OptimizeImageSizeInRAM = true;
            public bool OptimizePlaySample = true;
            public bool MergePlayAndSetSampleActions = false;
            public bool BuildCache = false;
        }

        public class Window
        {
            public int Width = 640;
            public int Height = 480;
            public int[] BorderColor = new int[3] { 255, 255, 255 };
            public bool Heading = true;
            public bool HeadingWhenMaximized = true;
            public bool RightToLeftReading = false;
            public bool RightToLeftLayout = false;
            public bool DisableCloseButton = false;
            public bool NoMinimizeBox = false;
            public bool NoMaximizeBox = false;
            public bool NoThickFrame = false;
            public bool MaximizedOnBootup = false;
            public bool HiddenAtStart = false;
            public bool ShowMenuBar = true;
            public MenuBar MenuBar = new MenuBar();
            public bool MenuDisplayedOnBootup = true;
            public bool ChangeResolutionMode = false;
            public bool AllowUserToSwitchToFromFullScreen = false;
            public bool KeepScreenRatio = false;
            public int ScreenRatioTolerance = 8;
            public bool ResizeDisplayToFillWindowSize = false;
            public bool FitInsideBlackBars = false;
            public bool AntiAliasingWhenResizing = false;
            public bool DoNotCenterFrameAreaInWindow = false;
        }

        public class MenuBar
        {
            public Dictionary<string, string[]> MenuItems = new Dictionary<string, string[]>()
            {
                {
                    "&File",
                    new string[7]
                    {
                        "&New F2",
                        "-",
                        "Pass&word",
                        "&Pause Ctrl+P",
                        "Pla&yers Ctrl+Y",
                        "-",
                        "&Quit Alt+F4"
                    }
                },
                {
                    "&Options",
                    new string[6]
                    {
                        "Play &samples Ctrl+S",
                        "Play &musics Ctrl+M",
                        "-",
                        "&Hide the menu F8",
                        "-",
                        "&Full Screen Alt+Enter"
                    }
                },
                {
                    "&Help",
                    new string[3]
                    {
                        "&Contents F1",
                        "-",
                        "&About"
                    }
                }
            };
            public bool Colors = false;
            public int[] BackgroundColor = new int[3] { 255, 255, 255 };
            public int[] BarBackgroundColor = new int[3] { 255, 255, 255 };
            public int[] CheckboxColor = new int[3] { 0, 0, 0 };
            public int[] GrayedTextColor = new int[3] { 109, 109, 109 };
            public int[] SelectedItemBackgroundColor = new int[3] { 0, 120, 215 };
            public int[] SelectedItemTextColor = new int[3] { 255, 255, 255 };
            public int[] SeparatorColor = new int[3] { 160, 160, 160 };
            public int[] TextColor = new int[3] { 0, 0, 0 };
        }

        public class RuntimeOptions
        {
            public int FrameRate = 60;
            public bool MachineIndependentSpeed = false;
            public bool RunWhenMinimized = false;
            public bool RunWhileResizing = false;
            public bool DoNotStopScreenSaverWhenInputEvent = false;
            public bool DoNotShareDataIfRunAsSubApplication = false;
            public DisplayMode DisplayMode = DisplayMode.Direct3D11;
            public bool VSync = false;
            public int NumberOfBackBuffers = 2;
            public bool PremultipliedAlpha = true;
            public bool OptimizeStringObjects = true;
            public bool MultiSamples = true;
            public bool PlaySoundsOverFrames = false;
            public bool DoNotMuteSamplesOnLoseFocus = false;
            public CharacterInputEncoding Input = CharacterInputEncoding.ANSI;
            public CharacterOutputEncoding Output = CharacterOutputEncoding.Unicode;
            public int InitialScore = 0;
            public int InitialLives = 3;
            public DefaultControls DefaultControls = new DefaultControls();
            public bool IgnoreDestroyIfTooFar = false;
            public bool WindowsLikeCollision = false;
        }

        public class DefaultControls
        {
            public int[] Player1 = new int[9] { 5, 38, 40, 37, 39, 16, 17, 32, 13 };
            public int[] Player2 = new int[9] { 5, 38, 40, 37, 39, 16, 17, 32, 13 };
            public int[] Player3 = new int[9] { 5, 38, 40, 37, 39, 16, 17, 32, 13 };
            public int[] Player4 = new int[9] { 5, 38, 40, 37, 39, 16, 17, 32, 13 };
        }

        public class Values
        {
            public GlobalValue[] GlobalValues = new GlobalValue[0];
            public GlobalString[] GlobalStrings = new GlobalString[0];
        }

        public class GlobalValue
        {
            public string Name = "Global Value A";
            public int Value = 0;
        }

        public class GlobalString
        {
            public string Name = "Global String A";
            public string Value = string.Empty;
        }

        public class Events
        {
            public bool AllowGlobalEventsWithGhostObjects = true;
            public int BaseFrame = 1;
            public EventOrder EventOrder = EventOrder.FrameGlobalBehaviors;
            public string[] Qualifiers = new string[100]
            {
                "Player",
                "Good",
                "Neutral",
                "Bad",
                "Enemies",
                "Friends",
                "Bullets",
                "Arms",
                "Bonus",
                "Collectables",
                "Traps",
                "Doors",
                "Keys",
                "Texts",
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "Parents",
                "Children",
                "Data",
                "Timed",
                "Engine",
                "Areas",
                "Reference Points",
                "Radar Enemies",
                "Radar Friends",
                "Radar Neutrals",
                "Music",
                "Sound",
                "Waveform",
                "Background Scenary",
                "Foreground Scenary",
                "Decorations",
                "Water",
                "Clouds",
                "Empty",
                "Fog",
                "Flowers",
                "Animals",
                "Bosses",
                "NPC",
                "Vehicles",
                "Rockets",
                "Balls",
                "Bombs",
                "Explosions",
                "Particles",
                "Clothes",
                "Glow",
                "Arrows",
                "Buttons",
                "Cursors",
                "Drawing Tools",
                "Indicator",
                "Shapes",
                "Shields",
                "Shifting Blocks",
                "Magnets",
                "Negative Matter",
                "Neutral Matter",
                "Positive Matter",
                "Breakable",
                "Dissolving",
                "Dialogue",
                "HUD",
                "Inventory",
                "Inventory Item",
                "Interface",
                "Movable",
                "Perspective",
                "Calculation Objects",
                "Invisible",
                "Masks",
                "Obstacles",
                "Value Holder",
                "Helpful",
                "Powerups",
                "Targets",
                "Trapdoors",
                "Dangers",
                "Forbidden",
                "Physical Objects",
                "3D Objects",
                "Generic 1",
                "Generic 2",
                "Generic 3",
                "Generic 4",
                "Generic 5",
                "Generic 6",
                "Generic 7",
                "Generic 8",
                "Generic 9",
                "Generic 10"
            };
            public bool AllowAlterablesForCounterString = false;
        }

        public class About
        {
            public string Name = "Application 1";
            public int[] Icons = new int[11] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            public string Filename = string.Empty;
            public string HelpFile = string.Empty;
            public Language Language = Language.EnglishUnitedStates;
            public string Author = string.Empty;
            public string Copyright = string.Empty;
            public string AboutBox = string.Empty;
        }

        public class Windows
        {
            public ImageFilters ImageFilters = new ImageFilters();
            public SoundFilters SoundFilters = new SoundFilters();
            public bool DPIAware = false;
            public bool EnableVisualThemes = true;
            public bool DisableIME = false;
            public bool ReduceCPUUsage = false;
            public bool UnpackedEXE = false;
            public string ModulesSubDirectory = "Modules";
            public bool IncludeExternalFiles = false;
            public InstallSettings InstallSettings = new InstallSettings();
            public ExecutionLevel ExecutionLevel = ExecutionLevel.AsInvoker;
        }

        public class ImageFilters
        {
            public bool Automatic = true;
            public bool AutodeskFLIC = true;
            public bool CompuserveBitmap = true;
            public bool JPEG = true;
            public bool PaintBrush = true;
            public bool PortableNetworkGraphics = true;
            public bool TargaBitmap = true;
            public bool VideoForWindows = true;
            public bool WindowsBitmap = true;
        }

        public class SoundFilters
        {
            public bool Automatic = true;
            public bool AIFF = true;
            public bool MOD = true;
            public bool MP3 = true;
            public bool OggVorbis = true;
            public bool WAVE = true;
        }

        public class InstallSettings
        {
            public string ProductTitle = "Application 1";
            public string DefaultInstallDirectory = "#Program Files#\\#Title";
            public int Font = 0;
            public InstallerFile[] Files = new InstallerFile[0];
            public InstallerWizardTexts WizardTexts = new InstallerWizardTexts();
            public Uninstaller Uninstaller = new Uninstaller();
        }

        public class InstallerWizardTexts
        {
            public string[] Presentation = new string[6]
            {
                "Welcome",
                "<Empty>",
                "<b><fontsize=12>Welcome to the #title Install program</font></b>.",
                "This program allows you to install #title on your hard drive.",
                "It is strongly recommended that before proceeding, you ensure that no other Windows programs are running.",
                "If you do not wish to install #title, click 'Exit' now, otherwise click 'Next' to continue."
            };
            public string[] Information = new string[4]
            {
                "Information",
                "Please read the information below.",
                "",
                "<Empty>"
            };
            public string[] License = new string[6]
            {
                "License",
                "Please read the license agreement below.",
                "Please read the license agreement below and select \"I Agree\" if you agree with its terms and conditions.",
                "",
                "I agree with the above terms and conditions",
                "I do not agree"
            };
            public string[] Directory = new string[9]
            {
                "Directory",
                "Choose an installation folder and click Next to continue.",
                "#Title's files will be installed in the following directory:",
                "<Empty>",
                "<Empty>",
                "Click 'Next' to continue.",
                "Disk space needed :",
                "Available disk space :",
                "%d Mb"
            };
            public string[] Confirmation = new string[6]
            {
                "Confirmation",
                "You are now ready to install #title.",
                "<Empty>",
                "This program will install #title into %s.",
                "<Empty>",
                "Click 'Start' to install #title."
            };
            public string[] Progress = new string[4]
            {
                "Installing",
                "Installation in progress, please wait.",
                "File :",
                "<Empty>"
            };
            public string[] End = new string[10]
            {
                "End",
                "Installation completed.",
                "#Title has been successfully installed.",
                "<Empty>",
                "<Empty>",
                "#Title has not been totally installed because of the following reason:\n\n%s\n\nYou will have to run this utility again to completely install #title.",
                "View %s",
                "Launch #title",
                "You need to restart Windows so that all installed options can take effect. Click 'Restart' if you want to restart Windows immediately.",
                "<Empty>"
            };
            public string[] MiscellaneousTexts = new string[33]
            {
                "#Title Install Program",
                "Please select a directory",
                "Directory name:",
                "Drives",
                "Checking...",
                "Invalid directory.",
                "The destination directory doesn't exist. Do you want it to be created?",
                "One or more files are write-protected. Do you want to overwrite them anyway?",
                "This program cannot install #title because of the following reason:",
                "The access to the following file is denied:\n%s",
                "The following file is in use:\n\n%s\n\nPlease close it and retry.",
                "There is not enough disk space in the target directory. Do you want to try anyway?",
                "Out of memory!",
                "You are currently in the process of installing components.\nIf you exit now, these components will not be installed correctly.\n\nAre you sure you want to cancel?",
                "Install has not completed. Are you sure you want to exit?",
                "The Install wizard did not complete the installation successfully.",
                "Cannot open the following file:\n%s",
                "Cannot create the following file:\n%s",
                "File corrupt or unreadable:\n%s",
                "Cannot write to the following file:\n%s",
                "Disk full!",
                "CRC error - cannot install the following file:\n%s",
                "The access to the following file is denied:\n%s",
                "successfully updated",
                "successfully removed",
                "successfully installed",
                "cannot remove, denied access",
                "error - cannot replace, denied access",
                "Please insert disk number %d.",
                "<Empty>",
                "%s\n\nThis file exists and is a different language than the file to install.\n\nDo yo want to overwrite the installed version anyway?",
                "This file contains invalid data.",
                "Data error in the following file:\n%s\n\nDo you want to continue anyway?"
            };
            public string[] Buttons = new string[7]
            {
                "< &Back",
                "&Next >",
                "E&xit",
                "&Start",
                "OK",
                "&Cancel",
                "&Restart"
            };
        }

        public class Uninstaller
        {
            public string UninstallerFileName = "Uninstall.exe";
            public string StartMenuFolder = "#Title";
            public string StartMenuShortcutName = "Uninstall #Title";
            public string[] Texts = new string[15]
            {
                "Uninstall",
                "This program will uninstall #title from your hard drive. Click OK to continue.",
                "#Title has been successfully removed from your hard drive.",
                "&Yes",
                "Yes to &all",
                "&No",
                "No t&o all",
                "Out of memory!",
                "Invalid uninstall info. This program cannot uninstall #title.",
                "The following file is write-protected:\n%s\nDo you want to remove it anyway?",
                "The following system file is apparently no longer used:\n%s\nDo you want to remove it?",
                "Removing files...",
                "Removing icons...",
                "Removing directories...",
                "Removing registry keys..."
            };
            public string[] Registry = new string[0];
        }

        public class InstallerFile
        {
            public string FileName = string.Empty;
            public InstallFileStartMenu StartMenu = new InstallFileStartMenu();
            public InstallFileShortcut Shortcut = new InstallFileShortcut();
            public InstallFileViewRun ViewRun = new InstallFileViewRun();
            public InstallFileWindows Windows = new InstallFileWindows();
            public InstallFileMac Mac = new InstallFileMac();
        }

        public class InstallFileStartMenu
        {
            public string Folder = "#Title";
            public string Name = "#Title";
            public string CommandLineOptions = string.Empty;
            public string IconFile = string.Empty;
        }

        public class InstallFileShortcut
        {
            public string DesktopShortcutName = "#Title";
            public string CommandLineOptions = string.Empty;
            public string IconFile = string.Empty;
        }

        public class InstallFileViewRun
        {
            public View View = View.No;
            public Run Run = Run.No;
            public string CommandLineOptions = string.Empty;
            public bool WaitForEndBeforeContinuing = false;
            public bool ViewRunOnlyAfterReboot = false;
        }

        public class InstallFileWindows
        {
            public InstallDirectory InstallDirectory = InstallDirectory.DestinationDirectory;
            public string OtherDirectory = string.Empty;
            public bool SetAsScreensaver = false;
            public bool RegisterOCXDLLREG = false;
            public bool IncrementDLLUsage = false;
        }

        public class InstallFileMac
        {
            public bool DoNotInstall = false;
            public bool DoNotUninstall = false;
            public bool OnlyCreateDirectory = false;
            public bool DoNotIfFileExists = false;
            public bool DoNotIfBetterVersion = false;
        }

        public class Frame
        {
            public FrameSettings Settings = new FrameSettings();
            public FrameRuntimeOptions RuntimeOptions = new FrameRuntimeOptions();
            public FrameAbout About = new FrameAbout();
            public Layer[] Layers = new Layer[0];
            public ObjectInstance[] Instances = new ObjectInstance[0];
        }

        public class FrameSettings
        {
            public int Width = 640;
            public int Height = 480;
            public int VirtualWidth = 640;
            public int VirtualHeight = 480;
            public int[] BackgroundColor = new int[3] { 255, 255, 255 };
            public bool DontIncludeAtBuildTime = false;
            public Transition FadeIn = new Transition();
            public Transition FadeOut = new Transition();
            public Effect Effect = new Effect();
            public int BlendCoefficient = 0;
            public int[] RGBCoefficient = new int[3] { 255, 255, 255 };
            public string DemoFile = string.Empty;
            public int RNGSeed = -1;
            public int IncludeAnotherFrame = -1;
        }

        public class Transition
        {
            public string FileName = "cctrans.dll";
            public string ModuleName = "None";
            public int Module = 0;
            public string ModuleID = string.Empty;
            public int Duration = 0;
            public bool UseColor = false;
            public int[] Color = new int[3] { 0, 0, 0 };
        }

        public class Effect
        {
            public int InkEffect = 0;
            public int InkEffectParams = 0;
            public Shader? Shader = null;
        }

        public class FrameRuntimeOptions
        {
            public bool GrabDesktopAtStart = false;
            public bool KeepDisplayFromPreviousFrame = false;
            public bool HandleBackgroundCollisionsEvenOutOfWindow = true;
            public bool DisplayFrameTitleInWindowCaption = false;
            public bool ResizeToScreenSizeAtStart = false;
            public bool Direct3DDontEraseBackground = false;
            public ForceLoadOnCall ForceLoadOnCall = ForceLoadOnCall.No;
            public bool ScreenSaverSetupFrame = false;
            public bool IncludeGlobalEvents = true;
            public int NumberOfObjects = 1000;
            public bool TimerBasedMovements = true;
            public int MovementTimerBase = 60;
            public string Password = string.Empty;
        }

        public class FrameAbout
        {
            public string Name = "Frame 1";
        }

        public class Layer
        {
            public LayerSettings Settings = new LayerSettings();
            public bool VisibleInEditor = true;
            public bool LockedInEditor = false;
        }

        public class LayerSettings
        {
            public string Name = "Untitled";
            public bool VisibleAtStart = true;
            public bool SaveBackground = true;
            public float XCoefficient = 1.0f;
            public float YCoefficient = 1.0f;
            public bool WrapHorizontally = false;
            public bool WrapVertically = false;
            public bool SameEffectAsPreviousLayer = false;
            public Effect Effect = new Effect();
            public int BlendCoefficient = 0;
            public int[] RGBCoefficient = new int[3] { 255, 255, 255 };
        }

        public class Shader
        {
            public int Handle = 0;
            public ShaderParameter[] Parameters = new ShaderParameter[0];
        }

        public class ShaderParameter
        {
            public string Name = string.Empty;
            public int Type = 0;
            public int Value = 0;
            public float FloatValue = 0.0f;
        }

        public class ObjectInstance
        {
            public int Handle = 0;
            public InstancePosition Position = new InstancePosition();
            public InstanceValues Values = new InstanceValues();
            public int Layer = 0;
            public bool Locked = false;
            public bool CreateOnly = false;
        }

        public class InstancePosition
        {
            public int X = 0;
            public int Y = 0;
        }

        public class InstanceValues
        {
            public int InstanceValue = 0;
        }

        public class ObjectInfo
        {
            public ObjectDisplayOptions DisplayOptions = new ObjectDisplayOptions();
            public ObjectSize Size = new ObjectSize();
            public ObjectTextOptions TextOptions = new ObjectTextOptions();
            public ObjectMovement Movements = new ObjectMovement();
            public ObjectRuntimeOptions RuntimeOptions = new ObjectRuntimeOptions();
            public ObjectValues Values = new ObjectValues();
            public ObjectEvents Events = new ObjectEvents();
            public ObjectAbout About = new ObjectAbout();

            public QuickBackdropData? QuickBackdropData = null;
            public BackdropData? BackdropData = null;
            public ActiveData? ActiveData = null;
            public StringData? StringData = null;
            public QNAData? QuestionAndAnswerData = null;
            public ScoreData? ScoreData = null;
            public LivesData? LivesData = null;
            public CounterData? CounterData = null;
            public FormattedTextData? FormattedTextData = null;
            public SubAppData? SubApplicationData = null;
            public ExtensionData? ExtensionData = null;
        }

        public class ObjectDisplayOptions
        {
            public bool VisibleAtStart = true;
            public bool DisplayAsBackground = false;
            public bool SaveBackground = true;
            public bool WipeWithColor = false;
            public int[] WipeColor = new int[3] { 255, 255, 255 };
            public bool Transparent = true;
            public Effect Effect = new Effect();
            public int BlendCoefficient = 0;
            public int[] RGBCoefficient = new int[3] { 255, 255, 255 };
            public bool AntiAliasing = false;
            public Transition FadeIn = new Transition();
            public Transition FadeOut = new Transition();
        }

        public class ObjectSize
        {
            public int Width = 32;
            public int Height = 32;
        }

        public class ObjectTextOptions
        {
            public int Font = 0;
            public bool Bold = false;
            public bool Italic = false;
            public bool Underline = false;
            public bool Strikeout = false;
            public int[] Color = new int[3] { 0, 0, 0 };
            public HorizontalAllignment HorizontalAllignment = HorizontalAllignment.Left;
            public VerticalAllignment VerticalAllignment = VerticalAllignment.Top;
            public bool RightToLeftReading = false;
        }

        public class ObjectMovement
        {
            public int Type = 0;
        }

        public class ObjectRuntimeOptions
        {
            public bool DontIncludeAtBuildTime { get; set; }
            public bool CreateAtStart { get; set; }
            public bool CreateBeforeFrameTransition { get; set; }
            public bool FollowTheFrame { get; set; }
            public bool DestroyObjectIfTooFar { get; set; }
            public int InactivateIfTooFar { get; set; }
            public bool UseFineDetection { get; set; }
            public int ObstacleType { get; set; }
            public bool CollisionWithBox { get; set; }
            public bool LoadOnCall { get; set; }
            public bool GlobalObject { get; set; }
            public int EditorSynchronization { get; set; }
            public bool AutomaticRotations { get; set; }
            public bool DoNotResetFrameDuration { get; set; }
        }

        public class ObjectValues
        {
            public Alterablevalue[] AlterableValues { get; set; }
            public Alterablestring[] AlterableStrings { get; set; }
            public Alterableflag[] AlterableFlags { get; set; }
        }

        public class Alterablevalue
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }

        public class Alterablestring
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class Alterableflag
        {
            public string Name { get; set; }
            public bool Value { get; set; }
        }

        public class ObjectEvents
        {
            public int[] Qualifiers { get; set; }
        }

        public class ObjectAbout
        {
            public string Name { get; set; }
            public bool AutoUpdate { get; set; }
        }

        public class QuickBackdropData
        {
            public int Shape { get; set; }
            public int[] BorderColor { get; set; }
            public int BorderWidth { get; set; }
            public int FillType { get; set; }
            public int[] FillColor1 { get; set; }
            public int[] FillColor2 { get; set; }
            public bool VerticalGradient { get; set; }
            public int Motif { get; set; }
            public bool IntegralDimensions { get; set; }
        }

        public class BackdropData
        {
            public int Image { get; set; }
        }

        public class ActiveData
        {
            public Animation[] Animations { get; set; }
        }

        public class Animation
        {
            public string Name { get; set; }
            public Direction[] Directions { get; set; }
        }

        public class Direction
        {
            public int Index { get; set; }
            public int MinimumSpeed { get; set; }
            public int MaximumSpeed { get; set; }
            public int Repeat { get; set; }
            public int RepeatFrame { get; set; }
            public int[] Frames { get; set; }
        }

        public class StringData
        {
            public string[] Paragraphs { get; set; }
        }

        public class QNAData
        {
            public Question Question { get; set; }
            public Answers Answers { get; set; }
        }

        public class Question
        {
            public string Paragraph { get; set; }
            public int Font { get; set; }
            public int[] Color { get; set; }
            public bool Relief { get; set; }
        }

        public class Answers
        {
            public Paragraph[] Paragraphs { get; set; }
            public int Font { get; set; }
            public int[] Color { get; set; }
            public bool Relief { get; set; }
        }

        public class Paragraph
        {
            public string Text { get; set; }
            public bool IsCorrect { get; set; }
        }

        public class ScoreData
        {
            public int Player { get; set; }
            public int Type { get; set; }
            public bool UseFixedDigitCount { get; set; }
            public int FixedNumberOfDigits { get; set; }
            public int[] Images { get; set; }
        }

        public class LivesData
        {
            public int Player { get; set; }
            public int Type { get; set; }
            public bool UseFixedDigitCount { get; set; }
            public int FixedNumberOfDigits { get; set; }
            public int[] Images { get; set; }
        }

        public class CounterData
        {
            public int InitialValue { get; set; }
            public int MinimumValue { get; set; }
            public int MaximumValue { get; set; }
            public bool UseFixedDigitCount { get; set; }
            public int FixedNumberOfDigits { get; set; }
            public bool UseSignificantDigitCount { get; set; }
            public int NumberOfSignificantDigits { get; set; }
            public bool UseDecimalDigitCount { get; set; }
            public int NumberOfDigitsAfterDecimalPoint { get; set; }
            public bool AddZerosToTheLeft { get; set; }
            public int Type { get; set; }
            public int[] Images { get; set; }
            public int Count { get; set; }
            public int FillType { get; set; }
            public int[] FillColor1 { get; set; }
            public int[] FillColor2 { get; set; }
            public bool VerticalGradient { get; set; }
        }

        public class FormattedTextData
        {
            public int[] BackgroundColor { get; set; }
            public bool AutoVerticalScrollbar { get; set; }
        }

        public class SubAppData
        {
            public int Source { get; set; }
            public string Filename { get; set; }
            public int FrameNumber { get; set; }
            public bool ShareGlobalValues { get; set; }
            public bool ShareLives { get; set; }
            public bool ShareScores { get; set; }
            public bool SharePlayerControls { get; set; }
            public int WindowIcon { get; set; }
            public bool CustomizableSize { get; set; }
            public bool StretchFrameToObjectSize { get; set; }
            public bool DisplayAsSprite { get; set; }
            public bool IgnoreParentsResizeDisplay { get; set; }
            public bool PopupWindow { get; set; }
            public bool ClipSiblings { get; set; }
            public bool Border { get; set; }
            public bool Resizable { get; set; }
            public bool Caption { get; set; }
            public bool ToolCaption { get; set; }
            public bool SystemMenu { get; set; }
            public bool DisableClose { get; set; }
            public bool HiddenOnClose { get; set; }
            public bool Modal { get; set; }
        }

        public class ExtensionData
        {
            public int Type { get; set; }
            public string Name { get; set; }
            public string FileName { get; set; }
            public int Magic { get; set; }
            public string SubType { get; set; }
            public int Version { get; set; }
            public int ID { get; set; }
            public int Private { get; set; }
            public int[] Data { get; set; }
        }

        public enum GraphicMode
        {
            C256,
            C32768,
            C65536,
            C16Mil
        }

        public enum BuildType
        {
            WindowsEXE,
            WindowsScreenSaver,
            SubApplication,
            JavaSubApplication,
            JavaApplication,
            JavaInternetApplet,
            JavaWebStart,
            JavaForMobileDevices,
            JavaMacApplication = 9,
            AdobeFlash,
            JavaForBlackberry,
            AndroidOUYAApplication,
            iOSApplication,
            iOSXCodeProject,
            FinaliOSXCodeProject,
            MacApplication = 17,
            XNAWindowsProject,
            XNAXboxProject,
            XNAPhoneProject,
            HTML5Development = 27,
            HTML5FinalProject,
            MacApplicationFile = 30,
            MacXCodeProject,
            UWPProject = 33,
            AndroidAppBundle,
            NintendoSwitch = 74,
            XboxOne,
            Playstation = 78
        }

        public enum CompressionLevel
        {
            Normal,
            Maximum
        }

        public enum DisplayMode
        {
            Standard,
            Direct3D9,
            Direct3D8,
            Direct3D11
        }

        public enum CharacterInputEncoding
        {
            ANSI,
            UTF8
        }

        public enum CharacterOutputEncoding
        {
            ANSI,
            UTF8,
            UTF8WithoutByteOrder,
            Unicode,
            UnicodeBigEndian
        }

        public enum PlayerControl
        {
            Joystick1,
            Joystick2,
            Joystick3,
            Joystick4,
            Keyboard
        }

        public enum EventOrder
        {
            FrameGlobalBehaviors,
            FrameBehaviorsGlobal,
            GlobalFrameBehaviors,
            GlobalBehaviorsFrame,
            BehaviorsFrameGlobal,
            BehaviorsGlobalFrame
        }

        public enum Language
        {
            Afrikaans,
            Albanian,
            ArabicAlgeria,
            ArabicBahrain,
            ArabicEgypt,
            ArabicIrad,
            ArabicJordan,
            ArabicKuwait,
            ArabicLebanon,
            ArabicLibyra,
            ArabicMorocco,
            ArabicOman,
            ArabicQatar,
            ArabicSaudiArabia,
            ArabicSyria,
            ArabicTunisia,
            ArabicUnitedArabEmirates,
            ArabicYemen,
            Armenian,
            AzerbaijaniCryllic,
            AzerbaijaniLatin,
            Basque,
            Belarusian,
            Bulgarian,
            Catalan,
            ChineseSimplifiedChina,
            ChineseSimplifiedSingapore,
            ChineseTraditionalHongKong,
            ChineseTraditionalMacao,
            ChineseTraditionalTaiwan,
            Croatian,
            Czech,
            Danish,
            Divehi,
            DutchBelgium,
            DutchNetherlands,
            EnglishAustralia,
            EnglishBelize,
            EnglishCanada,
            EnglishCaribbean,
            EnglishIreland,
            EnglishJamaica,
            EnglishNewZealand,
            EnglishPhilippines,
            EnglishSouthAfrica,
            EnglishTrinidadAndTobago,
            EnglishUnitedKingdom,
            EnglishUnitedStates,
            EnglishZimbabwe,
            Estonian,
            Faroese,
            Finnish,
            FrenchBelgium,
            FrenchCanada,
            FrenchFrance,
            FrenchLuxembourg,
            FrenchMonaco,
            FrenchSwitzerland,
            Galician,
            Georgian,
            GermanAustria,
            GermanGermany,
            GermanLiechtenstein,
            GermanLuxembourg,
            GermanSwitzerland,
            Greek,
            Gujarati,
            Hebrew,
            Hindi,
            Hungarian,
            Icelandic,
            Indonesian,
            ItalianItaly,
            ItalianSwitzerland,
            Japanese,
            Kannada,
            Kazakh,
            Kiswahili,
            Konkani,
            Korean,
            Kyrgyz,
            LanguageNeutral,
            Latvian,
            Lithuanian,
            Macedonian,
            MelayBrunei,
            MelayMalaysia,
            Marathi,
            Mongolian,
            NorwegianBokmål,
            NorwegianNynorsk,
            Persian,
            Polish,
            PortugueseBrazil,
            PortugueseProtugal,
            Punjabi,
            Romanian,
            Russian,
            Sanskrit,
            SerbianCyrillic,
            SerbianLatin,
            Slovak,
            Slovenian,
            SpanishArgentina,
            SpanishBolivia,
            SpanishChile,
            SpanishColombia,
            SpanishCostaRica,
            SpanishDominicanRepublic,
            SpanishEcuador,
            SpanishGuatemala,
            SpanishHonduras,
            SpanishMexico,
            SpanishNicaragua,
            SpanishPanama,
            SpanishParaguay,
            SpanishPeru,
            SpanishPeurtoRico,
            SpanishSpainInternational,
            SpanishSpainTraditional,
            SpanishUruguay,
            SpanishVenezuela,
            SwedishFinland,
            SwedishSweden,
            Syriac,
            Tamil,
            Tatar,
            Telugu,
            Thai,
            Turkish,
            Ukrainian,
            UzbekCyrillic,
            UzbekLatin,
            Vietnamese
        }
        
        public enum View
        {
            No,
            BeforeEndPage,
            WhileEndPageIsDisplayed,
            WhenInstallerExits,
            ViewButtonOnEndPage
        }

        public enum Run
        {
            No,
            BeforeEndPage,
            WhileEndPageIsDisplayed,
            WhenInstallerExits,
            LaunchCheckboxOnEndPage
        }

        public enum InstallDirectory
        {
            DestinationDirectory,
            WindowsDirectory,
            SystemDirectory,
            FontsDirectory,
            DesktopDirectory,
            MyDocumentsDirectory,
            ApplicationDataDirectory,
            Other
        }

        public enum ExecutionLevel
        {
            None,
            AsInvoker,
            AsAdministrator
        }

        public enum ForceLoadOnCall
        {
            No,
            YesForce,
            YesIgnore
        }

        public enum HorizontalAllignment
        {
            Left,
            Center,
            Right
        }

        public enum VerticalAllignment
        {
            Top,
            Center,
            Bottom
        }

        public enum InactivateIfTooFar
        {
            No,
            Yes,
            Automatic
        }

        public enum ObstacleType
        {
            None,
            Obstacle,
            Platform,
            Ladder
        }

        public enum EditorSynchronization
        {
            No,
            IndenticalObjects,
            SameNameAndType
        }

        public enum BackdropShape
        {
            Line,
            Rectangle,
            Ellipse
        }

        public enum BackdropFillType
        {
            None,
            SolidColor,
            Gradient,
            Motif
        }

        public enum ScoreType
        {
            Numbers,
            Text
        }

        public enum LivesType
        {
            Image,
            Numbers,
            Text
        }

        public enum CounterType
        {
            Hidden,
            Numbers,
            VerticalBar,
            HorizontalBar,
            Animation,
            Text
        }

        public enum CounterVerticalCount
        {
            Up,
            Down
        }

        public enum CounterHorizontalCount
        {
            FromLeft,
            FromRight
        }

        public enum CounterFillType
        {
            SolidColor,
            Gradient
        }

        public enum SubApplicationSource
        {
            OtherApplication,
            FrameFromThisApplication
        }
    }
}
