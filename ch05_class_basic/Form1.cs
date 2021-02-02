using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch05_class_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            myButton.Text = "코드에서 변경맨";

            Button bb = new Button();
            bb.Width = 100;
            bb.Location = new Point(30, 30);
            bb.Text = "Dynamic Created Button - bb";
            Controls.Add(bb);
        }
    }
}
