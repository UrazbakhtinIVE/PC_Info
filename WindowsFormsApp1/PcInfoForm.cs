using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class PcInfoForm : Form
    {
        public PcInfoForm()
        {
            InitializeComponent();
            Pc pc = new Pc();
            pcNameTB.Text = pc.getPcName();
            IpTB.Text = pc.getIp();
        }

        private void IpTB_TextChanged(object sender, EventArgs e)
        {
            Pc pc = new Pc();
            pc.getIp();
        }
    }
}
