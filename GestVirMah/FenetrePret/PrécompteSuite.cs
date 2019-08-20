using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestVirMah.ClassePret;

namespace GestVirMah.FenetrePret
{
    public partial class PrécompteSuite : Form
    {
        public PrécompteSuite()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            FenetrePrincipale.Tablet1.WriteXmlSchema("SHEMAprécomptesuite.xml");
            TableauT1 cr = new TableauT1();
            cr.SetDataSource(FenetrePrincipale.Tablet1);
            crystalReportViewer1.ReportSource = cr;

        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
