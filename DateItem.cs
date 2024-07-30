using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatDay
{
	public partial class DateItem : UserControl
	{
		public DateItem(string dayStr, bool isToday)
		{
			InitializeComponent();
			DayLabel.Text = dayStr;
			TodoList.Items.Add("팔굽혀펴기 300개");
			if (isToday)
				this.BackColor = Color.Red;
			TodoList.BackColor = this.BackColor;
		}

		private void DateItem_Load(object sender, EventArgs e)
		{
		}
	}
}
