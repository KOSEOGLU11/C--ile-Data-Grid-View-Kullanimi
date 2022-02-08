using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_Sayfa_215
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn sutun;

            sutun=new DataColumn("müşteri adı",System.Type.GetType("System.String"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("aldığı mal", System.Type.GetType("System.String"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("adet", System.Type.GetType("System.Int32"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Birim_fiyatı", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("toplam", System.Type.GetType("System.Decimal"));
            sutun.Expression = "adet*Birim_fiyatı";
            dt.Columns.Add(sutun);

            sutun = new DataColumn("odenen", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(sutun);

            sutun = new DataColumn("kalan", System.Type.GetType("System.Decimal"));
            sutun.Expression = "toplam-odenen";
            dt.Columns.Add(sutun);

            sutun = new DataColumn("borcu_yok", System.Type.GetType("System.Boolean"));
            sutun.Expression = "iif(kalan>0,false,true)";
            dt.Columns.Add(sutun);

            dataGridView1.DataSource = dt;

        }
    }
}
