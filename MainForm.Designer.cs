
namespace DFASupp
{
	partial class MainForm
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

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "OpFate",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "FateIndex",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "OpDuty",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "DutyRoulette",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dutyinstance",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "OpMatch",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "MatchRoulette",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "MatchInstance",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "OpInstance",
            "",
            ""}, -1);
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "OpBozjaCe",
            "",
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(129))));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCopyResult = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.lstResult = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtExt = new System.Windows.Forms.TextBox();
			this.chkPrintLog = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.chkPrintLog);
			this.panel1.Controls.Add(this.btnCopyResult);
			this.panel1.Controls.Add(this.btnAction);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 52);
			this.panel1.TabIndex = 0;
			// 
			// btnCopyResult
			// 
			this.btnCopyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyResult.Enabled = false;
			this.btnCopyResult.Location = new System.Drawing.Point(251, 3);
			this.btnCopyResult.Name = "btnCopyResult";
			this.btnCopyResult.Size = new System.Drawing.Size(106, 46);
			this.btnCopyResult.TabIndex = 1;
			this.btnCopyResult.Text = "Copy to clipboard";
			this.btnCopyResult.UseVisualStyleBackColor = true;
			this.btnCopyResult.Click += new System.EventHandler(this.BtnCopyResult_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(3, 3);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(106, 46);
			this.btnAction.TabIndex = 0;
			this.btnAction.Text = "Connect";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
			// 
			// lstResult
			// 
			this.lstResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstResult.FullRowSelect = true;
			this.lstResult.GridLines = true;
			this.lstResult.HideSelection = false;
			listViewItem1.ToolTipText = "Go to Middle La Noscea";
			listViewItem3.ToolTipText = "Enter \"The Steps of Faith\" with undersize";
			listViewItem9.ToolTipText = "Enter \"The Steps of Faith\" with undersize";
			this.lstResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
			this.lstResult.Location = new System.Drawing.Point(12, 70);
			this.lstResult.Name = "lstResult";
			this.lstResult.Size = new System.Drawing.Size(360, 230);
			this.lstResult.TabIndex = 1;
			this.lstResult.UseCompatibleStateImageBehavior = false;
			this.lstResult.View = System.Windows.Forms.View.Details;
			this.lstResult.SelectedIndexChanged += new System.EventHandler(this.LstResult_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Function";
			this.columnHeader1.Width = 187;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Result";
			this.columnHeader2.Width = 92;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Data";
			this.columnHeader3.Width = 74;
			// 
			// txtExt
			// 
			this.txtExt.Location = new System.Drawing.Point(12, 306);
			this.txtExt.Multiline = true;
			this.txtExt.Name = "txtExt";
			this.txtExt.Size = new System.Drawing.Size(358, 103);
			this.txtExt.TabIndex = 2;
			// 
			// chkPrintLog
			// 
			this.chkPrintLog.AutoSize = true;
			this.chkPrintLog.Location = new System.Drawing.Point(181, 30);
			this.chkPrintLog.Name = "chkPrintLog";
			this.chkPrintLog.Size = new System.Drawing.Size(64, 17);
			this.chkPrintLog.TabIndex = 3;
			this.chkPrintLog.Text = "Print log";
			this.chkPrintLog.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 421);
			this.Controls.Add(this.txtExt);
			this.Controls.Add(this.lstResult);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "FFXIV DFA support tool";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCopyResult;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.ListView lstResult;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox txtExt;
		private System.Windows.Forms.CheckBox chkPrintLog;
	}
}

