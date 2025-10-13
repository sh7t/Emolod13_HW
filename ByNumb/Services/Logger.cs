using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByNumb.Services
{
    public static class Logger
    {
        public static void AddLog(string log, Color color, RichTextBox logBox)
        {
            logBox.SelectionColor = color;
            logBox.AppendText($"[{DateTime.Now.ToString("T")}] {log}\n");
            logBox.ScrollToCaret();
            logBox.SelectionColor = logBox.ForeColor;
        }
    }
}
