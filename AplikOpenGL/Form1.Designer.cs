namespace AplikOpenGL
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.glContr = new SharpGL.OpenGLCtrl();
			this.SuspendLayout();
			// 
			// glContr
			// 
			this.glContr.CausesValidation = false;
			this.glContr.DrawRenderTime = false;
			this.glContr.FrameRate = 20F;
			this.glContr.GDIEnabled = false;
			this.glContr.Location = new System.Drawing.Point(8, 8);
			this.glContr.Name = "glContr";
			this.glContr.Size = new System.Drawing.Size(500, 500);
			this.glContr.TabIndex = 0;
			this.glContr.OpenGLDraw += new System.Windows.Forms.PaintEventHandler(this.openGLControl1_OpenGLDraw);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 525);
			this.Controls.Add(this.glContr);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private SharpGL.OpenGLCtrl glContr;
	}
}

