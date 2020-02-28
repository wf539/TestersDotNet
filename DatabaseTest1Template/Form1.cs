#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DatabaseTest1Template
{
    partial class frmTestBed : Form
    {
		void TestLog(int tId, System.DateTime testDate, string reqMt, string tester,
			bool result)
		{
			OleDbConnection cnTestResults = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb");
			int iRet;
			cnTestResults.Open();
			OleDbCommand cmd = new OleDbCommand("INSERT INTO TestResults (TestID, TestDate, Reqmt, Tester, Result) "
				+ "VALUES (" + tId + ",'" + testDate + "','" + reqMt + "','" + 
				tester + "'," + result + ")", cnTestResults);
			iRet = cmd.ExecuteNonQuery();
			cnTestResults.Close(); 
		}
        public frmTestBed()
        {
            InitializeComponent();
        }

		private void btnRunTest_Click(object sender, EventArgs e)
		{
			OleDbConnection cn = new OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=TestResultsDB.mdb");
			int iRet1, iRet2;
			cn.Open();
			OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM ContactList", cn);
			iRet1 = Convert.ToInt16(cmd.ExecuteScalar());
			cmd.CommandText = "SELECT COUNT(*) FROM Customers";
			iRet2 = Convert.ToInt16(cmd.ExecuteScalar());
			if (iRet1 == iRet2)
			{
				TestLog(101, DateTime.Now, "XYZ122", "Sweeny, M.", true);
				MessageBox.Show("Test pass reported to Database");
			}
			else
			{
				TestLog(101, DateTime.Now, "XYZ122", "Sweeny, M.", false);
				MessageBox.Show("Test failure reported to Database");
			}
			cn.Close();
		}
    }
}