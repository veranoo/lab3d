namespace AplikOpenGL
{
	partial class Labirynt3D
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
            this.glContr.AutoSize = true;
            this.glContr.CausesValidation = false;
            this.glContr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glContr.DrawRenderTime = false;
            this.glContr.FrameRate = 20F;
            this.glContr.GDIEnabled = false;
            this.glContr.Location = new System.Drawing.Point(0, 0);
            this.glContr.Name = "glContr";
            this.glContr.Size = new System.Drawing.Size(520, 525);
            this.glContr.TabIndex = 0;
            this.glContr.OpenGLDraw += new System.Windows.Forms.PaintEventHandler(this.openGLControl1_OpenGLDraw);
            this.glContr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wcisniecie_klawisza);
            this.glContr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.opuszczenie_klawisza);
            // 
            // Labirynt3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 525);
            this.Controls.Add(this.glContr);
            this.Name = "Labirynt3D";
            this.Text = "Labirynt3D";
            this.Load += new System.EventHandler(this.Labirynt3D_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gl);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glContr_keyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private SharpGL.OpenGLCtrl glContr;
	}
}

