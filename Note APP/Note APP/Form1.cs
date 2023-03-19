using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_APP
{
	public partial class Note : Form
	{
		DataTable table;
		public Note()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			table = new DataTable();
			table.Columns.Add("Title", typeof(string));
			table.Columns.Add("Message", typeof(string));
			dataGridView1.DataSource = table;
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;
			if(index>-1)
			{
				txttitle.Clear();
				txtmessage.Clear();
				table.Rows[index].Delete();
			}
		}

		private void btnread_Click_1(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentCell.RowIndex;

			if (index > -1)
			{
				txttitle.Text = table.Rows[index].ItemArray[0].ToString();
				txtmessage.Text = table.Rows[index].ItemArray[1].ToString();
			}
		}

		private void btnsave_Click_1(object sender, EventArgs e)
		{

			table.Rows.Add(txttitle.Text, txtmessage.Text);
			txtmessage.Clear();
			txttitle.Clear();
		}

		private void btnnew_Click_1(object sender, EventArgs e)
		{
			txtmessage.Clear();
			txttitle.Clear();
		}
	}
}
