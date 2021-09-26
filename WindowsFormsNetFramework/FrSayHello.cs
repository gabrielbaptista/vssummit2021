using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classlibStandard;

namespace WindowsFormsNetFramework
{
    public partial class FrSayHello : Form
    {
        public FrSayHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            SampleClassStandard sample = new SampleClassStandard();
            MessageBox.Show(sample.GetMessage());
        }
    }
}
