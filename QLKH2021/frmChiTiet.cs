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
    public partial class frmChiTiet : Form
    {
      
        public frmChiTiet()
        {
            InitializeComponent();
        }
     
        private string biendoitrinhdo(int itrinhdo)
        {
            string strinhdo = "";
            if (itrinhdo == 3)
                strinhdo = "KS";
            else if (itrinhdo == 4)
                strinhdo = "ThS";
            else if (itrinhdo == 5)
                strinhdo = "TS";
            else strinhdo = "";
            return strinhdo;

        }
        private string biendoicapbac(int icapbac)
        {
            string scapbac = "";
            if (icapbac == 1)
                scapbac = "1/";
            else if (icapbac == 2)
                scapbac = "2/";
            else if (icapbac == 3)
                scapbac = "3/";
            else if (icapbac == 4)
                scapbac = "4/";
            else if (icapbac == 5)
                scapbac = "1//";
            else if (icapbac == 6)
                scapbac = "2//";
            else if (icapbac == 7)
                scapbac = "3//";
            else if (icapbac == 8)
                scapbac = "4//";         

            else scapbac = "";
            return scapbac;

        }
        private string Hienthi_Ten(string ten, int icapbac, int ihochoam, int ihocvi, int icanbo)
        {
            string ten_hienthi = "";
            string capbac; string hocham; string trinhdo;string loaicanbo;            
            capbac = biendoicapbac(icapbac);
            if (ihochoam == 3) hocham = "";
            else hocham = cbHocHamchinh.Text.ToString();         
            trinhdo = biendoitrinhdo(ihocvi);
            if (icanbo == 2)
                loaicanbo = "CN";
            else loaicanbo = "";
            ten_hienthi = "" + capbac + ""+loaicanbo+"," + hocham + " " + trinhdo + " " + ten + "";
            return ten_hienthi;
        }

        private void Luu_Khoa_Donvi(int id_donvibaocao, int id_donvithuchien)
        {
            clsTbdonvibaocao cls1 = new clsTbdonvibaocao();
            cls1.tbdonvibaocao_update_khoa(id_donvibaocao, true);

            clsTbdonvithuchien cls2 = new clsTbdonvithuchien();
            cls2.tbdonvithuchien_update_khoa(id_donvithuchien, true);

        }
        private void Load_lockup()
        {
            clsTbdonvibaocao cls1 = new clsTbdonvibaocao();
            DataTable dt1 = cls1.SelectAll();
           
            searchLookup_DonviBaoCao.Properties.DataSource = dt1;
            searchLookup_DonviBaoCao.Properties.ValueMember = "id";
            searchLookup_DonviBaoCao.Properties.DisplayMember = "tendonvi";           

            clsTbdonvithuchien cls2 = new clsTbdonvithuchien();
            DataTable dt2 = cls2.SelectAll();            
            searchLookUp_DonViThucHienchinh.Properties.DataSource = dt2;
            searchLookUp_DonViThucHienchinh.Properties.ValueMember = "id";
            searchLookUp_DonViThucHienchinh.Properties.DisplayMember = "tendonvi";
            

            clsTbTheLoai cls23 = new clsTbTheLoai();
            DataTable dt23 = cls23.SelectAll();           
            searchLookUp_TheLoai.Properties.DataSource = dt23;
            searchLookUp_TheLoai.Properties.ValueMember = "id";
            searchLookUp_TheLoai.Properties.DisplayMember = "theloai";
           
            clsTbketquaxetduyet cls = new clsTbketquaxetduyet();
            DataTable dt5 = cls.SelectAll();            
            searchLookUp_ketquaxetduyet.Properties.DataSource = dt5;
            searchLookUp_ketquaxetduyet.Properties.ValueMember = "id";
            searchLookUp_ketquaxetduyet.Properties.DisplayMember = "ketquaxetduyet";

            clsTbmuckhenthuong cls6 = new clsTbmuckhenthuong();
            DataTable dt65 = cls6.SelectAll();           
            searchLookUp_MucKhenThuong.Properties.DataSource = dt65;
            searchLookUp_MucKhenThuong.Properties.ValueMember = "id";
            searchLookUp_MucKhenThuong.Properties.DisplayMember = "muckhenthuong";
          
        }

        public void Load_lockup_Lai_donvibaocao() 
        {
            clsTbdonvibaocao cls1 = new clsTbdonvibaocao();
            DataTable dt1 = cls1.SelectAll();

            searchLookup_DonviBaoCao.Properties.DataSource = dt1;
            searchLookup_DonviBaoCao.Properties.ValueMember = "id";
            searchLookup_DonviBaoCao.Properties.DisplayMember = "tendonvi";
            //searchLookup_DonviBaoCao.EditValue = id_donvibaocao;            
            
        }
        public void Load_lockup_Lai_donvithuchien()
        {
            

            clsTbdonvithuchien cls2 = new clsTbdonvithuchien();
            DataTable dt2 = cls2.SelectAll();
            searchLookUp_DonViThucHienchinh.Properties.DataSource = dt2;
            searchLookUp_DonViThucHienchinh.Properties.ValueMember = "id";
            searchLookUp_DonViThucHienchinh.Properties.DisplayMember = "tendonvi";
            //searchLookup_DonviBaoCao.EditValue = id_donvithuchien;

        }
        private void Load_Combox()
        {
            clsTbcapbac cls1 = new clsTbcapbac();
            DataTable dt1 = cls1.SelectAll();
            cbCapBacchinh.DataSource = dt1;
            cbCapBacchinh.ValueMember = "id";
            cbCapBacchinh.DisplayMember = "capbac";

            clsTbhocham cls2 = new clsTbhocham();
            DataTable dt2 = cls2.SelectAll();
            cbHocHamchinh.DataSource = dt2;
            cbHocHamchinh.ValueMember = "id";
            cbHocHamchinh.DisplayMember = "hocham";

            clsTbhocvi cls3 = new clsTbhocvi();
            DataTable dt3 = cls3.SelectAll();
            cbHocVichinh.DataSource = dt3;
            cbHocVichinh.ValueMember = "id";
            cbHocVichinh.DisplayMember = "hocvi";

            clsTbloaicanbo cls4 = new clsTbloaicanbo();
            DataTable dt4 = cls4.SelectAll();
            cbloaicanbochinh.DataSource = dt4;
            cbloaicanbochinh.ValueMember = "id";
            cbloaicanbochinh.DisplayMember = "loaicanbo";
            
        }
        private void Load_DaTa(bool themmoi, int id_sk_dt)
        {
            if (themmoi == false)
            {
                clsTbsangkien cls = new clsTbsangkien();
                cls.iId = id_sk_dt;
                DataTable dt = cls.SelectOne();
                searchLookup_DonviBaoCao.EditValue = cls.iId_donvibaocao.Value;
                searchLookUp_DonViThucHienchinh.EditValue = cls.iId_donvithuchien.Value;
                searchLookUp_ketquaxetduyet.EditValue = cls.iId_ketquaxetduyet.Value;
                searchLookUp_MucKhenThuong.EditValue = cls.iId_muckhenthuong.Value;
                searchLookUp_TheLoai.EditValue = cls.iId_theloai.Value;
                txtNamBaoCao.Text = cls.iNambaocao.ToString();
                txtNamDeXuat.Text = cls.iNamdexuat.ToString();
                txtTenSK.Text = cls.sTensangkien.Value;

                clsTbtacgia cls2 = new clsTbtacgia();
                DataTable dt2 = cls2.SO_id_sk_tacgia_Chinh(id_sk_dt);
                if (dt2.Rows.Count > 0)
                {
                    txtTacGiaChinh.Text = dt2.Rows[0]["ten"].ToString();
                    cbloaicanbochinh.SelectedValue = dt2.Rows[0]["id_loaicanbo"].ToString();
                    cbCapBacchinh.SelectedValue = dt2.Rows[0]["idcapbac"].ToString();
                    cbHocHamchinh.SelectedValue = dt2.Rows[0]["idhocham"].ToString();
                    cbHocVichinh.SelectedValue = dt2.Rows[0]["idhocvi"].ToString();
                }

                clsTbtacgia cls3 = new clsTbtacgia();
                DataTable dt3 = cls3.SO_id_sk_tacgia_Phu(id_sk_dt);
                //if (dt3.Rows.Count > 0)
                //{
                    gridControl_tacgiaPhu.DataSource = dt3;
                //}


                clsTbAnh cls5 = new clsTbAnh();
                DataTable dthinhanh = cls5.tbAnh_SO_W_id_sk(id_sk_dt);
                if (dthinhanh.Rows.Count > 0)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(dthinhanh.Rows[0]["byte_anh"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    pictureEdit1.Image = Image.FromStream(stmBLOBData);
                    txtPic1.Text = dthinhanh.Rows[0]["byte_anh"].ToString();
                    txt_ID_pic1.Text = dthinhanh.Rows[0]["id"].ToString();

                    if (dthinhanh.Rows.Count > 1)
                    {

                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])(dthinhanh.Rows[1]["byte_anh"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData2);
                        pictureEdit2.Image = Image.FromStream(stmBLOBData2);
                        txtPic2.Text = dthinhanh.Rows[1]["byte_anh"].ToString();
                        txt_ID_pic2.Text = dthinhanh.Rows[1]["id"].ToString();
                    }
                    if (dthinhanh.Rows.Count > 2)
                    {
                        Byte[] byteBLOBData3 = new Byte[0];
                        byteBLOBData3 = (Byte[])(dthinhanh.Rows[2]["byte_anh"]);
                        MemoryStream stmBLOBData3 = new MemoryStream(byteBLOBData3);
                        pictureEdit3.Image = Image.FromStream(stmBLOBData3);
                        txtPic3.Text = dthinhanh.Rows[2]["byte_anh"].ToString();
                        txt_ID_pic3.Text = dthinhanh.Rows[2]["id"].ToString();
                    }
                    if (dthinhanh.Rows.Count > 3)
                    {
                        Byte[] byteBLOBData4 = new Byte[0];
                        byteBLOBData4 = (Byte[])(dthinhanh.Rows[3]["byte_anh"]);
                        MemoryStream stmBLOBData4 = new MemoryStream(byteBLOBData4);
                        pictureEdit4.Image = Image.FromStream(stmBLOBData4);
                        txtPic4.Text = dthinhanh.Rows[3]["byte_anh"].ToString();
                        txt_ID_pic4.Text = dthinhanh.Rows[3]["id"].ToString();
                    }
                }
                else
                {
                    DateTime today = DateTime.Today;
                    int adennam_ = Convert.ToInt32(today.ToString("yyyy"));
                    txtNamBaoCao.Text = adennam_.ToString();
                    txtNamDeXuat.Text = (adennam_).ToString();

                }
            }
        }

        private bool KiemTraLuu()
        {
            if (txtNamBaoCao.Text.ToString() == "")
                return false;
            else if (txtNamDeXuat.Text.ToString() == "")
                return false;
            else if (searchLookup_DonviBaoCao.EditValue==null)
                return false;
            else if (searchLookUp_DonViThucHienchinh.EditValue == null)
                return false;
            else if (searchLookUp_ketquaxetduyet.EditValue == null)
                return false;
            else if (searchLookUp_MucKhenThuong.EditValue == null)
                return false;
            else if (searchLookUp_TheLoai.EditValue == null)
                return false;
            else if (txtTenSK.Text.ToString() == "")
                return false;
            else if (txtTacGiaChinh.Text.ToString() == "")
                return false;
            else return true;
        }
      
        private void Luu_File_Anh(int id_sk_dt)
        {
            clsTbAnh cls = new clsTbAnh();            
            cls.iId_sangkien = id_sk_dt;
            cls.sDiengiai = "";
            cls.bTontai = true;
            if (txtPic1.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit1.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                cls.blobByte_anh = pic;
                if (txt_ID_pic1.Text.ToString() == "")
                {
                    cls.Insert();

                }
                else
                {
                    cls.Update();
                }
            }
            if (txtPic2.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit2.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                cls.blobByte_anh = pic;
                if (txt_ID_pic2.Text.ToString() == "")
                {
                    cls.Insert();
                }
                else
                {
                    cls.Update();
                }
            }
            if (txtPic3.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit3.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                cls.blobByte_anh = pic;
                if (txt_ID_pic3.Text.ToString() == "")
                {
                    cls.Insert();
                }
                else
                {
                    cls.Update();
                }
            }
            if (txtPic4.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit4.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                cls.blobByte_anh = pic;
                if (txt_ID_pic4.Text.ToString() == "")
                {
                    cls.Insert();
                }
                else
                {
                    cls.Update();
                }
            }
        }

        private void Luu_TacGia(int id_sk_dt)
        {
            clsTbtacgia cls2 = new clsTbtacgia();
            DataTable dt2 = cls2.SO_id_sk_tacgia_Chinh(id_sk_dt);
            cls2.iId_sangkien = id_sk_dt;
            cls2.iIdcapbac = Convert.ToInt32(cbCapBacchinh.SelectedValue);
            cls2.iIdhocham= Convert.ToInt32(cbHocHamchinh.SelectedValue);
            cls2.iIdhocvi = Convert.ToInt32(cbHocVichinh.SelectedValue);
            cls2.iId_loaicanbo = Convert.ToInt32(cbloaicanbochinh.SelectedValue);
            cls2.sTen = txtTacGiaChinh.Text;
            cls2.sHienthiten = Hienthi_Ten(txtTacGiaChinh.Text, Convert.ToInt32(cbCapBacchinh.SelectedValue), Convert.ToInt32(cbHocHamchinh.SelectedValue), Convert.ToInt32(cbHocVichinh.SelectedValue),  Convert.ToInt32(cbloaicanbochinh.SelectedValue));
            cls2.iTacgiachinh_0_phu1 = 0;
            cls2.bTontai = true;
            if (dt2.Rows.Count > 0)
            {
                int idi_tacgia_=Convert.ToInt32(dt2.Rows[0]["id"].ToString());
                cls2.iId = idi_tacgia_;
                cls2.Update();
            }
            else cls2.Insert();

            clsTbtacgia cls3 = new clsTbtacgia();
            DataTable dt2_Cu = cls3.SO_id_sk_tacgia_Phu(id_sk_dt);
            if (dt2_Cu.Rows.Count > 0)
            {
                cls3.tbtacGia_U_ALL_TonTai__Phu_W_id_SK(id_sk_dt, false);
            }

            DataTable dtkkk = (DataTable)gridControl_tacgiaPhu.DataSource;
           
            if (dtkkk!=null)
            {
                for (int i = 0; i < dtkkk.Rows.Count; i++)
                {
                    cls3.sTen = dtkkk.Rows[i]["ten"].ToString();
                    cls3.iId_sangkien = id_sk_dt;
                    cls3.iIdcapbac = 0;
                    cls3.iIdhocham = 0;
                    cls3.iIdhocvi = 0;
                    cls3.iId_loaicanbo = 0;
                    cls3.sHienthiten = "";
                    cls3.iTacgiachinh_0_phu1 = 1;
                    cls3.bTontai = true;
                   if(dtkkk.Rows[i]["id"].ToString()=="")
                    {
                        cls3.Insert();
                    }
                   else
                    {
                        int iid_tacgia = Convert.ToInt32(dtkkk.Rows[i]["id"].ToString());
                        cls3.iId = iid_tacgia;
                        cls3.Update();
                    }
                    //string expression;
                    //expression = "id=" + iid_tacgia + "";
                    //DataRow[] foundRows;
                    //foundRows = dt2_Cu.Select(expression);
                    //if (foundRows.Length > 0)
                    //{
                    //    cls3.iId = Convert.ToInt32(foundRows[0]["id"].ToString());
                    //    cls3.Update();
                    //}
                    //else
                    //{
                    //    cls3.Insert();
                    //}
                }
            }
            // xoa ton tai=false
            cls3 = new clsTbtacgia();
            DataTable dt2_moi11111 = cls3.SO_id_sk_tacgia_Phu(id_sk_dt);
            dt2_moi11111.DefaultView.RowFilter = "tontai = False";
            DataView dvdt2_moi = dt2_moi11111.DefaultView;
            DataTable dt2_moi = dvdt2_moi.ToTable();
            for (int i = 0; i < dt2_moi.Rows.Count; i++)
            {

                cls3.iId = Convert.ToInt32(dt2_moi.Rows[i]["id"].ToString());
                cls3.Delete();
            }



        }
        private void LuuDuLieu()
        {
            if (KiemTraLuu() == false) return;
            else
            {
                clsTbsangkien cls = new QLKH2021.clsTbsangkien();
                cls.daNgaylap = DateTime.Today;
                cls.iNambaocao = Convert.ToInt32(txtNamBaoCao.Text);
                cls.iNamdexuat = Convert.ToInt32(txtNamDeXuat.Text);
                cls.iId_donvibaocao = Convert.ToInt32(searchLookup_DonviBaoCao.EditValue.ToString());              
                cls.sTensangkien = txtTenSK.Text;
                cls.iId_theloai= Convert.ToInt32(searchLookUp_TheLoai.EditValue.ToString());
                cls.iId_donvithuchien = Convert.ToInt32(searchLookUp_DonViThucHienchinh.EditValue.ToString());
                cls.iId_muckhenthuong =  Convert.ToInt32(searchLookUp_MucKhenThuong.EditValue.ToString());
                cls.iId_ketquaxetduyet = Convert.ToInt32(searchLookUp_ketquaxetduyet.EditValue.ToString());
                cls.iKhoa = 0;
                if (Form1.mbsua==false)
                {                   
                    cls.Insert();
                }
                else
                {
                    cls.iId = Form1.mid_sk;
                    cls.Update();
                }
                int iiid_skdt = cls.iId.Value;
             
                Luu_File_Anh(iiid_skdt);
                Luu_TacGia(iiid_skdt);
                Luu_Khoa_Donvi(Convert.ToInt32(searchLookup_DonviBaoCao.EditValue.ToString()), Convert.ToInt32(searchLookUp_DonViThucHienchinh.EditValue.ToString()));
                MessageBox.Show("Đã lưu");
                this.Close();
            }
        }
        public void frmChiTiet_Load(object sender, EventArgs e)
        {
            Load_Combox();
            Load_lockup();
            Load_DaTa(Form1.mbThemmoi, Form1.mid_sk);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       

        private void Sua_pic1_Click(object sender, EventArgs e)
        {
            Stream mystremmxx = null;
            OpenFileDialog ff = new OpenFileDialog();
            ff.Filter = "Image file(*.jpg; *.jpeg; *.bmp)| *.jpg;*.jpeg;*.bmp";
            if (ff.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystremmxx = ff.OpenFile()) != null)
                    {

                        string filename = ff.FileName;
                        txtPic1.Text = filename.ToString();
                        pictureEdit1.Image = Image.FromFile(filename);
                    }
                }
                catch
                {

                }

            }
        }

        private void Xoa_Pic1_Click(object sender, EventArgs e)
        {
            if (txt_ID_pic1.Text.ToString() != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    clsTbAnh cls = new clsTbAnh();
                    cls.iId = Convert.ToInt32(txt_ID_pic1.Text.ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    pictureEdit1.Image = null;
                    txt_ID_pic1.Text = "";
                    txtPic1.ResetText();
                }
            }
        }

        private void Sua_pic2_Click(object sender, EventArgs e)
        {
            Stream mystremmxx = null;
            OpenFileDialog ff = new OpenFileDialog();
            ff.Filter = "Image file(*.jpg; *.jpeg; *.bmp)| *.jpg;*.jpeg;*.bmp";
            if (ff.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystremmxx = ff.OpenFile()) != null)
                    {

                        string filename = ff.FileName;
                        txtPic2.Text = filename.ToString();
                        pictureEdit2.Image = Image.FromFile(filename);
                    }
                }
                catch
                {

                }

            }
        }

        private void Xoa_pic2_Click(object sender, EventArgs e)
        {
            if (txt_ID_pic2.Text.ToString() != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    clsTbAnh cls = new clsTbAnh();
                    cls.iId = Convert.ToInt32(txt_ID_pic2.Text.ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    pictureEdit2.Image = null;
                    txt_ID_pic2.Text = "";
                    txtPic2.ResetText();
                }
            }
        }

        private void Sua_pic3_Click(object sender, EventArgs e)
        {
            Stream mystremmxx = null;
            OpenFileDialog ff = new OpenFileDialog();
            ff.Filter = "Image file(*.jpg; *.jpeg; *.bmp)| *.jpg;*.jpeg;*.bmp";
            if (ff.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystremmxx = ff.OpenFile()) != null)
                    {

                        string filename = ff.FileName;
                        txtPic3.Text = filename.ToString();
                        pictureEdit3.Image = Image.FromFile(filename);
                    }
                }
                catch
                {

                }

            }
        }

        private void Xoa_pic3_Click(object sender, EventArgs e)
        {
            if (txt_ID_pic3.Text.ToString() != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    clsTbAnh cls = new clsTbAnh();
                    cls.iId = Convert.ToInt32(txt_ID_pic3.Text.ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    pictureEdit3.Image = null;
                    txt_ID_pic3.Text = "";
                    txtPic3.ResetText();
                }
            }
        }

        private void Sua_pic4_Click(object sender, EventArgs e)
        {
            Stream mystremmxx = null;
            OpenFileDialog ff = new OpenFileDialog();
            ff.Filter = "Image file(*.jpg; *.jpeg; *.bmp)| *.jpg;*.jpeg;*.bmp";
            if (ff.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystremmxx = ff.OpenFile()) != null)
                    {

                        string filename = ff.FileName;
                        txtPic4.Text = filename.ToString();
                        pictureEdit4.Image = Image.FromFile(filename);
                    }
                }
                catch
                {

                }

            }
        }

        private void Xoa_pic4_Click(object sender, EventArgs e)
        {

            if (txt_ID_pic4.Text.ToString() != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    clsTbAnh cls = new clsTbAnh();
                    cls.iId = Convert.ToInt32(txt_ID_pic4.Text.ToString());
                    cls.Delete();
                    MessageBox.Show("Đã xoá");
                    pictureEdit4.Image = null;
                    txt_ID_pic4.Text = "";
                    txtPic4.ResetText();
                }
            }
        }

        private void frmChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            //LuuDuLieu();
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            if (txtPic1.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit1.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                MemoryStream stmBLOBData = new MemoryStream(pic);
                frmImage_Full ff = new frmImage_Full(stmBLOBData);
                ff.ShowDialog();
            }
        }

        private void gridView_TacGiaPhu_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
                e.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void pictureEdit2_DoubleClick(object sender, EventArgs e)
        {
            if (txtPic2.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit2.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                MemoryStream stmBLOBData = new MemoryStream(pic);
                frmImage_Full ff = new frmImage_Full(stmBLOBData);
                ff.ShowDialog();
            }
        }

        private void pictureEdit3_DoubleClick(object sender, EventArgs e)
        {
            if (txtPic3.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit3.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                MemoryStream stmBLOBData = new MemoryStream(pic);
                frmImage_Full ff = new frmImage_Full(stmBLOBData);
                ff.ShowDialog();
            }
        }

        private void pictureEdit4_DoubleClick(object sender, EventArgs e)
        {
            if (txtPic4.Text.ToString() != "")
            {
                MemoryStream stremxx = new MemoryStream();
                pictureEdit4.Image.Save(stremxx, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stremxx.ToArray();
                MemoryStream stmBLOBData = new MemoryStream(pic);
                frmImage_Full ff = new frmImage_Full(stmBLOBData);
                ff.ShowDialog();
            }
        }

        private void btLuu_Click_1(object sender, EventArgs e)
        {
            LuuDuLieu();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmQuanLyDonVi ff = new frmQuanLyDonVi(true,this);
            ff.Show();
        }

        private void btThemDonViThucHien_Click(object sender, EventArgs e)
        {
            frmQuanLyDonVi ff = new frmQuanLyDonVi(false, this);
            ff.Show();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
