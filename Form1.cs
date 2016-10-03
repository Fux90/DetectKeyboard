using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetectKeyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Model.RegisterKeyboardRawInput();
            Model.RegisterCustomFiltering(this);
        }

        private string GetInstruction()
        {
            var str = new StringBuilder();
            str.AppendLine("Click on Initialize button, then select one of the two textbox.");
            str.AppendLine("Pressing a key on a connected keyboard will assign that keyboard to the selected item.");
            str.AppendLine("Try selecting the other textbox and press a key on another keyboard.");
            str.AppendLine("Click on Stp button, then try typing with the various keyboards.");

            return str.ToString();
        }

        private void btnToggleInit_Click(object sender, EventArgs e)
        {
            btnToggleInit.Text = Model.ToggleKeyboardInitialization();
        }

        private void txtConsole_KeyDown(object sender, KeyEventArgs e)
        {
            var txt = (TextBox)sender;
            txt.AppendText(String.Format("{0}{1}", e.KeyCode, Environment.NewLine));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInstruction.Text = GetInstruction();
        }
    }
}
