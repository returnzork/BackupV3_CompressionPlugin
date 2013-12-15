using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compression_Plugin
{
    public partial class settings_form : Form
    {

        Settings settings = new Settings();

        public settings_form()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DeleteWorldCheckBox.Checked)
                settings.DeleteUnCompressedWorld = true;
            else
                settings.DeleteUnCompressedWorld = false;
        }
    }
}
