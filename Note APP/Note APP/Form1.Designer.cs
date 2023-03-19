namespace Note_APP
{
	partial class Note
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
			this.lbltitle = new System.Windows.Forms.Label();
			this.lblmessage = new System.Windows.Forms.Label();
			this.txttitle = new System.Windows.Forms.TextBox();
			this.txtmessage = new System.Windows.Forms.TextBox();
			this.btnnew = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnread = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbltitle
			// 
			this.lbltitle.AutoSize = true;
			this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lbltitle.Location = new System.Drawing.Point(24, 82);
			this.lbltitle.Name = "lbltitle";
			this.lbltitle.Size = new System.Drawing.Size(35, 17);
			this.lbltitle.TabIndex = 0;
			this.lbltitle.Text = "Title";
			// 
			// lblmessage
			// 
			this.lblmessage.AutoSize = true;
			this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lblmessage.Location = new System.Drawing.Point(27, 145);
			this.lblmessage.Name = "lblmessage";
			this.lblmessage.Size = new System.Drawing.Size(65, 17);
			this.lblmessage.TabIndex = 1;
			this.lblmessage.Text = "Message";
			// 
			// txttitle
			// 
			this.txttitle.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txttitle.Location = new System.Drawing.Point(98, 82);
			this.txttitle.Name = "txttitle";
			this.txttitle.Size = new System.Drawing.Size(188, 20);
			this.txttitle.TabIndex = 2;
			// 
			// txtmessage
			// 
			this.txtmessage.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtmessage.Location = new System.Drawing.Point(98, 145);
			this.txtmessage.Multiline = true;
			this.txtmessage.Name = "txtmessage";
			this.txtmessage.Size = new System.Drawing.Size(188, 179);
			this.txtmessage.TabIndex = 3;
			// 
			// btnnew
			// 
			this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
			this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnnew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnnew.Location = new System.Drawing.Point(98, 344);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(75, 23);
			this.btnnew.TabIndex = 4;
			this.btnnew.Text = "New";
			this.btnnew.UseVisualStyleBackColor = false;
			this.btnnew.Click += new System.EventHandler(this.btnnew_Click_1);
			// 
			// btnsave
			// 
			this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
			this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnsave.Location = new System.Drawing.Point(211, 344);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 5;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label1.Location = new System.Drawing.Point(417, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Message List";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(420, 145);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(207, 179);
			this.dataGridView1.TabIndex = 7;
			// 
			// btnread
			// 
			this.btnread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
			this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnread.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnread.Location = new System.Drawing.Point(420, 344);
			this.btnread.Name = "btnread";
			this.btnread.Size = new System.Drawing.Size(75, 23);
			this.btnread.TabIndex = 8;
			this.btnread.Text = "Read";
			this.btnread.UseVisualStyleBackColor = false;
			this.btnread.Click += new System.EventHandler(this.btnread_Click_1);
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(160)))), ((int)(((byte)(195)))));
			this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btndelete.Location = new System.Drawing.Point(552, 344);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(75, 23);
			this.btndelete.TabIndex = 9;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// Note
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(162)))), ((int)(((byte)(155)))));
			this.ClientSize = new System.Drawing.Size(725, 426);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnread);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnnew);
			this.Controls.Add(this.txtmessage);
			this.Controls.Add(this.txttitle);
			this.Controls.Add(this.lblmessage);
			this.Controls.Add(this.lbltitle);
			this.Name = "Note";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbltitle;
		private System.Windows.Forms.Label lblmessage;
		private System.Windows.Forms.TextBox txttitle;
		private System.Windows.Forms.TextBox txtmessage;
		private System.Windows.Forms.Button btnnew;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnread;
		private System.Windows.Forms.Button btndelete;
	}
}

