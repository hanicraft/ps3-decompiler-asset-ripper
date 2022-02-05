using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace UMD_Ripper
{
	[OptionText]
	public class frm_presentacion : Form
	{
		private static List<WeakReference> __ENCList;

		private string directorio;

		private double tamaño;

		private double cuenta;

		private double cuenta_ripeado;

		private double cuenta_archivos;

		private double numero_directorios;

		private double cuenta_directorio;

		private float cuenta_videos;

		private float cuenta_musica;

		private float cuenta_dummys;

		private float cuenta_demos;

		private FileInfo[] Archivos_ripear;

		private DirectoryInfo[] directorios_ripear;

		private string categoria;

		private string carpeta;

		private double tamañoCarpetaIdioma;

		[AccessedThroughProperty("btn_rip")]
		private Button _btn_rip;

		[AccessedThroughProperty("txt_original")]
		private Label _txt_original;

		[AccessedThroughProperty("grupo_tamaño")]
		private GroupBox _grupo_tamaño;

		[AccessedThroughProperty("btn_marcar")]
		private Button _btn_marcar;

		[AccessedThroughProperty("Lista_demos")]
		private CheckedListBox _Lista_demos;

		[AccessedThroughProperty("Lista_idiomas")]
		private CheckedListBox _Lista_idiomas;

		[AccessedThroughProperty("btn_desmarcar")]
		private Button _btn_desmarcar;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[AccessedThroughProperty("PIESPITEXT")]
		private Label _PIESPITEXT;

		[AccessedThroughProperty("picJuego")]
		private PictureBox _picJuego;

		[AccessedThroughProperty("btn_videos")]
		private Label _btn_videos;

		[AccessedThroughProperty("btn_musica")]
		private Label _btn_musica;

		[AccessedThroughProperty("btn_demos")]
		private Label _btn_demos;

		[AccessedThroughProperty("btn_dummys")]
		private Label _btn_dummys;

		[AccessedThroughProperty("btn_idiomas")]
		private Label _btn_idiomas;

		[AccessedThroughProperty("txt_ripeada2")]
		private Label _txt_ripeada2;

		[AccessedThroughProperty("txt_original2")]
		private Label _txt_original2;

		[AccessedThroughProperty("grupo_tamaño2")]
		private GroupBox _grupo_tamaño2;

		[AccessedThroughProperty("lbl_seccion")]
		private Label _lbl_seccion;

		[AccessedThroughProperty("btn_abrir")]
		private PictureBox _btn_abrir;

		[AccessedThroughProperty("btn_acercade")]
		private PictureBox _btn_acercade;

		[AccessedThroughProperty("txt_ripeada")]
		private Label _txt_ripeada;

		private IContainer components;

		[AccessedThroughProperty("Abrir_Directorio")]
		private FolderBrowserDialog _Abrir_Directorio;

		[AccessedThroughProperty("panel_lista")]
		private Panel _panel_lista;

		[AccessedThroughProperty("Lista_sonidos")]
		private CheckedListBox _Lista_sonidos;

		[AccessedThroughProperty("Lista_videos")]
		private CheckedListBox _Lista_videos;

		[AccessedThroughProperty("Lista_dummys")]
		private CheckedListBox _Lista_dummys;

		internal virtual FolderBrowserDialog Abrir_Directorio
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Abrir_Directorio;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Abrir_Directorio = value;
			}
		}

		internal virtual PictureBox btn_abrir
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_abrir;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_abrir_Click);
				if (this._btn_abrir != null)
				{
					this._btn_abrir.Click -= eventHandler;
				}
				this._btn_abrir = value;
				if (this._btn_abrir != null)
				{
					this._btn_abrir.Click += eventHandler;
				}
			}
		}

		internal virtual PictureBox btn_acercade
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_acercade;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_acercade_Click);
				if (this._btn_acercade != null)
				{
					this._btn_acercade.Click -= eventHandler;
				}
				this._btn_acercade = value;
				if (this._btn_acercade != null)
				{
					this._btn_acercade.Click += eventHandler;
				}
			}
		}

		internal virtual Label btn_demos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_demos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_demos_Click);
				frm_presentacion frmPresentacion1 = this;
				EventHandler eventHandler1 = new EventHandler(frmPresentacion1.btn_demos_Click);
				if (this._btn_demos != null)
				{
					this._btn_demos.Click -= eventHandler;
					this._btn_demos.MouseEnter -= eventHandler1;
				}
				this._btn_demos = value;
				if (this._btn_demos != null)
				{
					this._btn_demos.Click += eventHandler;
					this._btn_demos.MouseEnter += eventHandler1;
				}
			}
		}

		internal virtual Button btn_desmarcar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_desmarcar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_desmarcar_Click);
				if (this._btn_desmarcar != null)
				{
					this._btn_desmarcar.Click -= eventHandler;
				}
				this._btn_desmarcar = value;
				if (this._btn_desmarcar != null)
				{
					this._btn_desmarcar.Click += eventHandler;
				}
			}
		}

		internal virtual Label btn_dummys
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_dummys;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_dummys_MouseEnter1);
				frm_presentacion frmPresentacion1 = this;
				EventHandler eventHandler1 = new EventHandler(frmPresentacion1.btn_dummys_MouseEnter1);
				if (this._btn_dummys != null)
				{
					this._btn_dummys.Click -= eventHandler;
					this._btn_dummys.MouseEnter -= eventHandler1;
				}
				this._btn_dummys = value;
				if (this._btn_dummys != null)
				{
					this._btn_dummys.Click += eventHandler;
					this._btn_dummys.MouseEnter += eventHandler1;
				}
			}
		}

		internal virtual Label btn_idiomas
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_idiomas;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_idiomas_MouseEnter1);
				frm_presentacion frmPresentacion1 = this;
				EventHandler eventHandler1 = new EventHandler(frmPresentacion1.btn_idiomas_MouseEnter1);
				if (this._btn_idiomas != null)
				{
					this._btn_idiomas.Click -= eventHandler;
					this._btn_idiomas.MouseEnter -= eventHandler1;
				}
				this._btn_idiomas = value;
				if (this._btn_idiomas != null)
				{
					this._btn_idiomas.Click += eventHandler;
					this._btn_idiomas.MouseEnter += eventHandler1;
				}
			}
		}

		internal virtual Button btn_marcar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_marcar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_marcar_Click);
				if (this._btn_marcar != null)
				{
					this._btn_marcar.Click -= eventHandler;
				}
				this._btn_marcar = value;
				if (this._btn_marcar != null)
				{
					this._btn_marcar.Click += eventHandler;
				}
			}
		}

		internal virtual Label btn_musica
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_musica;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_musica_Click);
				frm_presentacion frmPresentacion1 = this;
				EventHandler eventHandler1 = new EventHandler(frmPresentacion1.btn_musica_Click);
				if (this._btn_musica != null)
				{
					this._btn_musica.Click -= eventHandler;
					this._btn_musica.MouseEnter -= eventHandler1;
				}
				this._btn_musica = value;
				if (this._btn_musica != null)
				{
					this._btn_musica.Click += eventHandler;
					this._btn_musica.MouseEnter += eventHandler1;
				}
			}
		}

		internal virtual Button btn_rip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_rip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_rip_Click);
				if (this._btn_rip != null)
				{
					this._btn_rip.Click -= eventHandler;
				}
				this._btn_rip = value;
				if (this._btn_rip != null)
				{
					this._btn_rip.Click += eventHandler;
				}
			}
		}

		internal virtual Label btn_videos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_videos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				EventHandler eventHandler = new EventHandler(frmPresentacion.btn_videos_Click);
				frm_presentacion frmPresentacion1 = this;
				EventHandler eventHandler1 = new EventHandler(frmPresentacion1.btn_videos_Click);
				if (this._btn_videos != null)
				{
					this._btn_videos.Click -= eventHandler;
					this._btn_videos.MouseEnter -= eventHandler1;
				}
				this._btn_videos = value;
				if (this._btn_videos != null)
				{
					this._btn_videos.Click += eventHandler;
					this._btn_videos.MouseEnter += eventHandler1;
				}
			}
		}

		internal virtual GroupBox grupo_tamaño
		{
			[DebuggerNonUserCode]
			get
			{
				return this._grupo_tamaño;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._grupo_tamaño = value;
			}
		}

		internal virtual GroupBox grupo_tamaño2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._grupo_tamaño2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._grupo_tamaño2 = value;
			}
		}

		internal virtual Label lbl_seccion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_seccion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_seccion = value;
			}
		}

		internal virtual CheckedListBox Lista_demos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lista_demos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				ItemCheckEventHandler itemCheckEventHandler = new ItemCheckEventHandler(frmPresentacion.Lista_demos_ItemCheck);
				if (this._Lista_demos != null)
				{
					this._Lista_demos.ItemCheck -= itemCheckEventHandler;
				}
				this._Lista_demos = value;
				if (this._Lista_demos != null)
				{
					this._Lista_demos.ItemCheck += itemCheckEventHandler;
				}
			}
		}

		internal virtual CheckedListBox Lista_dummys
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lista_dummys;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				ItemCheckEventHandler itemCheckEventHandler = new ItemCheckEventHandler(frmPresentacion.Lista_dummys_ItemCheck);
				if (this._Lista_dummys != null)
				{
					this._Lista_dummys.ItemCheck -= itemCheckEventHandler;
				}
				this._Lista_dummys = value;
				if (this._Lista_dummys != null)
				{
					this._Lista_dummys.ItemCheck += itemCheckEventHandler;
				}
			}
		}

		internal virtual CheckedListBox Lista_idiomas
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lista_idiomas;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				ItemCheckEventHandler itemCheckEventHandler = new ItemCheckEventHandler(frmPresentacion.Lista_idiomas_ItemCheck);
				if (this._Lista_idiomas != null)
				{
					this._Lista_idiomas.ItemCheck -= itemCheckEventHandler;
				}
				this._Lista_idiomas = value;
				if (this._Lista_idiomas != null)
				{
					this._Lista_idiomas.ItemCheck += itemCheckEventHandler;
				}
			}
		}

		internal virtual CheckedListBox Lista_sonidos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lista_sonidos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				ItemCheckEventHandler itemCheckEventHandler = new ItemCheckEventHandler(frmPresentacion.Lista_sonidos_ItemCheck);
				if (this._Lista_sonidos != null)
				{
					this._Lista_sonidos.ItemCheck -= itemCheckEventHandler;
				}
				this._Lista_sonidos = value;
				if (this._Lista_sonidos != null)
				{
					this._Lista_sonidos.ItemCheck += itemCheckEventHandler;
				}
			}
		}

		internal virtual CheckedListBox Lista_videos
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lista_videos;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frm_presentacion frmPresentacion = this;
				ItemCheckEventHandler itemCheckEventHandler = new ItemCheckEventHandler(frmPresentacion.Lista_videos_ItemCheck);
				if (this._Lista_videos != null)
				{
					this._Lista_videos.ItemCheck -= itemCheckEventHandler;
				}
				this._Lista_videos = value;
				if (this._Lista_videos != null)
				{
					this._Lista_videos.ItemCheck += itemCheckEventHandler;
				}
			}
		}

		internal virtual Panel panel_lista
		{
			[DebuggerNonUserCode]
			get
			{
				return this._panel_lista;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._panel_lista = value;
			}
		}

		internal virtual PictureBox picJuego
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picJuego;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._picJuego = value;
			}
		}

		internal virtual Label PIESPITEXT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PIESPITEXT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PIESPITEXT = value;
			}
		}

		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		internal virtual Label txt_original
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_original;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_original = value;
			}
		}

		internal virtual Label txt_original2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_original2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_original2 = value;
			}
		}

		internal virtual Label txt_ripeada
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ripeada;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_ripeada = value;
			}
		}

		internal virtual Label txt_ripeada2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ripeada2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_ripeada2 = value;
			}
		}

		[DebuggerNonUserCode]
		static frm_presentacion()
		{
			frm_presentacion.__ENCList = new List<WeakReference>();
		}

		public frm_presentacion()
		{
			frm_presentacion.__ENCAddToList(this);
			this.Archivos_ripear = new FileInfo[1001];
			this.directorios_ripear = new DirectoryInfo[101];
			this.carpeta = Application.StartupPath;
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = frm_presentacion.__ENCList;
			Monitor.Enter(_ENCList);
			try
			{
				if (frm_presentacion.__ENCList.Count == frm_presentacion.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frm_presentacion.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frm_presentacion.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frm_presentacion.__ENCList[item] = frm_presentacion.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frm_presentacion.__ENCList.RemoveRange(item, checked(frm_presentacion.__ENCList.Count - item));
					frm_presentacion.__ENCList.Capacity = frm_presentacion.__ENCList.Count;
				}
				frm_presentacion.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
			finally
			{
				Monitor.Exit(_ENCList);
			}
		}

		private void btn_abrir_Click(object sender, EventArgs e)
		{
			try
			{
				this.Abrir_Directorio.SelectedPath = "D:\\Archivos de programa\\JDownloader\\downloads\\MotoGP 09\\10\\BLES-00756";
				this.Abrir_Directorio.Description = Idiomas.descripcionAbrir;
				this.Abrir_Directorio.ShowDialog();
				this.directorio = this.Abrir_Directorio.SelectedPath;
				if (Operators.CompareString(this.directorio, "", true) != 0)
				{
					this.Lista_dummys.Items.Clear();
					this.Lista_demos.Items.Clear();
					this.Lista_idiomas.Items.Clear();
					this.Lista_videos.Items.Clear();
					this.Lista_sonidos.Items.Clear();
					if (Directory.Exists(string.Concat(this.directorio, "\\PS3_UPDATE\\")))
					{
						Directory.Delete(string.Concat(this.directorio, "\\PS3_UPDATE\\"), true);
						MessageBox.Show(Idiomas.Actudetectada, "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					if (File.Exists(string.Concat(this.directorio, "\\PS3_GAME\\ICON0.PNG")))
					{
						this.picJuego.ImageLocation = string.Concat(this.directorio, "\\PS3_GAME\\ICON0.PNG");
						this.picJuego.Visible = true;
					}
					this.cuenta = 0;
					this.Busca_Archivos(this.directorio, true);
					this.lbl_seccion.Visible = true;
					this.lbl_seccion.Text = Idiomas.seccion;
					this.cuenta_ripeado = this.cuenta;
					this.txt_original.Text = string.Concat(Idiomas.Original, " ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta))), " MB");
					this.txt_original2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta))), " GB");
					this.txt_ripeada.Text = string.Concat(Idiomas.Ripeada, "  ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta_ripeado))), " MB");
					this.txt_ripeada2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta))), " GB");
					this.panel_lista.Show();
					this.btn_dummys.Show();
					this.btn_musica.Show();
					this.btn_videos.Show();
					this.btn_demos.Show();
					this.txt_original.Show();
					this.txt_original2.Show();
					this.txt_ripeada.Show();
					this.txt_ripeada2.Show();
					this.btn_rip.Show();
					this.btn_idiomas.Show();
					this.grupo_tamaño.Show();
					this.grupo_tamaño2.Show();
					this.btn_marcar.Show();
					this.btn_desmarcar.Show();
				}
				else
				{
					MessageBox.Show(Idiomas.Cancelado, Idiomas.Cancelado, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (IOException oException)
			{
				ProjectData.SetProjectError(oException);
				MessageBox.Show(Idiomas.MensajeError, "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			catch (InvalidCastException invalidCastException)
			{
				ProjectData.SetProjectError(invalidCastException);
				MessageBox.Show("Error en el calculo de tamaño, este puede salir ilegible", "Error de calculo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show("Error desconocido en la aplicacion, porfavor contacta y hazme saber el error, asi ganamos todos", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
		}

		private void btn_acercade_Click(object sender, EventArgs e)
		{
			(new frm_acercade()).ShowDialog();
		}

		private void btn_demos_Click(object sender, EventArgs e)
		{
			this.categoria = "Demo";
			this.Lista_videos.Hide();
			this.Lista_sonidos.Hide();
			this.Lista_dummys.Hide();
			this.Lista_demos.Show();
			this.Lista_idiomas.Hide();
			this.lbl_seccion.Text = Idiomas.DEMOS;
		}

		private void btn_desmarcar_Click(object sender, EventArgs e)
		{
			int i;
			if (Operators.CompareString(this.categoria, "Video", true) == 0)
			{
				int count = checked(this.Lista_videos.Items.Count - 1);
				for (i = 0; i <= count; i = checked(i + 1))
				{
					this.Lista_videos.SetSelected(i, true);
					this.Lista_videos.SetItemChecked(i, false);
				}
			}
			if (Operators.CompareString(this.categoria, "Musica", true) == 0)
			{
				int num = checked(this.Lista_sonidos.Items.Count - 1);
				for (i = 0; i <= num; i = checked(i + 1))
				{
					this.Lista_sonidos.SetSelected(i, true);
					this.Lista_sonidos.SetItemChecked(i, false);
				}
			}
			if (Operators.CompareString(this.categoria, "Dummy", true) == 0)
			{
				int count1 = checked(this.Lista_dummys.Items.Count - 1);
				for (i = 0; i <= count1; i = checked(i + 1))
				{
					this.Lista_dummys.SetSelected(i, true);
					this.Lista_dummys.SetItemChecked(i, false);
				}
			}
			if (Operators.CompareString(this.categoria, "Demo", true) == 0)
			{
				int num1 = checked(this.Lista_demos.Items.Count - 1);
				for (i = 0; i <= num1; i = checked(i + 1))
				{
					this.Lista_demos.SetSelected(i, true);
					this.Lista_demos.SetItemChecked(i, false);
				}
			}
			if (Operators.CompareString(this.categoria, "Idioma", true) == 0)
			{
				int count2 = checked(this.Lista_idiomas.Items.Count - 1);
				for (i = 0; i <= count2; i = checked(i + 1))
				{
					this.Lista_idiomas.SetSelected(i, true);
					this.Lista_idiomas.SetItemChecked(i, false);
				}
			}
		}

		private void btn_dummys_MouseEnter1(object sender, EventArgs e)
		{
			this.lbl_seccion.Text = "DUMMYS";
			this.categoria = "Dummy";
			this.Lista_videos.Hide();
			this.Lista_sonidos.Hide();
			this.Lista_dummys.Show();
			this.Lista_demos.Hide();
			this.Lista_idiomas.Hide();
			this.lbl_seccion.Text = Idiomas.DUMMYS;
		}

		private void btn_idiomas_MouseEnter1(object sender, EventArgs e)
		{
			this.categoria = "Idioma";
			this.Lista_videos.Hide();
			this.Lista_sonidos.Hide();
			this.Lista_dummys.Hide();
			this.Lista_demos.Hide();
			this.Lista_idiomas.Show();
			this.lbl_seccion.Text = Idiomas.Cad_IDIOMA;
		}

		private void btn_marcar_Click(object sender, EventArgs e)
		{
			int i;
			if (Operators.CompareString(this.categoria, "Video", true) == 0)
			{
				int count = checked(this.Lista_videos.Items.Count - 1);
				for (i = 0; i <= count; i = checked(i + 1))
				{
					this.Lista_videos.SetSelected(i, true);
					this.Lista_videos.SetItemChecked(i, true);
				}
			}
			if (Operators.CompareString(this.categoria, "Musica", true) == 0)
			{
				int num = checked(this.Lista_sonidos.Items.Count - 1);
				for (i = 0; i <= num; i = checked(i + 1))
				{
					this.Lista_sonidos.SetSelected(i, true);
					this.Lista_sonidos.SetItemChecked(i, true);
				}
			}
			if (Operators.CompareString(this.categoria, "Dummy", true) == 0)
			{
				int count1 = checked(this.Lista_dummys.Items.Count - 1);
				for (i = 0; i <= count1; i = checked(i + 1))
				{
					this.Lista_dummys.SetSelected(i, true);
					this.Lista_dummys.SetItemChecked(i, true);
				}
			}
			if (Operators.CompareString(this.categoria, "Demo", true) == 0)
			{
				int num1 = checked(this.Lista_demos.Items.Count - 1);
				for (i = 0; i <= num1; i = checked(i + 1))
				{
					this.Lista_demos.SetSelected(i, true);
					this.Lista_demos.SetItemChecked(i, true);
				}
			}
			if (Operators.CompareString(this.categoria, "Idioma", true) == 0)
			{
				int count2 = checked(this.Lista_idiomas.Items.Count - 1);
				for (i = 0; i <= count2; i = checked(i + 1))
				{
					this.Lista_idiomas.SetSelected(i, true);
					this.Lista_idiomas.SetItemChecked(i, true);
				}
			}
		}

		private void btn_musica_Click(object sender, EventArgs e)
		{
			this.categoria = "Musica";
			this.Lista_videos.Hide();
			this.Lista_sonidos.Show();
			this.Lista_dummys.Hide();
			this.Lista_demos.Hide();
			this.Lista_idiomas.Hide();
			this.lbl_seccion.Text = Idiomas.MUSICA;
		}

		private void btn_rip_Click(object sender, EventArgs e)
		{
			string str;
			int i;
			int num;
			try
			{
				int count = checked(this.Lista_videos.Items.Count - 1);
				for (i = 0; i <= count; i = checked(i + 1))
				{
					if (this.Lista_videos.GetItemChecked(i))
					{
						str = Conversions.ToString(this.Lista_videos.Items[i]);
						str = Strings.Trim(str.Substring(0, 80));
						int length = checked((int)this.Archivos_ripear.Length);
						num = 0;
						while (num <= length)
						{
							if (Operators.CompareString(this.Archivos_ripear[num].Name, str, true) != 0)
							{
								num = checked(num + 1);
							}
							else
							{
								this.copiar_archivo_modo_3(this.Archivos_ripear[num], "VIDEO");
								break;
							}
						}
					}
				}
				int count1 = checked(this.Lista_sonidos.Items.Count - 1);
				for (i = 0; i <= count1; i = checked(i + 1))
				{
					if (this.Lista_sonidos.GetItemChecked(i))
					{
						str = Conversions.ToString(this.Lista_sonidos.Items[i]);
						str = Strings.Trim(str.Substring(0, 80));
						int length1 = checked((int)this.Archivos_ripear.Length);
						num = 0;
						while (num <= length1)
						{
							if (Operators.CompareString(this.Archivos_ripear[num].Name, str, true) != 0)
							{
								num = checked(num + 1);
							}
							else
							{
								this.copiar_archivo_modo_3(this.Archivos_ripear[num], "MUSICA");
								break;
							}
						}
					}
				}
				int num1 = checked(this.Lista_dummys.Items.Count - 1);
				for (i = 0; i <= num1; i = checked(i + 1))
				{
					if (this.Lista_dummys.GetItemChecked(i))
					{
						str = Conversions.ToString(this.Lista_dummys.Items[i]);
						str = Strings.Trim(str.Substring(0, 80));
						int length2 = checked((int)this.Archivos_ripear.Length);
						num = 0;
						while (num <= length2)
						{
							if (Operators.CompareString(this.Archivos_ripear[num].Name, str, true) != 0)
							{
								num = checked(num + 1);
							}
							else
							{
								this.copiar_archivo_modo_3(this.Archivos_ripear[num], "OTROS");
								break;
							}
						}
					}
				}
				int count2 = checked(this.Lista_idiomas.Items.Count - 1);
				for (i = 0; i <= count2; i = checked(i + 1))
				{
					if (this.Lista_idiomas.GetItemChecked(i))
					{
						str = Conversions.ToString(this.Lista_idiomas.Items[i]);
						str = Strings.Trim(str.Substring(0, 80));
						int num2 = checked((int)this.Archivos_ripear.Length);
						num = 0;
						while (num <= num2)
						{
							if (this.Archivos_ripear[num] == null)
							{
								break;
							}
							else if (Operators.CompareString(this.Archivos_ripear[num].Name, str, true) != 0)
							{
								num = checked(num + 1);
							}
							else
							{
								this.copiar_archivo_modo_3(this.Archivos_ripear[num], "OTROS");
								break;
							}
						}
					}
				}
				int count3 = checked(this.Lista_idiomas.Items.Count - 1);
				for (i = 0; i <= count3; i = checked(i + 1))
				{
					if (this.Lista_idiomas.GetItemChecked(i))
					{
						str = Conversions.ToString(this.Lista_idiomas.Items[i]);
						str = Strings.Trim(str.Substring(0, 80));
						int length3 = checked((int)this.directorios_ripear.Length);
						num = 0;
						while (num <= length3)
						{
							if (Operators.CompareString(this.directorios_ripear[num].Name, str, true) != 0)
							{
								num = checked(num + 1);
							}
							else
							{
								Directory.Delete(this.directorios_ripear[num].FullName, true);
								break;
							}
						}
					}
				}
				MessageBox.Show(Idiomas.MensajeOK, "PS3 Game Ripper", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (IOException oException1)
			{
				ProjectData.SetProjectError(oException1);
				IOException oException = oException1;
				MessageBox.Show(oException.Message.ToString(), "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			catch (InvalidCastException invalidCastException1)
			{
				ProjectData.SetProjectError(invalidCastException1);
				InvalidCastException invalidCastException = invalidCastException1;
				MessageBox.Show(invalidCastException.Message.ToString(), "Error de calculo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ProjectData.ClearProjectError();
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				MessageBox.Show(exception.Message.ToString(), "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
		}

		private void btn_videos_Click(object sender, EventArgs e)
		{
			this.categoria = "Video";
			this.Lista_videos.Show();
			this.Lista_sonidos.Hide();
			this.Lista_dummys.Hide();
			this.Lista_demos.Hide();
			this.Lista_idiomas.Hide();
			this.lbl_seccion.Text = Idiomas.VIDEO;
		}

		public void Busca_Archivos(string sourceDir, bool fRecursive)
		{
			try
			{
				if (fRecursive)
				{
					string[] directories = Directory.GetDirectories(sourceDir);
					for (int i = 0; i < checked((int)directories.Length); i = checked(i + 1))
					{
						string str = directories[i];
						this.Busca_Archivos((new DirectoryInfo(str)).FullName, fRecursive);
					}
				}
				string[] files = Directory.GetFiles(sourceDir);
				for (int j = 0; j < checked((int)files.Length); j = checked(j + 1))
				{
					FileInfo fileInfo = new FileInfo(files[j]);
					if (Operators.CompareString(fileInfo.Extension, ".M2TS", true) == 0 | Operators.CompareString(fileInfo.Extension, ".m2ts", true) == 0 | Operators.CompareString(fileInfo.Extension, ".MTS", true) == 0 | Operators.CompareString(fileInfo.Extension, ".mts", true) == 0 | Operators.CompareString(fileInfo.Extension, ".M2V", true) == 0 | Operators.CompareString(fileInfo.Extension, ".m2v", true) == 0 | Operators.CompareString(fileInfo.Extension, ".BIK", true) == 0 | Operators.CompareString(fileInfo.Extension, ".bik", true) == 0 | Operators.CompareString(fileInfo.Extension, ".PAM", true) == 0 | Operators.CompareString(fileInfo.Extension, ".pam", true) == 0)
					{
						this.tamaño = (double)fileInfo.Length;
						this.cuenta += (double)fileInfo.Length;
						if (fileInfo.Length > (long)50000)
						{
							this.Lista_videos.Items.Add(string.Concat(this.mete_espacios(fileInfo.Name, Conversions.ToDouble(this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))))), this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))), " MB"));
						}
						this.Archivos_ripear[checked((int)Math.Round(this.cuenta_archivos))] = fileInfo;
						this.cuenta_archivos += 1;
					}
					else if (Operators.CompareString(fileInfo.Extension, ".AT3", true) == 0 | Operators.CompareString(fileInfo.Extension, ".at3", true) == 0 | Operators.CompareString(fileInfo.Extension, ".aud", true) == 0 | Operators.CompareString(fileInfo.Extension, ".AUD", true) == 0)
					{
						this.tamaño = (double)fileInfo.Length;
						this.cuenta += (double)fileInfo.Length;
						if (fileInfo.Length > (long)50000)
						{
							this.Lista_sonidos.Items.Add(string.Concat(this.mete_espacios(fileInfo.Name, Conversions.ToDouble(this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))))), this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))), " MB"));
						}
						this.Archivos_ripear[checked((int)Math.Round(this.cuenta_archivos))] = fileInfo;
						this.cuenta_archivos += 1;
					}
					else if (Operators.CompareString(fileInfo.Extension, ".PAD", true) == 0 | Operators.CompareString(fileInfo.Extension, ".pad", true) == 0)
					{
						this.tamaño = (double)fileInfo.Length;
						this.cuenta += (double)fileInfo.Length;
						if (fileInfo.Length > (long)50000)
						{
							this.Lista_dummys.Items.Add(string.Concat(this.mete_espacios(fileInfo.Name, Conversions.ToDouble(this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))))), this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))), " MB"));
						}
						this.Archivos_ripear[checked((int)Math.Round(this.cuenta_archivos))] = fileInfo;
						this.cuenta_archivos += 1;
					}
					else if (Operators.CompareString(fileInfo.Directory.Name, "english", true) == 0 | Operators.CompareString(fileInfo.Directory.Name, "french", true) == 0 | Operators.CompareString(fileInfo.Directory.Name, "german", true) == 0 | Operators.CompareString(fileInfo.Directory.Name, "italian", true) == 0 | Operators.CompareString(fileInfo.Directory.Name, "spanish", true) == 0)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(fileInfo.Directory.FullName);
						this.Lista_idiomas.Items.Add(string.Concat(this.mete_espacios(fileInfo.Directory.Name, Conversions.ToDouble(this.ConvertBytesToMB(this.GetFolderSize(fileInfo.Directory.FullName, true)))), this.ConvertBytesToMB(this.GetFolderSize(fileInfo.Directory.FullName, true)), " MB"));
						this.directorios_ripear[checked((int)Math.Round(this.numero_directorios))] = directoryInfo;
						this.numero_directorios += 1;
						fileInfo = null;
						directoryInfo = null;
						break;
					}
					else if (!(Operators.CompareString(fileInfo.Extension, ".PSARC", true) == 0 | Operators.CompareString(fileInfo.Extension, ".psarc", true) == 0 | Operators.CompareString(fileInfo.Extension, ".ita", true) == 0 | fileInfo.Name.ToString().Contains("ita") | fileInfo.Name.ToString().Contains("_ita") | fileInfo.Name.ToString().Contains("ita_") | Operators.CompareString(fileInfo.Extension, ".fra", true) == 0 | fileInfo.Name.ToString().Contains("fra") | fileInfo.Name.ToString().Contains("_fra") | fileInfo.Name.ToString().Contains("fra_") | Operators.CompareString(fileInfo.Extension, ".eng", true) == 0 | fileInfo.Name.ToString().Contains("eng") | fileInfo.Name.ToString().Contains("_eng") | fileInfo.Name.ToString().Contains("eng_") | Operators.CompareString(fileInfo.Extension, ".spa", true) == 0 | fileInfo.Name.ToString().Contains("_spa") | fileInfo.Name.ToString().Contains("spa") | fileInfo.Name.ToString().Contains("spa_") | Operators.CompareString(fileInfo.Extension, ".jpn", true) == 0 | fileInfo.Name.ToString().Contains("jpn") | fileInfo.Name.ToString().Contains("_jpn") | fileInfo.Name.ToString().Contains("jpn_") | Operators.CompareString(fileInfo.Extension, ".deu", true) == 0 | fileInfo.Name.ToString().Contains("deu") | fileInfo.Name.ToString().Contains("_deu") | fileInfo.Name.ToString().Contains("deu_")))
					{
						this.cuenta += (double)fileInfo.Length;
					}
					else
					{
						this.tamaño = (double)fileInfo.Length;
						this.cuenta += (double)fileInfo.Length;
						if (fileInfo.Length > (long)50000)
						{
							this.Lista_idiomas.Items.Add(string.Concat(this.mete_espacios(fileInfo.Name, Conversions.ToDouble(this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))))), this.ConvertBytesToMB(checked((long)Math.Round(this.tamaño))), " MB"));
						}
						this.Archivos_ripear[checked((int)Math.Round(this.cuenta_archivos))] = fileInfo;
						this.cuenta_archivos += 1;
					}
					fileInfo = null;
				}
			}
			catch (IOException oException)
			{
				ProjectData.SetProjectError(oException);
				MessageBox.Show("Error al intentar ripear la ISO, intentelo de nuevo, si el error persiste, reinstale la aplicacion", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			catch (InvalidCastException invalidCastException)
			{
				ProjectData.SetProjectError(invalidCastException);
				MessageBox.Show("Error en el calculo de tamaño, este puede salir ilegible", "Error de calculo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show(Idiomas.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
		}

		private string ConvertBytesToGB(long bytes)
		{
			return ((double)bytes / 1073741824).ToString("N");
		}

		private string ConvertBytesToMB(long bytes)
		{
			return ((double)bytes / 1048576).ToString("N");
		}

		private void copiar_archivo_modo_2(FileInfo archivo)
		{
			try
			{
				File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx2.lnd"), archivo.FullName, true);
			}
			catch (IOException oException)
			{
				ProjectData.SetProjectError(oException);
				MessageBox.Show("Error al intentar ripear la ISO, intentelo de nuevo, si el error persiste, reinstale la aplicacion", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show(Idiomas.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
		}

		private void copiar_archivo_modo_3(FileInfo archivo, string llamante)
		{
			try
			{
				if (Operators.CompareString(llamante, "VIDEO", true) != 0)
				{
					if (Operators.CompareString(llamante, "MUSICA", true) != 0)
					{
						File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx2.lnd"), archivo.FullName, true);
					}
					else
					{
						File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx3s.lnd"), archivo.FullName, true);
					}
				}
				else if (Operators.CompareString(archivo.Extension, ".M2V", true) == 0 | Operators.CompareString(archivo.Extension, ".m2v", true) == 0)
				{
					File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx3v2.lnd"), archivo.FullName, true);
				}
				else if (Operators.CompareString(archivo.Extension, ".BIK", true) == 0 | Operators.CompareString(archivo.Extension, ".bik", true) == 0)
				{
					File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx3v3.lnd"), archivo.FullName, true);
				}
				else if (!(Operators.CompareString(archivo.Extension, ".PAM", true) == 0 | Operators.CompareString(archivo.Extension, ".pam", true) == 0))
				{
					File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx3v.lnd"), archivo.FullName, true);
				}
				else
				{
					File.Copy(string.Concat(Application.StartupPath, "\\Data\\tlx4v.lnd"), archivo.FullName, true);
				}
			}
			catch (IOException oException)
			{
				ProjectData.SetProjectError(oException);
				MessageBox.Show("Error al intentar ripear la ISO, intentelo de nuevo, si el error persiste, reinstale la aplicacion", "Error de E/S", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show(Idiomas.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.components != null)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		public long GetFolderSize(string DirPath, bool includeSubFolders)
		{
			long num = 0L;
			FileInfo[] fileInfoArray;
			try
			{
				long length = (long)0;
				DirectoryInfo directoryInfo = new DirectoryInfo(DirPath);
				fileInfoArray = (!includeSubFolders ? directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly) : directoryInfo.GetFiles("*", SearchOption.AllDirectories));
				IEnumerator enumerator = fileInfoArray.GetEnumerator();
				while (enumerator.MoveNext())
				{
					length = checked(length + ((FileInfo)enumerator.Current).Length);
				}
				num = length;
				return num;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show(exception.Message);
				ProjectData.ClearProjectError();
			}
			return num;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frm_presentacion));
			this.Abrir_Directorio = new FolderBrowserDialog();
			this.panel_lista = new Panel();
			this.Lista_videos = new CheckedListBox();
			this.Lista_sonidos = new CheckedListBox();
			this.Lista_dummys = new CheckedListBox();
			this.Lista_demos = new CheckedListBox();
			this.Lista_idiomas = new CheckedListBox();
			this.btn_rip = new Button();
			this.txt_original = new Label();
			this.txt_ripeada = new Label();
			this.grupo_tamaño = new GroupBox();
			this.txt_original2 = new Label();
			this.btn_marcar = new Button();
			this.btn_desmarcar = new Button();
			this.ToolTip1 = new ToolTip(this.components);
			this.PIESPITEXT = new Label();
			this.picJuego = new PictureBox();
			this.btn_videos = new Label();
			this.btn_musica = new Label();
			this.btn_demos = new Label();
			this.btn_dummys = new Label();
			this.btn_idiomas = new Label();
			this.txt_ripeada2 = new Label();
			this.grupo_tamaño2 = new GroupBox();
			this.lbl_seccion = new Label();
			this.btn_abrir = new PictureBox();
			this.btn_acercade = new PictureBox();
			this.panel_lista.SuspendLayout();
			this.grupo_tamaño.SuspendLayout();
			((ISupportInitialize)this.picJuego).BeginInit();
			this.grupo_tamaño2.SuspendLayout();
			((ISupportInitialize)this.btn_abrir).BeginInit();
			((ISupportInitialize)this.btn_acercade).BeginInit();
			this.SuspendLayout();
			this.Abrir_Directorio.RootFolder = Environment.SpecialFolder.MyComputer;
			this.Abrir_Directorio.ShowNewFolderButton = false;
			this.panel_lista.Controls.Add(this.Lista_videos);
			this.panel_lista.Controls.Add(this.Lista_sonidos);
			this.panel_lista.Controls.Add(this.Lista_dummys);
			this.panel_lista.Controls.Add(this.Lista_demos);
			this.panel_lista.Controls.Add(this.Lista_idiomas);
			this.panel_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Panel panelLista = this.panel_lista;
			Point point = new Point(377, 157);
			panelLista.Location = point;
			this.panel_lista.Name = "panel_lista";
			Panel panel = this.panel_lista;
			System.Drawing.Size size = new System.Drawing.Size(426, 210);
			panel.Size = size;
			this.panel_lista.TabIndex = 0;
			this.panel_lista.Visible = false;
			this.Lista_videos.CheckOnClick = true;
			this.Lista_videos.Dock = DockStyle.Fill;
			this.Lista_videos.FormattingEnabled = true;
			CheckedListBox listaVideos = this.Lista_videos;
			point = new Point(0, 0);
			listaVideos.Location = point;
			this.Lista_videos.Name = "Lista_videos";
			CheckedListBox checkedListBox = this.Lista_videos;
			size = new System.Drawing.Size(426, 210);
			checkedListBox.Size = size;
			this.Lista_videos.TabIndex = 0;
			this.Lista_videos.Visible = false;
			this.Lista_sonidos.CheckOnClick = true;
			this.Lista_sonidos.Dock = DockStyle.Fill;
			this.Lista_sonidos.FormattingEnabled = true;
			CheckedListBox listaSonidos = this.Lista_sonidos;
			point = new Point(0, 0);
			listaSonidos.Location = point;
			this.Lista_sonidos.Name = "Lista_sonidos";
			CheckedListBox listaSonidos1 = this.Lista_sonidos;
			size = new System.Drawing.Size(426, 210);
			listaSonidos1.Size = size;
			this.Lista_sonidos.TabIndex = 1;
			this.Lista_sonidos.Visible = false;
			this.Lista_dummys.CheckOnClick = true;
			this.Lista_dummys.Dock = DockStyle.Fill;
			this.Lista_dummys.FormattingEnabled = true;
			CheckedListBox listaDummys = this.Lista_dummys;
			point = new Point(0, 0);
			listaDummys.Location = point;
			this.Lista_dummys.Name = "Lista_dummys";
			CheckedListBox listaDummys1 = this.Lista_dummys;
			size = new System.Drawing.Size(426, 210);
			listaDummys1.Size = size;
			this.Lista_dummys.TabIndex = 0;
			this.Lista_demos.CheckOnClick = true;
			this.Lista_demos.Dock = DockStyle.Fill;
			this.Lista_demos.FormattingEnabled = true;
			CheckedListBox listaDemos = this.Lista_demos;
			point = new Point(0, 0);
			listaDemos.Location = point;
			this.Lista_demos.Name = "Lista_demos";
			CheckedListBox listaDemos1 = this.Lista_demos;
			size = new System.Drawing.Size(426, 210);
			listaDemos1.Size = size;
			this.Lista_demos.TabIndex = 2;
			this.Lista_demos.Visible = false;
			this.Lista_idiomas.CheckOnClick = true;
			this.Lista_idiomas.Dock = DockStyle.Fill;
			this.Lista_idiomas.FormattingEnabled = true;
			CheckedListBox listaIdiomas = this.Lista_idiomas;
			point = new Point(0, 0);
			listaIdiomas.Location = point;
			this.Lista_idiomas.Name = "Lista_idiomas";
			CheckedListBox listaIdiomas1 = this.Lista_idiomas;
			size = new System.Drawing.Size(426, 210);
			listaIdiomas1.Size = size;
			this.Lista_idiomas.TabIndex = 3;
			this.Lista_idiomas.Visible = false;
			this.btn_rip.BackColor = Color.Black;
			this.btn_rip.Font = new System.Drawing.Font("Comic Sans MS", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btn_rip.ForeColor = Color.White;
			this.btn_rip.Image = (Image)componentResourceManager.GetObject("btn_rip.Image");
			this.btn_rip.ImageAlign = ContentAlignment.MiddleLeft;
			Button btnRip = this.btn_rip;
			point = new Point(286, 385);
			btnRip.Location = point;
			this.btn_rip.Name = "btn_rip";
			Button button = this.btn_rip;
			size = new System.Drawing.Size(288, 37);
			button.Size = size;
			this.btn_rip.TabIndex = 8;
			this.btn_rip.Text = "         RIPEAR  ";
			this.btn_rip.TextAlign = ContentAlignment.MiddleRight;
			this.btn_rip.UseVisualStyleBackColor = false;
			this.btn_rip.Visible = false;
			this.txt_original.BackColor = Color.Transparent;
			this.txt_original.BorderStyle = BorderStyle.FixedSingle;
			this.txt_original.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.txt_original.ForeColor = Color.White;
			Label txtOriginal = this.txt_original;
			point = new Point(26, 16);
			txtOriginal.Location = point;
			this.txt_original.Name = "txt_original";
			Label label = this.txt_original;
			size = new System.Drawing.Size(152, 18);
			label.Size = size;
			this.txt_original.TabIndex = 14;
			this.txt_original.Text = "ORIGINAL:   xxx ";
			this.txt_original.TextAlign = ContentAlignment.MiddleCenter;
			this.txt_original.Visible = false;
			this.txt_ripeada.BackColor = Color.Transparent;
			this.txt_ripeada.BorderStyle = BorderStyle.FixedSingle;
			this.txt_ripeada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.txt_ripeada.ForeColor = Color.White;
			Label txtRipeada = this.txt_ripeada;
			point = new Point(25, 17);
			txtRipeada.Location = point;
			this.txt_ripeada.Name = "txt_ripeada";
			Label txtRipeada1 = this.txt_ripeada;
			size = new System.Drawing.Size(152, 18);
			txtRipeada1.Size = size;
			this.txt_ripeada.TabIndex = 16;
			this.txt_ripeada.Text = "RIPEADA:   xxx";
			this.txt_ripeada.TextAlign = ContentAlignment.MiddleCenter;
			this.txt_ripeada.Visible = false;
			this.grupo_tamaño.BackColor = Color.Transparent;
			this.grupo_tamaño.Controls.Add(this.txt_original2);
			this.grupo_tamaño.Controls.Add(this.txt_original);
			this.grupo_tamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.grupo_tamaño.ForeColor = SystemColors.InactiveCaptionText;
			GroupBox grupoTamaño = this.grupo_tamaño;
			point = new Point(24, 47);
			grupoTamaño.Location = point;
			this.grupo_tamaño.Name = "grupo_tamaño";
			GroupBox groupBox = this.grupo_tamaño;
			size = new System.Drawing.Size(205, 75);
			groupBox.Size = size;
			this.grupo_tamaño.TabIndex = 17;
			this.grupo_tamaño.TabStop = false;
			this.grupo_tamaño.Visible = false;
			this.txt_original2.BackColor = Color.Transparent;
			this.txt_original2.BorderStyle = BorderStyle.FixedSingle;
			this.txt_original2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.txt_original2.ForeColor = Color.White;
			Label txtOriginal2 = this.txt_original2;
			point = new Point(70, 45);
			txtOriginal2.Location = point;
			this.txt_original2.Name = "txt_original2";
			Label txtOriginal21 = this.txt_original2;
			size = new System.Drawing.Size(64, 18);
			txtOriginal21.Size = size;
			this.txt_original2.TabIndex = 17;
			this.txt_original2.TextAlign = ContentAlignment.MiddleCenter;
			this.txt_original2.Visible = false;
			this.btn_marcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btn_marcar.Image = (Image)componentResourceManager.GetObject("btn_marcar.Image");
			this.btn_marcar.ImageAlign = ContentAlignment.MiddleLeft;
			Button btnMarcar = this.btn_marcar;
			point = new Point(617, 130);
			btnMarcar.Location = point;
			this.btn_marcar.Name = "btn_marcar";
			Button btnMarcar1 = this.btn_marcar;
			size = new System.Drawing.Size(90, 21);
			btnMarcar1.Size = size;
			this.btn_marcar.TabIndex = 18;
			this.btn_marcar.Text = "Marcar Todo ";
			this.btn_marcar.TextAlign = ContentAlignment.MiddleRight;
			this.btn_marcar.Visible = false;
			this.btn_desmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btn_desmarcar.Image = (Image)componentResourceManager.GetObject("btn_desmarcar.Image");
			this.btn_desmarcar.ImageAlign = ContentAlignment.MiddleLeft;
			Button btnDesmarcar = this.btn_desmarcar;
			point = new Point(713, 130);
			btnDesmarcar.Location = point;
			this.btn_desmarcar.Name = "btn_desmarcar";
			Button btnDesmarcar1 = this.btn_desmarcar;
			size = new System.Drawing.Size(90, 21);
			btnDesmarcar1.Size = size;
			this.btn_desmarcar.TabIndex = 19;
			this.btn_desmarcar.Text = "Desm. Todo ";
			this.btn_desmarcar.TextAlign = ContentAlignment.MiddleRight;
			this.btn_desmarcar.Visible = false;
			this.ToolTip1.Active = false;
			this.PIESPITEXT.AutoSize = true;
			this.PIESPITEXT.BackColor = Color.Transparent;
			Label pIESPITEXT = this.PIESPITEXT;
			point = new Point(-2, 240);
			pIESPITEXT.Location = point;
			this.PIESPITEXT.Name = "PIESPITEXT";
			Label pIESPITEXT1 = this.PIESPITEXT;
			size = new System.Drawing.Size(0, 13);
			pIESPITEXT1.Size = size;
			this.PIESPITEXT.TabIndex = 22;
			this.picJuego.BackColor = Color.Transparent;
			this.picJuego.BorderStyle = BorderStyle.FixedSingle;
			PictureBox pictureBox = this.picJuego;
			point = new Point(24, 157);
			pictureBox.Location = point;
			this.picJuego.Name = "picJuego";
			PictureBox pictureBox1 = this.picJuego;
			size = new System.Drawing.Size(332, 210);
			pictureBox1.Size = size;
			this.picJuego.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picJuego.TabIndex = 24;
			this.picJuego.TabStop = false;
			this.picJuego.Visible = false;
			this.btn_videos.BackColor = Color.Transparent;
			this.btn_videos.Cursor = Cursors.Hand;
			Label btnVideos = this.btn_videos;
			point = new Point(400, 77);
			btnVideos.Location = point;
			this.btn_videos.Name = "btn_videos";
			Label btnVideos1 = this.btn_videos;
			size = new System.Drawing.Size(42, 29);
			btnVideos1.Size = size;
			this.btn_videos.TabIndex = 25;
			this.btn_videos.Visible = false;
			this.btn_musica.BackColor = Color.Transparent;
			this.btn_musica.Cursor = Cursors.Hand;
			Label btnMusica = this.btn_musica;
			point = new Point(334, 73);
			btnMusica.Location = point;
			this.btn_musica.Name = "btn_musica";
			Label btnMusica1 = this.btn_musica;
			size = new System.Drawing.Size(42, 33);
			btnMusica1.Size = size;
			this.btn_musica.TabIndex = 26;
			this.btn_musica.Visible = false;
			this.btn_demos.BackColor = Color.Transparent;
			this.btn_demos.Cursor = Cursors.Hand;
			Label btnDemos = this.btn_demos;
			point = new Point(265, 77);
			btnDemos.Location = point;
			this.btn_demos.Name = "btn_demos";
			Label btnDemos1 = this.btn_demos;
			size = new System.Drawing.Size(42, 29);
			btnDemos1.Size = size;
			this.btn_demos.TabIndex = 27;
			this.btn_demos.Visible = false;
			this.btn_dummys.BackColor = Color.Transparent;
			this.btn_dummys.Cursor = Cursors.Hand;
			Label btnDummys = this.btn_dummys;
			point = new Point(467, 77);
			btnDummys.Location = point;
			this.btn_dummys.Name = "btn_dummys";
			Label btnDummys1 = this.btn_dummys;
			size = new System.Drawing.Size(42, 29);
			btnDummys1.Size = size;
			this.btn_dummys.TabIndex = 28;
			this.btn_dummys.Visible = false;
			this.btn_idiomas.BackColor = Color.Transparent;
			this.btn_idiomas.Cursor = Cursors.Hand;
			Label btnIdiomas = this.btn_idiomas;
			point = new Point(532, 77);
			btnIdiomas.Location = point;
			this.btn_idiomas.Name = "btn_idiomas";
			Label btnIdiomas1 = this.btn_idiomas;
			size = new System.Drawing.Size(42, 29);
			btnIdiomas1.Size = size;
			this.btn_idiomas.TabIndex = 29;
			this.btn_idiomas.Visible = false;
			this.txt_ripeada2.BackColor = Color.Transparent;
			this.txt_ripeada2.BorderStyle = BorderStyle.FixedSingle;
			this.txt_ripeada2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.txt_ripeada2.ForeColor = Color.White;
			Label txtRipeada2 = this.txt_ripeada2;
			point = new Point(69, 45);
			txtRipeada2.Location = point;
			this.txt_ripeada2.Name = "txt_ripeada2";
			Label txtRipeada21 = this.txt_ripeada2;
			size = new System.Drawing.Size(64, 18);
			txtRipeada21.Size = size;
			this.txt_ripeada2.TabIndex = 18;
			this.txt_ripeada2.TextAlign = ContentAlignment.MiddleCenter;
			this.txt_ripeada2.Visible = false;
			this.grupo_tamaño2.BackColor = Color.Transparent;
			this.grupo_tamaño2.Controls.Add(this.txt_ripeada2);
			this.grupo_tamaño2.Controls.Add(this.txt_ripeada);
			this.grupo_tamaño2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.grupo_tamaño2.ForeColor = SystemColors.InactiveCaptionText;
			GroupBox grupoTamaño2 = this.grupo_tamaño2;
			point = new Point(601, 47);
			grupoTamaño2.Location = point;
			this.grupo_tamaño2.Name = "grupo_tamaño2";
			GroupBox grupoTamaño21 = this.grupo_tamaño2;
			size = new System.Drawing.Size(202, 75);
			grupoTamaño21.Size = size;
			this.grupo_tamaño2.TabIndex = 31;
			this.grupo_tamaño2.TabStop = false;
			this.grupo_tamaño2.Visible = false;
			this.lbl_seccion.BackColor = Color.Transparent;
			this.lbl_seccion.Font = new System.Drawing.Font("Comic Sans MS", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lbl_seccion.ForeColor = Color.White;
			Label lblSeccion = this.lbl_seccion;
			point = new Point(268, 116);
			lblSeccion.Location = point;
			this.lbl_seccion.Name = "lbl_seccion";
			Label lblSeccion1 = this.lbl_seccion;
			size = new System.Drawing.Size(306, 40);
			lblSeccion1.Size = size;
			this.lbl_seccion.TabIndex = 32;
			this.lbl_seccion.Text = "VIDEOS";
			this.lbl_seccion.TextAlign = ContentAlignment.MiddleCenter;
			this.lbl_seccion.Visible = false;
			this.btn_abrir.BackColor = Color.Transparent;
			this.btn_abrir.Cursor = Cursors.Hand;
			this.btn_abrir.Image = (Image)componentResourceManager.GetObject("btn_abrir.Image");
			PictureBox btnAbrir = this.btn_abrir;
			point = new Point(0, 373);
			btnAbrir.Location = point;
			this.btn_abrir.Name = "btn_abrir";
			PictureBox btnAbrir1 = this.btn_abrir;
			size = new System.Drawing.Size(64, 60);
			btnAbrir1.Size = size;
			this.btn_abrir.SizeMode = PictureBoxSizeMode.StretchImage;
			this.btn_abrir.TabIndex = 33;
			this.btn_abrir.TabStop = false;
			this.btn_acercade.BackColor = Color.Transparent;
			this.btn_acercade.Cursor = Cursors.Hand;
			this.btn_acercade.Image = (Image)componentResourceManager.GetObject("btn_acercade.Image");
			PictureBox btnAcercade = this.btn_acercade;
			point = new Point(782, 373);
			btnAcercade.Location = point;
			this.btn_acercade.Name = "btn_acercade";
			PictureBox btnAcercade1 = this.btn_acercade;
			size = new System.Drawing.Size(69, 68);
			btnAcercade1.Size = size;
			this.btn_acercade.SizeMode = PictureBoxSizeMode.StretchImage;
			this.btn_acercade.TabIndex = 34;
			this.btn_acercade.TabStop = false;
			this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = ImageLayout.None;
			size = new System.Drawing.Size(848, 434);
			this.ClientSize = size;
			this.Controls.Add(this.btn_acercade);
			this.Controls.Add(this.btn_abrir);
			this.Controls.Add(this.lbl_seccion);
			this.Controls.Add(this.grupo_tamaño2);
			this.Controls.Add(this.btn_idiomas);
			this.Controls.Add(this.btn_dummys);
			this.Controls.Add(this.btn_demos);
			this.Controls.Add(this.btn_musica);
			this.Controls.Add(this.btn_videos);
			this.Controls.Add(this.picJuego);
			this.Controls.Add(this.PIESPITEXT);
			this.Controls.Add(this.btn_desmarcar);
			this.Controls.Add(this.btn_marcar);
			this.Controls.Add(this.grupo_tamaño);
			this.Controls.Add(this.btn_rip);
			this.Controls.Add(this.panel_lista);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frm_presentacion";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = ".: PS3 GAME RIPPER v3.1";
			this.panel_lista.ResumeLayout(false);
			this.grupo_tamaño.ResumeLayout(false);
			((ISupportInitialize)this.picJuego).EndInit();
			this.grupo_tamaño2.ResumeLayout(false);
			((ISupportInitialize)this.btn_abrir).EndInit();
			((ISupportInitialize)this.btn_acercade).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Lista_demos_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string str = Conversions.ToString(this.Lista_demos.SelectedItem);
			string str1 = str.Substring(80);
			str1 = str1.Replace("MB", "  ");
			Strings.Trim(str1);
			if (this.Lista_demos.GetItemChecked(this.Lista_demos.SelectedIndex))
			{
				this.cuenta_ripeado += Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			else
			{
				this.cuenta_ripeado -= Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			this.txt_ripeada.Text = string.Concat(Idiomas.Ripeada, "  ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta_ripeado))), " MB");
			this.txt_ripeada2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta_ripeado))), " GB");
		}

		private void Lista_dummys_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string str = Conversions.ToString(this.Lista_dummys.SelectedItem);
			string str1 = str.Substring(80);
			str1 = str1.Replace("MB", "  ");
			Strings.Trim(str1);
			if (this.Lista_dummys.GetItemChecked(this.Lista_dummys.SelectedIndex))
			{
				this.cuenta_ripeado += Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			else
			{
				this.cuenta_ripeado -= Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			this.txt_ripeada.Text = string.Concat(Idiomas.Ripeada, "  ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta_ripeado))), " MB");
			this.txt_ripeada2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta_ripeado))), " GB");
		}

		private void Lista_idiomas_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string str = Conversions.ToString(this.Lista_idiomas.SelectedItem);
			string str1 = str.Substring(80);
			str1 = str1.Replace("MB", "  ");
			Strings.Trim(str1);
			if (this.Lista_idiomas.GetItemChecked(this.Lista_idiomas.SelectedIndex))
			{
				this.cuenta_ripeado += Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			else
			{
				this.cuenta_ripeado -= Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			this.txt_ripeada.Text = string.Concat(Idiomas.Ripeada, "  ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta_ripeado))), " MB");
			this.txt_ripeada2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta_ripeado))), " GB");
		}

		private void Lista_sonidos_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string str = Conversions.ToString(this.Lista_sonidos.SelectedItem);
			string str1 = str.Substring(80);
			str1 = str1.Replace("MB", "  ");
			Strings.Trim(str1);
			if (this.Lista_sonidos.GetItemChecked(this.Lista_sonidos.SelectedIndex))
			{
				this.cuenta_ripeado += Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			else
			{
				this.cuenta_ripeado -= Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			this.txt_ripeada.Text = string.Concat(Idiomas.Ripeada, "  ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta_ripeado))), " MB");
			this.txt_ripeada2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta_ripeado))), " GB");
		}

		private void Lista_videos_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string str = Conversions.ToString(this.Lista_videos.SelectedItem);
			string str1 = str.Substring(80);
			str1 = str1.Replace("MB", "  ");
			Strings.Trim(str1);
			if (this.Lista_videos.GetItemChecked(this.Lista_videos.SelectedIndex))
			{
				this.cuenta_ripeado += Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			else
			{
				this.cuenta_ripeado -= Conversions.ToDouble(Strings.Trim(Conversions.ToString(Conversions.ToDouble(str1) * 1048576)));
			}
			this.txt_ripeada.Text = string.Concat(Idiomas.Ripeada, "  ", this.ConvertBytesToMB(checked((long)Math.Round(this.cuenta_ripeado))), " MB");
			this.txt_ripeada2.Text = string.Concat(this.ConvertBytesToGB(checked((long)Math.Round(this.cuenta_ripeado))), " GB");
		}

		public string mete_espacios(string cadena, double tamanoCaracter)
		{
			string str;
			try
			{
				for (int i = cadena.Length; i <= 80; i = checked(i + 1))
				{
					cadena = string.Concat(cadena, " ");
				}
				str = cadena;
			}
			catch (InvalidCastException invalidCastException)
			{
				ProjectData.SetProjectError(invalidCastException);
				MessageBox.Show("Error de conversion interno, reinicie la aplicacion", "Error de calculo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				str = cadena;
				ProjectData.ClearProjectError();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show(Idiomas.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				str = cadena;
				ProjectData.ClearProjectError();
			}
			return str;
		}

		private void mnu_acercade_Click(object sender, EventArgs e)
		{
			try
			{
				(new frm_acercade()).ShowDialog();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				MessageBox.Show("Error desconocido en la aplicacion, porfavor contacta y hazme saber el error, asi ganamos todos", "Error desconocido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
		}

		private void tamaño_directorio(string directorio)
		{
			string[] directories = Directory.GetDirectories(directorio);
			for (int i = 0; i < checked((int)directories.Length); i = checked(i + 1))
			{
				directorio = directories[i];
				this.tamaño_directorio((new DirectoryInfo(directorio)).FullName);
				string[] files = Directory.GetFiles(directorio);
				for (int j = 0; j < checked((int)files.Length); j = checked(j + 1))
				{
					FileInfo fileInfo = new FileInfo(files[j]);
					this.cuenta_directorio += (double)fileInfo.Length;
				}
			}
		}
	}
}