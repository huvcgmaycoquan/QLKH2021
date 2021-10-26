using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKH2021
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Load_grid_lockup()
        {
            clsTbdonvibaocao cls1 = new clsTbdonvibaocao();
            DataTable dt1 = cls1.SelectAll();           
            griddonvibaocao.DataSource = dt1;
            griddonvibaocao.ValueMember = "id";
            griddonvibaocao.DisplayMember = "tendonvi";

         

            //clsTbdonvithuchien cls2 = new clsTbdonvithuchien();
            //DataTable dt2 = cls2.SelectAll();
            //gridonvithuchien.DataSource = dt2;
            //gridonvithuchien.ValueMember = "id";
            //gridonvithuchien.DisplayMember = "tendonvi";


            //clsTbtacgia cls3 = new clsTbtacgia();
            //DataTable dt3 = cls3.SelectAll();
            //gridtacgia.DataSource = dt3;
            //gridtacgia.ValueMember = "id";
            //gridtacgia.DisplayMember = "hienthiten";


            clsTbmuckhenthuong cls4 = new clsTbmuckhenthuong();
            DataTable dt4 = cls4.SelectAll();
            gridmuckhenthuong.DataSource = dt4;
            gridmuckhenthuong.ValueMember = "id";
            gridmuckhenthuong.DisplayMember = "muckhenthuong";



            clsTbketquaxetduyet cls5 = new clsTbketquaxetduyet();
            DataTable dt5 = cls5.SelectAll();
            gridketquaxetduyet.DataSource = dt5;
            gridketquaxetduyet.ValueMember = "id";
            gridketquaxetduyet.DisplayMember = "ketquaxetduyet";

            clsTbTheLoai cls6 = new clsTbTheLoai();
            DataTable dt6 = cls6.SelectAll();
            gridTheloai.DataSource = dt6;
            gridTheloai.ValueMember = "id";
            gridTheloai.DisplayMember = "theloai";


        }
        private void Load_Combobox()
        {
            clsTbdonvibaocao cls1 = new clsTbdonvibaocao();
            DataTable dt1 = cls1.SelectAll();
            DataTable dtxx1 = new DataTable();
            dtxx1.Columns.Add("id", typeof(int));
            dtxx1.Columns.Add("tendonvi", typeof(string));            
            DataRow _ravi = dtxx1.NewRow();
            _ravi["id"] = 0;
            _ravi["tendonvi"] = "Tất cả";
            dtxx1.Rows.Add(_ravi);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                int idxx = Convert.ToInt16(dt1.Rows[i]["id"].ToString());
                DataRow _ravi2 = dtxx1.NewRow();
                _ravi2["id"] = idxx;                
                _ravi2["tendonvi"] = dt1.Rows[i]["tendonvi"].ToString();
                dtxx1.Rows.Add(_ravi2);
            }
            searchLookup_DonviBaoCao.Properties.DataSource = dtxx1;
            searchLookup_DonviBaoCao.Properties.ValueMember = "id";
            searchLookup_DonviBaoCao.Properties.DisplayMember = "tendonvi";
            searchLookup_DonviBaoCao.EditValue = 0;

            clsTbdonvithuchien cls2 = new clsTbdonvithuchien();
            DataTable dt2 = cls2.SelectAll();
            DataTable dtxx2 = new DataTable();
            dtxx2.Columns.Add("id", typeof(int));
            dtxx2.Columns.Add("tendonvi", typeof(string));
            DataRow _ravi3 = dtxx2.NewRow();
            _ravi3["id"] = 0;
            _ravi3["tendonvi"] = "Tất cả";
            dtxx2.Rows.Add(_ravi3);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                int idxx = Convert.ToInt16(dt2.Rows[i]["id"].ToString());
                DataRow _ravi2 = dtxx2.NewRow();
                _ravi2["id"] = idxx;
                _ravi2["tendonvi"] = dt2.Rows[i]["tendonvi"].ToString();
                dtxx2.Rows.Add(_ravi2);
            }
            searchLookUp_DonViThucHien.Properties.DataSource = dtxx2;
            searchLookUp_DonViThucHien.Properties.ValueMember = "id";
            searchLookUp_DonViThucHien.Properties.DisplayMember = "tendonvi";
            searchLookUp_DonViThucHien.EditValue = 0;

            clsTbTheLoai cls23 = new clsTbTheLoai();
            DataTable dt23 = cls23.SelectAll();
            DataTable dtxx23 = new DataTable();
            dtxx23.Columns.Add("id", typeof(int));
            dtxx23.Columns.Add("theloai", typeof(string));
            DataRow _ravi33 = dtxx23.NewRow();
            _ravi33["id"] = 0;
            _ravi33["theloai"] = "Tất cả";
            dtxx23.Rows.Add(_ravi33);
            for (int i = 0; i < dt23.Rows.Count; i++)
            {
                int idxx = Convert.ToInt16(dt23.Rows[i]["id"].ToString());
                DataRow _ravi2 = dtxx23.NewRow();
                _ravi2["id"] = idxx;
                _ravi2["theloai"] = dt23.Rows[i]["theloai"].ToString();
                dtxx23.Rows.Add(_ravi2);
            }
            searchLookUp_TheLoai.Properties.DataSource = dtxx23;
            searchLookUp_TheLoai.Properties.ValueMember = "id";
            searchLookUp_TheLoai.Properties.DisplayMember = "theloai";
            searchLookUp_TheLoai.EditValue = 0;

            clsTbketquaxetduyet cls = new clsTbketquaxetduyet();
            DataTable dt5 = cls.SelectAll();
            DataTable xxdt = new DataTable();
            xxdt.Columns.Add("id", typeof(int));
            xxdt.Columns.Add("ketquaxetduyet", typeof(string));
            DataRow _ravi4 = xxdt.NewRow();
            _ravi4["id"] = 0;
            _ravi4["ketquaxetduyet"] = "Tất cả";
            xxdt.Rows.Add(_ravi4);
            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                int idxx = Convert.ToInt16(dt5.Rows[i]["id"].ToString());
                DataRow _ravi2 = xxdt.NewRow();
                _ravi2["id"] = idxx;
                _ravi2["ketquaxetduyet"] = dt5.Rows[i]["ketquaxetduyet"].ToString();
                xxdt.Rows.Add(_ravi2);
            }
            searchLookUp_ketquaxetduyet.Properties.DataSource = xxdt;
            searchLookUp_ketquaxetduyet.Properties.ValueMember = "id";
            searchLookUp_ketquaxetduyet.Properties.DisplayMember = "ketquaxetduyet";
            searchLookUp_ketquaxetduyet.EditValue = 0;
        }
        int aid_theloai_ = 0; int aid_donvibaocao_ = 0; int aid_donvithuchien_ = 0; int aid_ketquaxetduyet_ = 0;int atunam_ = 0; int adennam_ = 0;
        private void Load_DaTa(int id_theloai_,int id_donvibaocao_, int id_donvithuchien_, int id_ketquaxetduyet_,int tunam_, int dennam_)
        {
            clsTbsangkien cls = new clsTbsangkien();
            DataTable dt = new DataTable();
            if(id_theloai_==0)
            {
                if (id_donvibaocao_ == 0)
                {
                    if (id_donvithuchien_ == 0)
                    {
                        dt = cls.SA_id_ketquaxetduyet(tunam_,dennam_,id_ketquaxetduyet_);
                    }
                    else
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_dvthuchien(tunam_, dennam_, id_ketquaxetduyet_, id_donvithuchien_);
                    }
                }
                else // dobibaocao khác 0
                {
                    if (id_donvithuchien_ == 0)
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_dvbaocao(tunam_, dennam_,id_ketquaxetduyet_, id_donvibaocao_);
                    }
                    else
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_dvthuchien_dvbaocao(tunam_, dennam_, id_ketquaxetduyet_, id_donvithuchien_, id_donvibaocao_);
                    }
                }
            }
            else
            {
                if (id_donvibaocao_ == 0)
                {
                    if (id_donvithuchien_ == 0)
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_theloai(tunam_, dennam_, id_ketquaxetduyet_, id_theloai_);
                    }
                    else
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai(tunam_, dennam_, id_ketquaxetduyet_, id_donvithuchien_, id_theloai_);
                    }
                }
                else
                {
                    if (id_donvithuchien_ == 0)
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_theloai_id_dovibaocao(tunam_, dennam_, id_ketquaxetduyet_, id_theloai_, id_donvibaocao_);
                    }
                    else
                    {
                        dt = cls.SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai_id_dovibaocao(tunam_, dennam_, id_ketquaxetduyet_, id_donvithuchien_, id_theloai_, id_donvibaocao_);
                    }
                }
            }
            
            gridControl1.DataSource = dt;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            clnambaocao.Caption = "Năm\nbáo cáo";
            clnamdexuat.Caption = "Năm\nđề xuất";
            clid_muckhenthuong.Caption = "Mức\nkhen thưởng";
            clid_ketquaxetduyet.Caption = "Kết quả\nxét duyệt";
            Load_Combobox();
            Load_grid_lockup();

            DateTime today = DateTime.Today;
            adennam_ = Convert.ToInt32(today.ToString("yyyy"));
            atunam_ = adennam_ - 5;
            txtDenNam.Text = adennam_.ToString();
            txtTuNam.Text = (atunam_).ToString();
            Load_DaTa(0, 0, 0, 0, 2017, 2022);
        }

        private void txtTuNam_Leave(object sender, EventArgs e)
        {
            try
            {
                atunam_ = Convert.ToInt32(txtTuNam.Text);
                Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
            }
            catch
            {
                Load_DaTa(0, 0, 0, 0, 2017, 2022);
            }
            
        }

        private void txtTuNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    atunam_ = Convert.ToInt32(txtTuNam.Text);
                    Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
                }
                catch
                {
                    Load_DaTa(0, 0, 0, 0, 2017, 2022);
                }
            }
        }

        private void txtDenNam_Leave(object sender, EventArgs e)
        {
            try
            {
                adennam_ = Convert.ToInt32(txtDenNam.Text);
                Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
            }
            catch
            {
                Load_DaTa(0, 0, 0, 0, 2017, 2022);
            }
        }

        private void txtDenNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    adennam_ = Convert.ToInt32(txtDenNam.Text);
                    Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
                }
                catch
                {
                    Load_DaTa(0, 0, 0, 0, 2017, 2022);
                }
            }
        }

        private void searchLookUp_TheLoai_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                aid_theloai_ = Convert.ToInt32(searchLookUp_TheLoai.EditValue.ToString());
                Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
            }
            catch
            {
                Load_DaTa(0, 0, 0, 0, 2017, 2022);
            }
        }

        private void searchLookUp_ketquaxetduyet_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                aid_ketquaxetduyet_ = Convert.ToInt32(searchLookUp_ketquaxetduyet.EditValue.ToString());
                Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
            }
            catch
            {
                Load_DaTa(0, 0, 0, 0, 2017, 2022);
            }
        }

        private void searchLookup_DonviBaoCao_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                aid_donvibaocao_ = Convert.ToInt32(searchLookup_DonviBaoCao.EditValue.ToString());
                Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
            }
            catch
            {
                Load_DaTa(0, 0, 0, 0, 2017, 2022);
            }
        }

        private void searchLookUp_DonViThucHien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                aid_donvithuchien_ = Convert.ToInt32(searchLookUp_DonViThucHien.EditValue.ToString());
                Load_DaTa(aid_theloai_, aid_donvibaocao_, aid_donvithuchien_, aid_ketquaxetduyet_, atunam_, adennam_);
            }
            catch
            {
                Load_DaTa(0, 0, 0, 0, 2017, 2022);
            }
        }

        private void btReshesh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        public static int mid_sk=0; public static bool mbThemmoi=false, mbsua=false, mbcopy=false;

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (KiemTra_Luu_DuLieu() == true)
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Đã có sự thay đổi dữ liệu. Có muốn lưu lại", "Lưu dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    Luu_DuLieu();
                }
                else this.Close();
            }
            else this.Close();

        }
        DataTable dt_Change_ = new DataTable();
        private bool KiemTra_Luu_DuLieu()
        {
            dt_Change_ = new DataTable();
            DataTable dt2 = (DataTable)gridControl1.DataSource;
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            dt = dt2.Copy();

            dt.DefaultView.RowFilter = "Change='0'";
            dv = dt.DefaultView;
            dt_Change_ = dv.ToTable();

            if (dt_Change_.Rows.Count > 0)
            {
                return true;
            }
            else return false;

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == cltensangkien|| e.Column==clnambaocao|| e.Column==clnamdexuat|| e.Column==clid_muckhenthuong|| e.Column==clid_ketquaxetduyet)
            {
                gridView1.SetRowCellValue(e.RowHandle, clChange, "0");
            }
            
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
               string change = View.GetRowCellValue(e.RowHandle, View.Columns["Change"]).ToString();
                if (change == "0")
                {
                    e.Appearance.BackColor = Color.PaleTurquoise;

                }
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu_DuLieu();
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemmoi = true;
            mbsua = false;
            mbcopy = false;           
            frmChiTiet ff = new frmChiTiet();
            ff.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid).ToString() != "")
            {
                //mbThemmoi = false;
                //mbsua = true;
                //mbcopy = false;
                //mid_sk = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                //frmChiTiet ff = new frmChiTiet();
                //ff.Show();
            }
        }

        private void btSua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid).ToString() != "")
            {
                mbThemmoi = false;
                mbsua = true;
                mbcopy = false;
                mid_sk = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                frmChiTiet ff = new frmChiTiet();
                ff.Show();
            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clid).ToString() != "")
            {
                mbThemmoi = false;
                mbsua = false;
                mbcopy = true;
                mid_sk = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                frmChiTiet ff = new frmChiTiet();
                ff.Show();
            }
        }

        private void quảnTrịĐơnVịBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmQuanLyDonVi ff = new QLKH2021.frmQuanLyDonVi(true);
            frmQuanLyDonVi ff = new frmQuanLyDonVi(true,this);
            ff.Show();
        }

        private void quảnTrịĐơnVịTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmQuanLyDonVi ff = new QLKH2021.frmQuanLyDonVi(false);
            frmQuanLyDonVi ff = new frmQuanLyDonVi(true, this);
            ff.Show();
        }

        private void Luu_DuLieu()
        {
            if (!KiemTra_Luu_DuLieu()) return;
            else
            {
                for (int i = 0; i < dt_Change_.Rows.Count; i++)
                {
                    clsTbsangkien cls1 = new clsTbsangkien();
                    int _xid_ = Convert.ToInt32(dt_Change_.Rows[i]["id"].ToString());
                    int _xnambaocao_ = Convert.ToInt32(dt_Change_.Rows[i]["nambaocao"].ToString());
                    int _xnamdexuat = Convert.ToInt32(dt_Change_.Rows[i]["namdexuat"].ToString());
                    string _stensk = dt_Change_.Rows[i]["tensangkien"].ToString();
                    int _xmuckhenthuong = Convert.ToInt32(dt_Change_.Rows[i]["id_muckhenthuong"].ToString());
                    int _xketquaxetduyet = Convert.ToInt32(dt_Change_.Rows[i]["id_ketquaxetduyet"].ToString());
                    cls1.Update_5(_xid_, _xnambaocao_, _xnamdexuat, _stensk, _xmuckhenthuong, _xketquaxetduyet);
                }
                MessageBox.Show("Đã lưu");
            }

        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue(clid).ToString()!="")
            {
                mbThemmoi = false;
                mbsua = true;
                mbcopy = false;
                mid_sk = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                frmChiTiet ff = new frmChiTiet();
                ff.Show();
            }
        }
    }
}