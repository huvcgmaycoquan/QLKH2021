using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH2021
{
    public partial class frmImage_Full : Form
    {
        MemoryStream stmBLOBData;
        public frmImage_Full(MemoryStream stmBLOBData___)
        {
            InitializeComponent();
            stmBLOBData = stmBLOBData___;

        }
        private void Load_combobox()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("id", typeof(int));
            //dt.Columns.Add("noidung", typeof(string));
            //DataRow dr1 = dt.NewRow();
            //dr1["id"] = 1;
            //dr1["noidung"] = "Clip";
            //dt.Rows.Add(dr1);

            //DataRow dr2 = dt.NewRow();
            //dr2["id"] = 2;
            //dr2["noidung"] = "Stretch";
            //dt.Rows.Add(dr2);

            //DataRow dr3 = dt.NewRow();
            //dr3["id"] = 3;
            //dr3["noidung"] = "Zoom";
            //dt.Rows.Add(dr3);

            //DataRow dr4 = dt.NewRow();
            //dr4["id"] = 4;
            //dr4["noidung"] = "StretchHorizontal";
            //dt.Rows.Add(dr4);

            //DataRow dr5 = dt.NewRow();
            //dr5["id"] = 5;
            //dr5["noidung"] = "StretchVertical";
            //dt.Rows.Add(dr5);

            //DataRow dr6 = dt.NewRow();
            //dr6["id"] = 6;
            //dr6["noidung"] = "StretchVertical";
            //dt.Rows.Add(dr6);

            //DataRow dr7 = dt.NewRow();
            //dr7["id"] = 1;
            //dr7["noidung"] = "Squeeze";
            //dt.Rows.Add(dr7);

            //comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "id";
            //comboBox1.ValueMember = "noidung";

            comboBoxEdit1.Properties.Items.Add(PictureSizeMode.Clip);
            comboBoxEdit1.Properties.Items.Add(PictureSizeMode.Squeeze);
            comboBoxEdit1.Properties.Items.Add(PictureSizeMode.Stretch);
            comboBoxEdit1.Properties.Items.Add(PictureSizeMode.StretchHorizontal);
            comboBoxEdit1.Properties.Items.Add(PictureSizeMode.StretchVertical);
            comboBoxEdit1.Properties.Items.Add(PictureSizeMode.Zoom);

           
        }
        private void frmImage_Full_Load(object sender, EventArgs e)
        {
            Load_combobox();
            
            pictureEdit1.Image = Image.FromStream(stmBLOBData);
        }
      
        //comboBoxEdit1.SelectedIndexChanged += ComboBoxEdit1_SelectedIndexChanged;
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxEdit1.SelectedIndexChanged += ComboBoxEdit1_SelectedIndexChanged;
            ComboBoxEdit control = sender as ComboBoxEdit;
            pictureEdit1.Properties.SizeMode = (PictureSizeMode)control.SelectedItem;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
