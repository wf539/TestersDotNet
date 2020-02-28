namespace TestFileExistsForm
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
			this.btnCheckFileExistence = new System.Windows.Forms.Button();
			this.textBoxFilenamePath = new System.Windows.Forms.TextBox();
			this.lblTestResult = new System.Windows.Forms.Label();
			this.btnShowResults = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCheckFileExistence
			// 
			this.btnCheckFileExistence.Location = new System.Drawing.Point(99, 117);
			this.btnCheckFileExistence.Name = "btnCheckFileExistence";
			this.btnCheckFileExistence.Size = new System.Drawing.Size(75, 23);
			this.btnCheckFileExistence.TabIndex = 0;
			this.btnCheckFileExistence.Text = "File exists?";
			this.btnCheckFileExistence.UseVisualStyleBackColor = true;
			this.btnCheckFileExistence.Click += new System.EventHandler(this.btnCheckFileExistence_Click);
			// 
			// textBoxFilenamePath
			// 
			this.textBoxFilenamePath.Location = new System.Drawing.Point(87, 69);
			this.textBoxFilenamePath.Name = "textBoxFilenamePath";
			this.textBoxFilenamePath.Size = new System.Drawing.Size(100, 20);
			this.textBoxFilenamePath.TabIndex = 1;
			// 
			// lblTestResult
			// 
			this.lblTestResult.AutoSize = true;
			this.lblTestResult.Location = new System.Drawing.Point(52, 29);
			this.lblTestResult.Name = "lblTestResult";
			this.lblTestResult.Size = new System.Drawing.Size(0, 13);
			this.lblTestResult.TabIndex = 2;
			// 
			// btnShowResults
			// 
			this.btnShowResults.Location = new System.Drawing.Point(87, 156);
			this.btnShowResults.Name = "btnShowResults";
			this.btnShowResults.Size = new System.Drawing.Size(100, 23);
			this.btnShowResults.TabIndex = 3;
			this.btnShowResults.Text = "Show Results";
			this.btnShowResults.UseVisualStyleBackColor = true;
			this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCheckFileExistence;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 208);
			this.Controls.Add(this.btnShowResults);
			this.Controls.Add(this.lblTestResult);
			this.Controls.Add(this.textBoxFilenamePath);
			this.Controls.Add(this.btnCheckFileExistence);
			this.Name = "Form1";
			this.Text = "File Existence Utility";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCheckFileExistence;
		private System.Windows.Forms.TextBox textBoxFilenamePath;
		private System.Windows.Forms.Label lblTestResult;
		private System.Windows.Forms.Button btnShowResults;
	}
}

