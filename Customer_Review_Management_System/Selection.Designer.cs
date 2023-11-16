namespace Customer_Review_Management_System
{
	partial class Selection
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
			this.label1 = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.dlt = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.bck = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select ";
			// 
			// add
			// 
			this.add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add.Location = new System.Drawing.Point(524, 80);
			this.add.Margin = new System.Windows.Forms.Padding(4);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(251, 58);
			this.add.TabIndex = 2;
			this.add.Text = "ADD REVIEW";
			this.add.UseVisualStyleBackColor = false;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// dlt
			// 
			this.dlt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dlt.Location = new System.Drawing.Point(524, 186);
			this.dlt.Margin = new System.Windows.Forms.Padding(4);
			this.dlt.Name = "dlt";
			this.dlt.Size = new System.Drawing.Size(251, 54);
			this.dlt.TabIndex = 3;
			this.dlt.Text = "DELETE REVIEW";
			this.dlt.UseVisualStyleBackColor = false;
			this.dlt.Click += new System.EventHandler(this.dlt_Click);
			// 
			// update
			// 
			this.update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(524, 300);
			this.update.Margin = new System.Windows.Forms.Padding(4);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(251, 53);
			this.update.TabIndex = 4;
			this.update.Text = "UPDATE REVIEW";
			this.update.UseVisualStyleBackColor = false;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// bck
			// 
			this.bck.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bck.Location = new System.Drawing.Point(913, 474);
			this.bck.Margin = new System.Windows.Forms.Padding(4);
			this.bck.Name = "bck";
			this.bck.Size = new System.Drawing.Size(88, 48);
			this.bck.TabIndex = 5;
			this.bck.Text = "Back";
			this.bck.UseVisualStyleBackColor = false;
			this.bck.Click += new System.EventHandler(this.bck_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(524, 395);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(251, 53);
			this.button1.TabIndex = 6;
			this.button1.Text = "GET ALL REVIEWS";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Selection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = global::Customer_Review_Management_System.Properties.Resources.selection;
			this.ClientSize = new System.Drawing.Size(1043, 544);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bck);
			this.Controls.Add(this.update);
			this.Controls.Add(this.dlt);
			this.Controls.Add(this.add);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1061, 591);
			this.MinimizeBox = false;
			this.Name = "Selection";
			this.Text = "Selection";
			this.Load += new System.EventHandler(this.Selection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button dlt;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button bck;
		private System.Windows.Forms.Button button1;
	}
}