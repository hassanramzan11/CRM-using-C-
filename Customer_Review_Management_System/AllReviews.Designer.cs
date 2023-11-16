namespace Customer_Review_Management_System
{
	partial class AllReviews
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
			this.review_grid = new System.Windows.Forms.DataGridView();
			this.review_grid1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.review_grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.review_grid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(16, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Reviews";
			// 
			// review_grid
			// 
			this.review_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.review_grid.Location = new System.Drawing.Point(23, 69);
			this.review_grid.Name = "review_grid";
			this.review_grid.RowHeadersWidth = 51;
			this.review_grid.RowTemplate.Height = 24;
			this.review_grid.Size = new System.Drawing.Size(727, 394);
			this.review_grid.TabIndex = 2;
			this.review_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// review_grid1
			// 
			this.review_grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.review_grid1.Location = new System.Drawing.Point(748, 69);
			this.review_grid1.Name = "review_grid1";
			this.review_grid1.RowHeadersWidth = 51;
			this.review_grid1.RowTemplate.Height = 24;
			this.review_grid1.Size = new System.Drawing.Size(316, 394);
			this.review_grid1.TabIndex = 3;
			this.review_grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(23, 486);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(99, 45);
			this.button1.TabIndex = 4;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// AllReviews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.review_grid1);
			this.Controls.Add(this.review_grid);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AllReviews";
			this.Text = "AllReviews";
			this.Load += new System.EventHandler(this.AllReviews_Load);
			((System.ComponentModel.ISupportInitialize)(this.review_grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.review_grid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView review_grid;
		private System.Windows.Forms.DataGridView review_grid1;
		private System.Windows.Forms.Button button1;
	}
}