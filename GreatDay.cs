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
		private Button PreviousMonthBtn;
		private Button NextMonthBtn;
		private Label NowDateLabel;
		private ContextMenuStrip contextMenuStrip1;
		private IContainer components;
		private DateTime _currentSelectDate;
		private bool _dragging = false;

		public GreatDay()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreatDay));
			this.NowDateLabel = new System.Windows.Forms.Label();
			this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.PreviousMonthBtn = new System.Windows.Forms.Button();
			this.NextMonthBtn = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// NowDateLabel
			// 
			this.NowDateLabel.BackColor = System.Drawing.SystemColors.Window;
			this.NowDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NowDateLabel.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NowDateLabel.Location = new System.Drawing.Point(429, 4);
			this.NowDateLabel.Name = "NowDateLabel";
			this.NowDateLabel.Size = new System.Drawing.Size(138, 23);
			this.NowDateLabel.TabIndex = 2;
			this.NowDateLabel.Text = "2024-08-01(목)";
			this.NowDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NowDateLabel.Click += new System.EventHandler(this.NowDateLabel_Click);
			this.NowDateLabel.MouseEnter += new System.EventHandler(this.ShowNowDateLabelTooltip);
			// 
			// daycontainer
			// 
			this.daycontainer.Location = new System.Drawing.Point(12, 59);
			this.daycontainer.Margin = new System.Windows.Forms.Padding(0);
			this.daycontainer.Name = "daycontainer";
			this.daycontainer.Size = new System.Drawing.Size(975, 608);
			this.daycontainer.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(154, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 14);
			this.label1.TabIndex = 4;
			this.label1.Text = "월";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(293, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "화";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Window;
			this.label4.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(432, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 14);
			this.label4.TabIndex = 6;
			this.label4.Text = "수";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Window;
			this.label5.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(571, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 14);
			this.label5.TabIndex = 7;
			this.label5.Text = "목";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Window;
			this.label6.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(710, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 14);
			this.label6.TabIndex = 8;
			this.label6.Text = "금";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Window;
			this.label7.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(15, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 14);
			this.label7.TabIndex = 9;
			this.label7.Text = "일";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Window;
			this.label8.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(849, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 14);
			this.label8.TabIndex = 10;
			this.label8.Text = "토";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PreviousMonthBtn
			// 
			this.PreviousMonthBtn.BackColor = System.Drawing.SystemColors.Window;
			this.PreviousMonthBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.PreviousMonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PreviousMonthBtn.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PreviousMonthBtn.Location = new System.Drawing.Point(12, 4);
			this.PreviousMonthBtn.Name = "PreviousMonthBtn";
			this.PreviousMonthBtn.Size = new System.Drawing.Size(411, 23);
			this.PreviousMonthBtn.TabIndex = 11;
			this.PreviousMonthBtn.Text = "<";
			this.PreviousMonthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.PreviousMonthBtn.UseVisualStyleBackColor = false;
			this.PreviousMonthBtn.Click += new System.EventHandler(this.PreviousMonthBtn_Click);
			// 
			// NextMonthBtn
			// 
			this.NextMonthBtn.BackColor = System.Drawing.SystemColors.Window;
			this.NextMonthBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.NextMonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NextMonthBtn.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NextMonthBtn.Location = new System.Drawing.Point(573, 4);
			this.NextMonthBtn.Name = "NextMonthBtn";
			this.NextMonthBtn.Size = new System.Drawing.Size(414, 23);
			this.NextMonthBtn.TabIndex = 12;
			this.NextMonthBtn.Text = ">";
			this.NextMonthBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.NextMonthBtn.UseVisualStyleBackColor = false;
			this.NextMonthBtn.Click += new System.EventHandler(this.NextMonthBtn_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// GreatDay
			// 
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(995, 676);
			this.Controls.Add(this.NextMonthBtn);
			this.Controls.Add(this.PreviousMonthBtn);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.daycontainer);
			this.Controls.Add(this.NowDateLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GreatDay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.Color.Yellow;
			this.Load += new System.EventHandler(this.GreatDay_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreatDay_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreatDay_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GreatDay_MouseUp);
			this.ResumeLayout(false);

		}
		
		private void GreatDay_Load(object sender, EventArgs e)
		{
			Initialize();
		}

		private void Initialize()
		{
			DateTime now = DateTime.Now;
			_currentSelectDate = now;
			DateTime startMonth = new DateTime(now.Year, now.Month, 1);
			
			//string nowDayStr = string.Empty;
			//string[] dayOfWeeks = { "일", "월", "화", "수", "목", "금", "토" };
			//nowDayStr = dayOfWeeks[(int)now.DayOfWeek];

			UpdateNowDateLabel(now);
		}

		//MonthMoveBtn
		private void PreviousMonthBtn_Click(object sender, EventArgs e)
		{
			_currentSelectDate = _currentSelectDate.AddMonths(-1);
			UpdateNowDateLabel(_currentSelectDate);
		}

		private void NextMonthBtn_Click(object sender, EventArgs e)
		{
			_currentSelectDate = _currentSelectDate.AddMonths(1);
			UpdateNowDateLabel(_currentSelectDate);
		}

		private void UpdateNowDateLabel(DateTime dateTime)
		{
			NowDateLabel.Text = $"{dateTime.Year}년 {dateTime.Month}월";
			UpdateDaycontainer(dateTime);
		}

		private void UpdateDaycontainer(DateTime dateTime)
		{
			daycontainer.Controls.Clear();

			int maxDayOfMonth = DateTime.DaysInMonth(_currentSelectDate.Year, _currentSelectDate.Month);
			DateTime now = DateTime.Now;
			DateTime userSelectDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);


			for (int i = 0; i < (int)userSelectDate.DayOfWeek; ++i)
			{
				EmptyDateItem emptyDateItem = new EmptyDateItem();
				daycontainer.Controls.Add(emptyDateItem);
			}

			for (int i = 1; i <= maxDayOfMonth; ++i)
			{
				DateItem dateItem = new DateItem($"{userSelectDate.Month.ToString()}/{i}", i == userSelectDate.Day && (dateTime.Year == now.Year && dateTime.Month == now.Month));
				daycontainer.Controls.Add(dateItem);
			}

			daycontainer.Refresh();
		}

		private void NowDateLabel_Click(object sender, EventArgs e)
		{
			_currentSelectDate = DateTime.Now;

			UpdateNowDateLabel(_currentSelectDate);
		}

		private void ShowNowDateLabelTooltip(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(sender as Control, "오늘 날짜로 이동합니다.");
		}

		private Point _startWindowPos;

		private void GreatDay_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				_startWindowPos = this.Location;
				_dragging = true;
			}
		}

		private void GreatDay_MouseMove(object sender, MouseEventArgs e)
		{
			if (_dragging)
			{
				this.Location = Cursor.Position;
			}
		}

		private void GreatDay_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				_dragging = false;
			}
		}
	}
}
