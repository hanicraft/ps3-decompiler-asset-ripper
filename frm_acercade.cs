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
	public class frm_acercade : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		[DebuggerNonUserCode]
		static frm_acercade()
		{
			frm_acercade.__ENCList = new List<WeakReference>();
		}

		public frm_acercade()
		{
			frm_acercade.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = frm_acercade.__ENCList;
			Monitor.Enter(_ENCList);
			try
			{
				if (frm_acercade.__ENCList.Count == frm_acercade.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frm_acercade.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frm_acercade.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frm_acercade.__ENCList[item] = frm_acercade.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frm_acercade.__ENCList.RemoveRange(item, checked(frm_acercade.__ENCList.Count - item));
					frm_acercade.__ENCList.Capacity = frm_acercade.__ENCList.Count;
				}
				frm_acercade.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
			finally
			{
				Monitor.Exit(_ENCList);
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frm_acercade));
			this.PictureBox1 = new PictureBox();
			this.Label1 = new Label();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.PictureBox1.BackColor = Color.Black;
			this.PictureBox1.Dock = DockStyle.Top;
			this.PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			PictureBox pictureBox1 = this.PictureBox1;
			Point point = new Point(0, 0);
			pictureBox1.Location = point;
			this.PictureBox1.Name = "PictureBox1";
			PictureBox pictureBox = this.PictureBox1;
			System.Drawing.Size size = new System.Drawing.Size(442, 135);
			pictureBox.Size = size;
			this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.Label1.BackColor = Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label1.ForeColor = SystemColors.ActiveCaption;
			Label label1 = this.Label1;
			point = new Point(-3, 140);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			size = new System.Drawing.Size(445, 47);
			label.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "";
			this.Label1.TextAlign = ContentAlignment.TopCenter;
			this.BackColor = SystemColors.InactiveCaptionText;
			size = new System.Drawing.Size(442, 160);
			this.ClientSize = size;
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frm_acercade";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Acerca de..";
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
		}
	}
}