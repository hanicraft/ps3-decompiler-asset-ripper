using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace UMD_Ripper
{
	[DesignerGenerated]
	public class frmIdiomas : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("picespana")]
		private PictureBox _picespana;

		[AccessedThroughProperty("picfrancia")]
		private PictureBox _picfrancia;

		[AccessedThroughProperty("picalemania")]
		private PictureBox _picalemania;

		[AccessedThroughProperty("picitalia")]
		private PictureBox _picitalia;

		[AccessedThroughProperty("picUSA")]
		private PictureBox _picUSA;

		internal virtual PictureBox picalemania
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picalemania;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmIdiomas frmIdioma = this;
				EventHandler eventHandler = new EventHandler(frmIdioma.picalemania_Click);
				if (this._picalemania != null)
				{
					this._picalemania.Click -= eventHandler;
				}
				this._picalemania = value;
				if (this._picalemania != null)
				{
					this._picalemania.Click += eventHandler;
				}
			}
		}

		internal virtual PictureBox picespana
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picespana;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmIdiomas frmIdioma = this;
				EventHandler eventHandler = new EventHandler(frmIdioma.picespana_Click);
				if (this._picespana != null)
				{
					this._picespana.Click -= eventHandler;
				}
				this._picespana = value;
				if (this._picespana != null)
				{
					this._picespana.Click += eventHandler;
				}
			}
		}

		internal virtual PictureBox picfrancia
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picfrancia;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmIdiomas frmIdioma = this;
				EventHandler eventHandler = new EventHandler(frmIdioma.picfrancia_Click);
				if (this._picfrancia != null)
				{
					this._picfrancia.Click -= eventHandler;
				}
				this._picfrancia = value;
				if (this._picfrancia != null)
				{
					this._picfrancia.Click += eventHandler;
				}
			}
		}

		internal virtual PictureBox picitalia
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picitalia;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmIdiomas frmIdioma = this;
				EventHandler eventHandler = new EventHandler(frmIdioma.picitalia_Click);
				if (this._picitalia != null)
				{
					this._picitalia.Click -= eventHandler;
				}
				this._picitalia = value;
				if (this._picitalia != null)
				{
					this._picitalia.Click += eventHandler;
				}
			}
		}

		internal virtual PictureBox picUSA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._picUSA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmIdiomas frmIdioma = this;
				EventHandler eventHandler = new EventHandler(frmIdioma.picUSA_Click);
				if (this._picUSA != null)
				{
					this._picUSA.Click -= eventHandler;
				}
				this._picUSA = value;
				if (this._picUSA != null)
				{
					this._picUSA.Click += eventHandler;
				}
			}
		}

		[DebuggerNonUserCode]
		static frmIdiomas()
		{
			frmIdiomas.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public frmIdiomas()
		{
			frmIdiomas frmIdioma = this;
			base.Load += new EventHandler(frmIdioma.frmIdiomas_Load);
			frmIdiomas.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = frmIdiomas.__ENCList;
			Monitor.Enter(_ENCList);
			try
			{
				if (frmIdiomas.__ENCList.Count == frmIdiomas.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmIdiomas.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmIdiomas.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmIdiomas.__ENCList[item] = frmIdiomas.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmIdiomas.__ENCList.RemoveRange(item, checked(frmIdiomas.__ENCList.Count - item));
					frmIdiomas.__ENCList.Capacity = frmIdiomas.__ENCList.Count;
				}
				frmIdiomas.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
			finally
			{
				Monitor.Exit(_ENCList);
			}
		}

		private void CierraVentana()
		{
			frm_presentacion frmPresentacion = new frm_presentacion();
			this.Hide();
			frmPresentacion.ShowDialog();
			this.Close();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((!disposing || this.components == null ? false : true))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private void frmIdiomas_Load(object sender, EventArgs e)
		{
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmIdiomas));
			this.picespana = new PictureBox();
			this.picfrancia = new PictureBox();
			this.picalemania = new PictureBox();
			this.picitalia = new PictureBox();
			this.picUSA = new PictureBox();
			((ISupportInitialize)this.picespana).BeginInit();
			((ISupportInitialize)this.picfrancia).BeginInit();
			((ISupportInitialize)this.picalemania).BeginInit();
			((ISupportInitialize)this.picitalia).BeginInit();
			((ISupportInitialize)this.picUSA).BeginInit();
			this.SuspendLayout();
			this.picespana.BackgroundImage = (Image)componentResourceManager.GetObject("picespana.BackgroundImage");
			this.picespana.BackgroundImageLayout = ImageLayout.Stretch;
			this.picespana.Cursor = Cursors.Hand;
			PictureBox pictureBox = this.picespana;
			Point point = new Point(12, 157);
			pictureBox.Location = point;
			this.picespana.Name = "picespana";
			PictureBox pictureBox1 = this.picespana;
			System.Drawing.Size size = new System.Drawing.Size(150, 90);
			pictureBox1.Size = size;
			this.picespana.TabIndex = 0;
			this.picespana.TabStop = false;
			this.picfrancia.BackgroundImage = (Image)componentResourceManager.GetObject("picfrancia.BackgroundImage");
			this.picfrancia.BackgroundImageLayout = ImageLayout.Stretch;
			this.picfrancia.Cursor = Cursors.Hand;
			PictureBox pictureBox2 = this.picfrancia;
			point = new Point(168, 157);
			pictureBox2.Location = point;
			this.picfrancia.Name = "picfrancia";
			PictureBox pictureBox3 = this.picfrancia;
			size = new System.Drawing.Size(150, 90);
			pictureBox3.Size = size;
			this.picfrancia.TabIndex = 1;
			this.picfrancia.TabStop = false;
			this.picalemania.BackgroundImage = (Image)componentResourceManager.GetObject("picalemania.BackgroundImage");
			this.picalemania.BackgroundImageLayout = ImageLayout.Stretch;
			this.picalemania.Cursor = Cursors.Hand;
			PictureBox pictureBox4 = this.picalemania;
			point = new Point(324, 157);
			pictureBox4.Location = point;
			this.picalemania.Name = "picalemania";
			PictureBox pictureBox5 = this.picalemania;
			size = new System.Drawing.Size(150, 90);
			pictureBox5.Size = size;
			this.picalemania.TabIndex = 2;
			this.picalemania.TabStop = false;
			this.picitalia.BackgroundImage = (Image)componentResourceManager.GetObject("picitalia.BackgroundImage");
			this.picitalia.BackgroundImageLayout = ImageLayout.Stretch;
			this.picitalia.Cursor = Cursors.Hand;
			PictureBox pictureBox6 = this.picitalia;
			point = new Point(480, 157);
			pictureBox6.Location = point;
			this.picitalia.Name = "picitalia";
			PictureBox pictureBox7 = this.picitalia;
			size = new System.Drawing.Size(150, 90);
			pictureBox7.Size = size;
			this.picitalia.TabIndex = 3;
			this.picitalia.TabStop = false;
			this.picUSA.BackgroundImage = (Image)componentResourceManager.GetObject("picUSA.BackgroundImage");
			this.picUSA.BackgroundImageLayout = ImageLayout.Stretch;
			this.picUSA.Cursor = Cursors.Hand;
			PictureBox pictureBox8 = this.picUSA;
			point = new Point(636, 157);
			pictureBox8.Location = point;
			this.picUSA.Name = "picUSA";
			PictureBox pictureBox9 = this.picUSA;
			size = new System.Drawing.Size(150, 90);
			pictureBox9.Size = size;
			this.picUSA.TabIndex = 4;
			this.picUSA.TabStop = false;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
			size = new System.Drawing.Size(793, 284);
			this.ClientSize = size;
			this.Controls.Add(this.picUSA);
			this.Controls.Add(this.picitalia);
			this.Controls.Add(this.picalemania);
			this.Controls.Add(this.picfrancia);
			this.Controls.Add(this.picespana);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "frmIdiomas";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = " PS3 GAME RIPPER v3.1 ";
			((ISupportInitialize)this.picespana).EndInit();
			((ISupportInitialize)this.picfrancia).EndInit();
			((ISupportInitialize)this.picalemania).EndInit();
			((ISupportInitialize)this.picitalia).EndInit();
			((ISupportInitialize)this.picUSA).EndInit();
			this.ResumeLayout(false);
		}

		private void picalemania_Click(object sender, EventArgs e)
		{
			Idiomas.CambiaIdioma("Aleman");
			this.CierraVentana();
		}

		private void picespana_Click(object sender, EventArgs e)
		{
			Idiomas.CambiaIdioma("Español");
			this.CierraVentana();
		}

		private void picfrancia_Click(object sender, EventArgs e)
		{
			Idiomas.CambiaIdioma("Frances");
			this.CierraVentana();
		}

		private void picitalia_Click(object sender, EventArgs e)
		{
			Idiomas.CambiaIdioma("Italiano");
			this.CierraVentana();
		}

		private void picUSA_Click(object sender, EventArgs e)
		{
			Idiomas.CambiaIdioma("Ingles");
			this.CierraVentana();
		}
	}
}