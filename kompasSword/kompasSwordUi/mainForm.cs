using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KompasSword;
using Kompas6API5;
using Kompas6Constants3D;

namespace kompasSwordUi
{
    public partial class mainForm : Form
    {
        private KompasObject _kompas;
        private ksPart _root;
        private ksDocument3D _document;
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _kompas = kompasConnect.GetKompasInstance();
            _document = kompasConnect.GetActiveDocument3D(_kompas);
            _root = _document.GetPart((short)Part_Type.pTop_Part);

            var sketch = Scetcher.CreateScetch(_root, (short)Plane.Xy);
            var definition = (ksSketchDefinition)sketch.GetDefinition();
            var edit = definition.Edit();

            edit.ksLineSeg(2, 0, 0, 2, 1);
            definition.EndEdit();
        }
    }
}
