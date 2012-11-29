using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntSHCodeGenerator
{
    public partial class Form1 : Form
    {
        private IConverToPreTag cv;

        public Form1()
        {
            InitializeComponent();


            this.cv = new ConvertToPreTag_3_0_83();
            comboBox1.DataSource = this.cv.getRule();
            comboBox2.SelectedIndex = 0;

            EntHttpControl control = new EntHttpControl(this);
            control.sendRequest("http://emflant.tistory.com/42");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = this.cv.convert
                (this.richTextBox1.Text, this.comboBox1.SelectedItem.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://emflant.tistory.com/42");
        }

        public void showMessage()
        {
            if (MessageBox.Show("새로운 버전이 나왔습니다. 받으시겠습니까?", "update", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://emflant.tistory.com/42");
            }
        }

    }
}
