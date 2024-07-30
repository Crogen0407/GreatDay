using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GreatDay
{
	public partial class GreatDay : Form
	{
		private FlowLayoutPanel daycontainer;
		private Label label1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label2;

		public GreatDay()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreatDay));
			this.label2 = new System.Windows.Forms.Label();
			this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(971, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "2024-08-01(목)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// daycontainer
			// 
			this.daycontainer.Location = new System.Drawing.Point(15, 56);
			this.daycontainer.Name = "daycontainer";
			this.daycontainer.Size = new System.Drawing.Size(968, 608);
			this.daycontainer.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(213, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 14);
			this.label1.TabIndex = 4;
			this.label1.Text = "월";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(352, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "화";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(490, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "수";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(629, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 14);
			this.label5.TabIndex = 7;
			this.label5.Text = "목";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(768, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 14);
			this.label6.TabIndex = 8;
			this.label6.Text = "금";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(75, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 14);
			this.label7.TabIndex = 9;
			this.label7.Text = "일";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(905, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(18, 14);
			this.label8.TabIndex = 10;
			this.label8.Text = "토";
			// 
			// GreatDay
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(995, 676);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.daycontainer);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GreatDay";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.GreatDay_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		private void GreatDay_Load(object sender, EventArgs e)
		{
			Initialize();
		}

		private void Initialize()
		{
			DateTime now = DateTime.Now;

			DateTime startMonth = new DateTime(now.Year, now.Month, 1);
			int days = DateTime.DaysInMonth(now.Year, now.Month);

			for (int i = 1; i <= 30; ++i)
			{
				DateItem dateItem = new DateItem($"{now.Month.ToString()}/{i}", i==now.Day);
				daycontainer.Controls.Add(dateItem);
			}
		}
	}
}
