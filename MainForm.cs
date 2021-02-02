using Machina.FFXIV;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DFASupp
{
	public partial class MainForm : Form
	{
		private FFXIVNetworkMonitor _nmon;
		private bool _isconn = false;

		private GamePacket _gpk = new GamePacket();

		private static string[] HelpMesssage = new string[]
		{
			"",
			"Go to Middle La Noscea\r\nWait for FATEs\r\n(Aka. 中央ラノシア / 中拉诺西亚 / 중앙라노시아)",
			"Enter trial \"The Steps of Faith\" with undersize option\r\n(Aka. 皇都イシュガルド防衛戦 / 성도 이슈가르드 방어전)",
		};

		public MainForm()
		{
			InitializeComponent();

			MsgLog.SetTextBox(this, txtExt);
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (_isconn)
			{
				if (_nmon != null)
				{
					_nmon.Stop();
					_nmon = null;
				}
			}
		}

		private void BtnAction_Click(object sender, EventArgs e)
		{
			if (_isconn)
			{
				if (_nmon != null)
				{
					_nmon.Stop();
					_nmon = null;
				}

				_isconn = false;
				btnAction.Text = "Connect";

				btnCopyResult.Enabled = false;
			}
			else
			{
				if (_nmon != null)
					_nmon.Stop();

				_nmon = new FFXIVNetworkMonitor()
				{
					MessageReceived = MonitorOnReceive,
					MessageSent = MonitorOnSent,
				};
				_nmon.Start();

				_isconn = true;
				btnAction.Text = "Stop";

				btnCopyResult.Enabled = true;
			}
		}

		private void LstResult_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstResult.SelectedIndices.Count == 0)
				return;

			string m;

			switch (lstResult.SelectedIndices[0])
			{
				case 0:
				case 1:
					m = HelpMesssage[1];
					break;

				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
					m = HelpMesssage[2];
					break;

				default:
					m = HelpMesssage[0];
					break;
			}

			txtExt.Text = m;
		}

		private void BtnCopyResult_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendFormat("OpFate = 0x{0},", Convert.ToString(_gpk.OpFate, 16).ToUpper()).AppendLine();
			sb.AppendFormat("FateIndex = {0},", _gpk.FateIndex).AppendLine();

			sb.AppendFormat("OpDuty = 0x{0},", Convert.ToString(_gpk.OpDuty, 16).ToUpper()).AppendLine();
			sb.AppendFormat("DutyRoulette = {0},", _gpk.DutyRoulette).AppendLine();
			sb.AppendFormat("DutyInstance = {0},", _gpk.DutyInstance).AppendLine();

			sb.AppendFormat("OpMatch = 0x{0},", Convert.ToString(_gpk.OpMatch, 16).ToUpper()).AppendLine();
			sb.AppendFormat("MatchRoulette = {0},", _gpk.MatchRoulette).AppendLine();
			sb.AppendFormat("MatchInstance = {0},", _gpk.MatchInstance).AppendLine();

			sb.AppendFormat("OpInstance = 0x{0},", Convert.ToString(_gpk.OpInstance, 16).ToUpper()).AppendLine();

			sb.AppendFormat("OpBozjaCe = 0x{0},", Convert.ToString(_gpk.OpBozjaCe, 16).ToUpper()).AppendLine();

			//
			Clipboard.SetText(sb.ToString());
			MsgLog.Write("Copied to clipboard.");
		}

		// 보내기
		private void MonitorOnSent(string id, long epoch, byte[] data)
		{

		}

		// 받기
		private void MonitorOnReceive(string id, long epoch, byte[] message)
		{
			var opcode = BitConverter.ToUInt16(message, 18);
			var data = message.Skip(32).ToArray();

			// opduty
			if (data.Length > 12)
			{
				var rcode = data[8];

				if (rcode == 0)   // 지정 매칭
				{
					// The Steps of Faith (83)
					short m = BitConverter.ToInt16(data, 12);
					if (m == 83)
					{
						_gpk.OpDuty = opcode;
						_gpk.DutyRoulette = 8;
						_gpk.DutyInstance = 12;

						if (chkPrintLog.Checked)
							MsgLog.Write("Found opduty: {0:X4}", opcode);

						UpdateResult(() =>
						{
							lstResult.Items[2].SubItems[1].Text = "Ok";
							lstResult.Items[2].SubItems[2].Text = Convert.ToString(_gpk.OpDuty, 16).ToUpper();

							lstResult.Items[3].SubItems[1].Text = "Ok";
							lstResult.Items[3].SubItems[2].Text = _gpk.DutyRoulette.ToString();

							lstResult.Items[4].SubItems[1].Text = "Ok";
							lstResult.Items[4].SubItems[2].Text = _gpk.DutyInstance.ToString();
						});

						return;
					}
				}
			}

			// opmatch
			if (data.Length > 20)
			{
				var rcode = data[2];

				if (rcode == 0)
				{
					// The Steps of Faith (83)
					short m = BitConverter.ToInt16(data, 20);
					if (m == 83)
					{
						_gpk.OpMatch = opcode;
						_gpk.MatchRoulette = 2;
						_gpk.MatchInstance = 20;

						if (chkPrintLog.Checked)
							MsgLog.Write("Found opmatch: {0:X4}", opcode);

						UpdateResult(() =>
						{
							lstResult.Items[5].SubItems[1].Text = "Ok";
							lstResult.Items[5].SubItems[2].Text = Convert.ToString(_gpk.OpMatch, 16).ToUpper();

							lstResult.Items[6].SubItems[1].Text = "Ok";
							lstResult.Items[6].SubItems[2].Text = _gpk.MatchRoulette.ToString();

							lstResult.Items[7].SubItems[1].Text = "Ok";
							lstResult.Items[7].SubItems[2].Text = _gpk.MatchInstance.ToString();
						});

						return;
					}
				}
			}

			// opinstance
			if (data.Length >= 16)
			{
				// The Steps of Faith (83)
				short m = BitConverter.ToInt16(data, 0);
				short u = BitConverter.ToInt16(data, 2);
				if (m == 83 && u == 0)
				{
					_gpk.OpInstance = opcode;

					if (chkPrintLog.Checked)
					{
						var p = data[4] == 4 ? "Enter" : data[4] == 5 ? "Leave" : data[5].ToString();
						MsgLog.Write("Found opinstance: {0:X4}, status={1}", opcode, p);
					}

					UpdateResult(() =>
					{
						lstResult.Items[8].SubItems[1].Text = "Ok";
						lstResult.Items[8].SubItems[2].Text = Convert.ToString(_gpk.OpInstance, 16).ToUpper();
					});

					return;
				}
			}

			// opfate
			if (data.Length > 4 && data[0] == 0x3E)
			{
				var cc = BitConverter.ToInt16(data, 4);
				if (GameFates.IsTargetFate(cc))
				{
					_gpk.OpFate = opcode;
					_gpk.FateIndex = 0x35;

					if (chkPrintLog.Checked)
					{
						var fatename = GameFates.GetFate(cc);
						MsgLog.Write("Found opfate: {0:X4}, \"{1}({2})\"", opcode, fatename, cc);
					}

					UpdateResult(() =>
					{
						lstResult.Items[0].SubItems[1].Text = "Ok";
						lstResult.Items[0].SubItems[2].Text = Convert.ToString(_gpk.OpFate, 16).ToUpper();

						lstResult.Items[1].SubItems[1].Text = "Ok";
						lstResult.Items[1].SubItems[2].Text = Convert.ToString(_gpk.FateIndex, 16).ToUpper();
					});

					return;
				}
			}

			// critical engagement
			if (data.Length >= 12)
			{
				// oops!
			}
		}

		//
		private void UpdateResult(Action a)
		{
			this.Invoke(a);
		}
	}
}
