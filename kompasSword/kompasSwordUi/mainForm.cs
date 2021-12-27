using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kompasSword;
using Kompas6API5;
using Kompas6Constants3D;

namespace kompasSwordUi
{
    public partial class mainForm : Form
    {
        private KompasObject _kotmans;
        private ksPart _troot;
        private ksDocument3D _qr;
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _kotmans = KompasConnector.GetKompasInstance();
            _qr = KompasConnector.GetActiveDocument3D(_kotmans);
            _troot = _qr.GetPart((short)Part_Type.pTop_Part);

        }
    }
}
