using classlib60;
using classlibStandard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppNet60
{
    public partial class FrSayHelloNet60 : Form
    {
        public FrSayHelloNet60()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            SampleClass sample = new SampleClass();
            MessageBox.Show(sample.GetMessage());
        }

        private void btnSayHelloStd_Click(object sender, EventArgs e)
        {
            SampleClassStandard sample = new SampleClassStandard();
            MessageBox.Show(sample.GetMessage());
        }
    }
}
