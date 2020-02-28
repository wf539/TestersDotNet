namespace DatabaseTest1Template
{
    partial class frmTestBed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
			this.btnRunTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnRunTest
			// 
			this.btnRunTest.Location = new System.Drawing.Point(105, 122);
			this.btnRunTest.Name = "btnRunTest";
			this.btnRunTest.Size = new System.Drawing.Size(75, 23);
			this.btnRunTest.TabIndex = 0;
			this.btnRunTest.Text = "Run test";
			this.btnRunTest.UseVisualStyleBackColor = true;
			this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
			// 
			// frmTestBed
			// 
			this.AcceptButton = this.btnRunTest;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnRunTest);
			this.Name = "frmTestBed";
			this.Text = "Database1 Test Bed";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnRunTest;
    }
}

