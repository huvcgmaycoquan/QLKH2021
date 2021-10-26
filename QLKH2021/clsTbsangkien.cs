using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKH2021
{
	public partial class clsTbsangkien : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlDateTime		m_daNgaylap;
			private SqlInt32		m_iId_donvithuchien, m_iId_theloai, m_iId_ketquaxetduyet, m_iId_muckhenthuong, m_iKhoa, m_iNambaocao, m_iId, m_iId_donvibaocao, m_iNamdexuat;
			private SqlString		m_sTensangkien;
		#endregion


		public clsTbsangkien()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbsangkien_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangaylap", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgaylap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@inambaocao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNambaocao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@inamdexuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNamdexuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_donvibaocao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_donvibaocao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stensangkien", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTensangkien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_theloai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_theloai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_donvithuchien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_donvithuchien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_muckhenthuong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_muckhenthuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_ketquaxetduyet", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_ketquaxetduyet));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iKhoa", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iId));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iId = (SqlInt32)scmCmdToExecute.Parameters["@iid"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbsangkien::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbsangkien_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dangaylap", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgaylap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@inambaocao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNambaocao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@inamdexuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNamdexuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_donvibaocao", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_donvibaocao));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@stensangkien", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTensangkien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_theloai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_theloai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_donvithuchien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_donvithuchien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_muckhenthuong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_muckhenthuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_ketquaxetduyet", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_ketquaxetduyet));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iKhoa", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iKhoa));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbsangkien::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbsangkien_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbsangkien::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbsangkien_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbsangkien");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iId = (Int32)dtToReturn.Rows[0]["id"];
					m_daNgaylap = (DateTime)dtToReturn.Rows[0]["ngaylap"];
					m_iNambaocao = (Int32)dtToReturn.Rows[0]["nambaocao"];
					m_iNamdexuat = (Int32)dtToReturn.Rows[0]["namdexuat"];
					m_iId_donvibaocao = (Int32)dtToReturn.Rows[0]["id_donvibaocao"];
					m_sTensangkien = (string)dtToReturn.Rows[0]["tensangkien"];
					m_iId_theloai = (Int32)dtToReturn.Rows[0]["id_theloai"];
					m_iId_donvithuchien = (Int32)dtToReturn.Rows[0]["id_donvithuchien"];
					m_iId_muckhenthuong = (Int32)dtToReturn.Rows[0]["id_muckhenthuong"];
					m_iId_ketquaxetduyet = (Int32)dtToReturn.Rows[0]["id_ketquaxetduyet"];
					m_iKhoa = (Int32)dtToReturn.Rows[0]["Khoa"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbsangkien::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbsangkien_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbsangkien");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbsangkien::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 iId
		{
			get
			{
				return m_iId;
			}
			set
			{
				SqlInt32 iIdTmp = (SqlInt32)value;
				if(iIdTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId", "iId can't be NULL");
				}
				m_iId = value;
			}
		}


		public SqlDateTime daNgaylap
		{
			get
			{
				return m_daNgaylap;
			}
			set
			{
				SqlDateTime daNgaylapTmp = (SqlDateTime)value;
				if(daNgaylapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgaylap", "daNgaylap can't be NULL");
				}
				m_daNgaylap = value;
			}
		}


		public SqlInt32 iNambaocao
		{
			get
			{
				return m_iNambaocao;
			}
			set
			{
				SqlInt32 iNambaocaoTmp = (SqlInt32)value;
				if(iNambaocaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iNambaocao", "iNambaocao can't be NULL");
				}
				m_iNambaocao = value;
			}
		}


		public SqlInt32 iNamdexuat
		{
			get
			{
				return m_iNamdexuat;
			}
			set
			{
				SqlInt32 iNamdexuatTmp = (SqlInt32)value;
				if(iNamdexuatTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iNamdexuat", "iNamdexuat can't be NULL");
				}
				m_iNamdexuat = value;
			}
		}


		public SqlInt32 iId_donvibaocao
		{
			get
			{
				return m_iId_donvibaocao;
			}
			set
			{
				SqlInt32 iId_donvibaocaoTmp = (SqlInt32)value;
				if(iId_donvibaocaoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_donvibaocao", "iId_donvibaocao can't be NULL");
				}
				m_iId_donvibaocao = value;
			}
		}


		public SqlString sTensangkien
		{
			get
			{
				return m_sTensangkien;
			}
			set
			{
				SqlString sTensangkienTmp = (SqlString)value;
				if(sTensangkienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTensangkien", "sTensangkien can't be NULL");
				}
				m_sTensangkien = value;
			}
		}


		public SqlInt32 iId_theloai
		{
			get
			{
				return m_iId_theloai;
			}
			set
			{
				SqlInt32 iId_theloaiTmp = (SqlInt32)value;
				if(iId_theloaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_theloai", "iId_theloai can't be NULL");
				}
				m_iId_theloai = value;
			}
		}


		public SqlInt32 iId_donvithuchien
		{
			get
			{
				return m_iId_donvithuchien;
			}
			set
			{
				SqlInt32 iId_donvithuchienTmp = (SqlInt32)value;
				if(iId_donvithuchienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_donvithuchien", "iId_donvithuchien can't be NULL");
				}
				m_iId_donvithuchien = value;
			}
		}


		public SqlInt32 iId_muckhenthuong
		{
			get
			{
				return m_iId_muckhenthuong;
			}
			set
			{
				SqlInt32 iId_muckhenthuongTmp = (SqlInt32)value;
				if(iId_muckhenthuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_muckhenthuong", "iId_muckhenthuong can't be NULL");
				}
				m_iId_muckhenthuong = value;
			}
		}


		public SqlInt32 iId_ketquaxetduyet
		{
			get
			{
				return m_iId_ketquaxetduyet;
			}
			set
			{
				SqlInt32 iId_ketquaxetduyetTmp = (SqlInt32)value;
				if(iId_ketquaxetduyetTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_ketquaxetduyet", "iId_ketquaxetduyet can't be NULL");
				}
				m_iId_ketquaxetduyet = value;
			}
		}


		public SqlInt32 iKhoa
		{
			get
			{
				return m_iKhoa;
			}
			set
			{
				SqlInt32 iKhoaTmp = (SqlInt32)value;
				if(iKhoaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iKhoa", "iKhoa can't be NULL");
				}
				m_iKhoa = value;
			}
		}
		#endregion
	}
}
