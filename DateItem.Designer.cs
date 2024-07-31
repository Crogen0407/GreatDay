
namespace GreatDay
{
	partial class DateItem
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.DayLabel = new System.Windows.Forms.Label();
			this.TodoList = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// DayLabel
			// 
			this.DayLabel.Font = new System.Drawing.Font("배달의민족 주아", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DayLabel.Location = new System.Drawing.Point(0, 0);
			this.DayLabel.Name = "DayLabel";
			this.DayLabel.Size = new System.Drawing.Size(134, 15);
			this.DayLabel.TabIndex = 0;
			this.DayLabel.Text = "8/1";
			this.DayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TodoList
			// 
			this.TodoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TodoList.FormattingEnabled = true;
			this.TodoList.Location = new System.Drawing.Point(-1, 24);
			this.TodoList.Name = "TodoList";
			this.TodoList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.TodoList.Size = new System.Drawing.Size(134, 72);
			this.TodoList.TabIndex = 1;
			this.TodoList.SelectedIndexChanged += new System.EventHandler(this.TodoList_SelectedIndexChanged);
			// 
			// DateItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.TodoList);
			this.Controls.Add(this.DayLabel);
			this.Name = "DateItem";
			this.Size = new System.Drawing.Size(133, 95);
			this.Load += new System.EventHandler(this.DateItem_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label DayLabel;
		private System.Windows.Forms.CheckedListBox TodoList;
	}
}
