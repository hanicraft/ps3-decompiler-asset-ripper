using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UMD_Ripper.My;

namespace UMD_Ripper
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		private static bool addedHandler;

		private static object addedHandlerLockObject;

		public static Settings Default
		{
			get
			{
				if (!Settings.addedHandler)
				{
					object obj = Settings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					Monitor.Enter(obj);
					try
					{
						if (!Settings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(Settings.AutoSaveSettings);
							Settings.addedHandler = true;
						}
					}
					finally
					{
						Monitor.Exit(obj);
					}
				}
				return Settings.defaultInstance;
			}
		}

		static Settings()
		{
			Settings.defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
			Settings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
		}

		[DebuggerNonUserCode]
		public Settings()
		{
		}

		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}