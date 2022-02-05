using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UMD_Ripper;

namespace UMD_Ripper.My
{
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[HideModuleName]
	internal static class MyProject
	{
		private readonly static MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider;

		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider;

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static Microsoft.VisualBasic.ApplicationServices.User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		[DebuggerNonUserCode]
		static MyProject()
		{
			MyProject.m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
			MyProject.m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
			MyProject.m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
			MyProject.m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
			MyProject.m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			public frm_acercade m_frm_acercade;

			public frm_presentacion m_frm_presentacion;

			public frmIdiomas m_frmIdiomas;

			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			public frm_acercade frm_acercade
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frm_acercade = MyProject.MyForms.Create__Instance__<frm_acercade>(this.m_frm_acercade);
					return this.m_frm_acercade;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frm_acercade)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frm_acercade>(ref this.m_frm_acercade);
					}
				}
			}

			public frm_presentacion frm_presentacion
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frm_presentacion = MyProject.MyForms.Create__Instance__<frm_presentacion>(this.m_frm_presentacion);
					return this.m_frm_presentacion;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frm_presentacion)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frm_presentacion>(ref this.m_frm_presentacion);
					}
				}
			}

			public frmIdiomas frmIdiomas
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmIdiomas = MyProject.MyForms.Create__Instance__<frmIdiomas>(this.m_frmIdiomas);
					return this.m_frmIdiomas;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmIdiomas)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmIdiomas>(ref this.m_frmIdiomas);
					}
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance)
			where T : Form, new()
			{
				T instance;
				if ((Instance == null || Instance.IsDisposed ? false : true))
				{
					instance = Instance;
				}
				else
				{
					if (MyProject.MyForms.m_FormBeingCreated == null)
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					else if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						try
						{
							instance = Activator.CreateInstance<T>();
						}
						catch (TargetInvocationException targetInvocationException) when (targetInvocationException.InnerException != null)
						{
							string[] message = new string[] { targetInvocationException.InnerException.Message };
							string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", message);
							throw new InvalidOperationException(resourceString, targetInvocationException.InnerException);
						}
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return this.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return this.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance)
			where T : new()
			{
				T t;
				t = (instance != null ? instance : Activator.CreateInstance<T>());
				return t;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return this.GetHashCode();
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return this.ToString();
			}
		}

		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T>
		where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}
	}
}