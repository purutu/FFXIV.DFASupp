using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DFASupp
{
	static class MsgLog
	{
        private static class NativeMethods
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
            private const int WM_VSCROLL = 277;
            private const int SB_PAGEBOTTOM = 7;

            internal static void ScrollToBottom(TextBox tb)
            {
                SendMessage(tb.Handle, WM_VSCROLL, (IntPtr)SB_PAGEBOTTOM, IntPtr.Zero);
                tb.SelectionStart = tb.Text.Length;
            }
        }

        private static readonly Regex EscapePattern = new Regex(@"\{(.+?)\}");

        private static Form _invkform;
        private static TextBox _logbox;

        public static void SetTextBox(Form invokeform, TextBox logbox)
        {
            _invkform = invokeform;
            _logbox = logbox;
        }

        public static void Write(string format, params object[] args)
        {
            if (_logbox == null || _logbox.IsDisposed)
                return;

            var formatted = format ?? "(empty message)";

            try
            {
                formatted = string.Format(formatted.ToString(), args);
            }
            catch (FormatException)
            {
            }

            var datetime = DateTime.Now.ToString("HH:mm:ss");
            var message = $"[{datetime}] {formatted}{Environment.NewLine}";

            _invkform.Invoke(new Action(() =>
            {
                _logbox.SelectionStart = _logbox.TextLength;
                _logbox.SelectionLength = 0;
                _logbox.AppendText(message);

                NativeMethods.ScrollToBottom(_logbox);
            }));
        }

        public static void Buffer(byte[] buffer)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            for (var i = 0; i < buffer.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 16 == 0)
                    {
                        stringBuilder.AppendLine();
                    }
                    else if (i % 8 == 0)
                    {
                        stringBuilder.Append(' ', 2);
                    }
                    else
                    {
                        stringBuilder.Append(' ');
                    }
                }

                stringBuilder.Append(buffer[i].ToString("X2"));
            }

            Write(stringBuilder.ToString());
        }

        internal static string Escape(string line)
        {
            return EscapePattern.Replace(line, "{{$1}}");
        }

        public static void Exception(Exception ex, string key, params object[] args)
        {
            var msg = Escape(ex.Message);

            Write($"{key}: {msg}", args);
        }
    }
}
