namespace Wisej.AppWithSessionlessHandler
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBox1 = new Wisej.Web.ListBox();
            this.button1 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(45, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 349);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(586, 425);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.Disposed += new System.EventHandler(this.Page1_Disposed);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.ListBox listBox1;
		private Web.Button button1;
	}
}

