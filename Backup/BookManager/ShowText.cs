using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.BookManager
{
    public partial class ShowText : Form
    {
        private String _Text;
        public ShowText(String Text)
        {
            InitializeComponent();
            _Text = Text;
        }

        private void ShowText_Load(object sender, EventArgs e)
        {
            textBox1.Text = _Text;
        }
    }
}