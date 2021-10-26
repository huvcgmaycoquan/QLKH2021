using DevExpress.XtraGrid;
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
    public partial class frmQuanLyDonVi : Form
    {
        bool donvibaocao_True_donvithuchien_false;
       
        frmChiTiet _frmChiTiet;
        Form1 _form1;       
        public frmQuanLyDonVi(bool xx_donvibaocao_True_donvithuchien_false,frmChiTiet frmCTNCC, Form1 form1_)
        {
            _frmChiTiet = frmCTNCC;
            _form1 = form1_;
            donvibaocao_True_donvithuchien_false = xx_donvibaocao_True_donvithuchien_false;
            InitializeComponent();
        }
        public frmQuanLyDonVi(bool xx_donvibaocao_True_donvithuchien_false, frmChiTiet frmCTNCC)
        {
            _frmChiTiet = frmCTNCC;            
            donvibaocao_True_donvithuchien_false = xx_donvibaocao_True_donvithuchien_false;
            InitializeComponent();
        }

        public frmQuanLyDonVi(bool xx_donvibaocao_True_donvithuchien_false, Form1 form1_)
        {
            _form1 = form1_;
            //_form1 = form1_;
            donvibaocao_True_donvithuchien_false = xx_donvibaocao_True_donvithuchien_false;
            InitializeComponent();
        }
        private void Load_DaTa()
        {
            if(donvibaocao_True_donvithuchien_false==true)
            {
                clsTbdonvibaocao cls = new QLKH2021.clsTbdonvibaocao();
                DataTable dt = cls.SelectAll();
                gridControl1.DataSource = dt;
            }
            else
            {
                clsTbdonvithuchien cls = new QLKH2021.clsTbdonvithuchien();
                DataTable dt = cls.SelectAll();
                gridControl1.DataSource = dt;
            }
        }
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void frmQuanLyDonVi_Load(object sender, EventArgs e)
        {
            Load_DaTa();
        }
        
        private bool kiemtraluu()
        {
            if (gridView1.GetFocusedRowCellValue(cltendonvi).ToString() == "")
                return false;
            else if (gridView1.GetFocusedRowCellValue(cltendonvi).ToString() != "")
            {
                string xxten = gridView1.GetFocusedRowCellValue(cltendonvi).ToString();
                if (donvibaocao_True_donvithuchien_false == true)
                {
                    clsTbdonvibaocao cls = new clsTbdonvibaocao();
                    DataTable dt = cls.tbdonvibao_SO_kiemtra_trungTen(xxten);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Đã có tên đơn vị: " + xxten + ".\n Vui lòng kiểm tra lại");
                        return false;
                    }
                    else return true;
                }
                else
                {
                    clsTbdonvithuchien cls = new QLKH2021.clsTbdonvithuchien();                   
                    DataTable dt = cls.tbdonvithuchien_SO_kiemtra_trungTen(xxten);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Đã có tên đơn vị: " + xxten + ".\n Vui lòng kiểm tra lại");
                        return false;
                    }
                    else return true;
                }
                
            }
            else return true;
        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (kiemtraluu() == false) return;
            else
            {
                if (donvibaocao_True_donvithuchien_false == true)
                {
                    clsTbdonvibaocao cls = new QLKH2021.clsTbdonvibaocao();
                    cls.sTendonvi = gridView1.GetFocusedRowCellValue(cltendonvi).ToString();
                    cls.iKhoa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clKhoa).ToString());
                    if (gridView1.GetFocusedRowCellValue(clid).ToString() == "")
                        cls.Insert();
                    else
                    {
                        int xxid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                        cls.iId = xxid;
                        cls.Update();
                    }
                    
                }
                else
                {

                    clsTbdonvithuchien cls = new QLKH2021.clsTbdonvithuchien();
                    cls.sTendonvi = gridView1.GetFocusedRowCellValue(cltendonvi).ToString();
                    cls.iKhoa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clKhoa).ToString());
                    if (gridView1.GetFocusedRowCellValue(clid).ToString() == "")
                        cls.Insert();
                    else
                    {
                        int xxid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                        cls.iId = xxid;
                        cls.Update();
                    }                   
                }

            }
           

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue(clKhoa, 0);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string xxten = gridView1.GetFocusedRowCellValue(cltendonvi).ToString();
            if (gridView1.GetFocusedRowCellValue(clid).ToString()!="")
            {
                int xxkhoa = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clKhoa).ToString());
                if (xxkhoa == 1)
                {
                    
                    MessageBox.Show("Đơn vị: " + xxten + " đã lưu trong CSDL.\n Không thể xoá !");
                    return;
                }
                else
                {
                    DialogResult traloi = MessageBox.Show("Xóa hết dữ liệu đơn vị: " + xxten + "", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (traloi == DialogResult.Yes)
                    {
                        int xxid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clid).ToString());
                        if (donvibaocao_True_donvithuchien_false == true)
                        {
                            clsTbdonvibaocao cls = new QLKH2021.clsTbdonvibaocao();
                            cls.iId = xxid;
                            cls.Delete();
                        }
                        else
                        {
                            clsTbdonvithuchien cls = new QLKH2021.clsTbdonvithuchien();
                            cls.iId = xxid;
                            cls.Delete();
                        }
                        
                        MessageBox.Show("Đã xoá");
                        Load_DaTa();
                    }
                       
                }
            }
            else
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }


        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            string xxtendonvi_ = gridView1.GetFocusedRowCellValue(cltendonvi).ToString();         

            gridView1.AddNewRow();
            gridView1.SetRowCellValue(GridControl.NewItemRowHandle, cltendonvi, xxtendonvi_);
            gridView1.SetRowCellValue(GridControl.NewItemRowHandle, clKhoa, 0);
          
        }

        private void frmQuanLyDonVi_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmQuanLyDonVi_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (donvibaocao_True_donvithuchien_false == true)
            {
                if (_frmChiTiet != null) _frmChiTiet.Load_lockup_Lai_donvibaocao();
                          
            }
            else
            {
                _frmChiTiet.Load_lockup_Lai_donvithuchien();
            }
            
        }
    }
}
