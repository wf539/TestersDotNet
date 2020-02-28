using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestFileExistsForm
{
	public partial class Form1 : Form
	{
		StreamWriter Writer;
		Int16 iCount = 1;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnCheckFileExistence_Click(object sender, EventArgs e)
		{
			string strCount;
			
			if (iCount == 1)
			{
				Writer = File.CreateText("TestResults.log");
				Writer.WriteLine("Test results for Test run XYZ; " + DateTime.Now);
			}
			else
			{
				Writer = File.AppendText("TestResults.log");
			}
			strCount = Convert.ToString(iCount);

			if (File.Exists(textBoxFilenamePath.Text))
			{
				Writer.WriteLine(strCount + " File '" + (textBoxFilenamePath.Text) + 
					"' exists: Test Passed");
				lblTestResult.Text = "File '" + textBoxFilenamePath.Text + 
					"' exists: Test Passed";
			}
			else
			{
				Writer.WriteLine(strCount + " File '" + (textBoxFilenamePath.Text) +
					"' does not exist: Test Failed");
				lblTestResult.Text = "File '" + textBoxFilenamePath.Text +
					"' does not exist: Test Failed";
			}
			iCount += 1;
			Writer.Close();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Writer = File.AppendText("TestResults.log");
			Writer.WriteLine("Test run completed for Test run XYZ; " + DateTime.Now);
			Writer.Close();
		}

		private void btnShowResults_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("Notepad.exe", "TestResults.log");
		}
	}
}
