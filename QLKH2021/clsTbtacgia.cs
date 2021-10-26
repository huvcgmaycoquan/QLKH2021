using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKH2021
{
	public partial class clsTbtacgia : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTontai;
			private SqlInt32		m_iId_loaicanbo, m_iIdhocvi, m_iId, m_iTacgiachinh_0_phu1, m_iIdcapbac, m_iId_sangkien, m_iIdhocham;
			private SqlString		m_sHienthiten, m_sTen;
		#endregion


		public clsTbtacgia()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbtacgia_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_sangkien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_sangkien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sten", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iidcapbac", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIdcapbac));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iidhocham", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIdhocham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iidhocvi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIdhocvi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@shienthiten", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sHienthiten));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_loaicanbo", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_loaicanbo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@itacgiachinh_0_phu1", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iTacgiachinh_0_phu1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));
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
				throw new Exception("clsTbtacgia::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbtacgia_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_sangkien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_sangkien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sten", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iidcapbac", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIdcapbac));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iidhocham", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIdhocham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iidhocvi", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIdhocvi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@shienthiten", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sHienthiten));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_loaicanbo", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_loaicanbo));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@itacgiachinh_0_phu1", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iTacgiachinh_0_phu1));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@btontai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTontai));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbtacgia::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbtacgia_Delete]";
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
				throw new Exception("clsTbtacgia::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbtacgia_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbtacgia");
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
					m_iId_sangkien = (Int32)dtToReturn.Rows[0]["id_sangkien"];
					m_sTen = (string)dtToReturn.Rows[0]["ten"];
					m_iIdcapbac = (Int32)dtToReturn.Rows[0]["idcapbac"];
					m_iIdhocham = (Int32)dtToReturn.Rows[0]["idhocham"];
					m_iIdhocvi = (Int32)dtToReturn.Rows[0]["idhocvi"];
					m_sHienthiten = (string)dtToReturn.Rows[0]["hienthiten"];
					m_iId_loaicanbo = (Int32)dtToReturn.Rows[0]["id_loaicanbo"];
					m_iTacgiachinh_0_phu1 = (Int32)dtToReturn.Rows[0]["tacgiachinh_0_phu1"];
					m_bTontai = (bool)dtToReturn.Rows[0]["tontai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbtacgia::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbtacgia_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbtacgia");
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
				throw new Exception("clsTbtacgia::SelectAll::Error occured.", ex);
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


		public SqlInt32 iId_sangkien
		{
			get
			{
				return m_iId_sangkien;
			}
			set
			{
				SqlInt32 iId_sangkienTmp = (SqlInt32)value;
				if(iId_sangkienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_sangkien", "iId_sangkien can't be NULL");
				}
				m_iId_sangkien = value;
			}
		}


		public SqlString sTen
		{
			get
			{
				return m_sTen;
			}
			set
			{
				SqlString sTenTmp = (SqlString)value;
				if(sTenTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTen", "sTen can't be NULL");
				}
				m_sTen = value;
			}
		}


		public SqlInt32 iIdcapbac
		{
			get
			{
				return m_iIdcapbac;
			}
			set
			{
				SqlInt32 iIdcapbacTmp = (SqlInt32)value;
				if(iIdcapbacTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iIdcapbac", "iIdcapbac can't be NULL");
				}
				m_iIdcapbac = value;
			}
		}


		public SqlInt32 iIdhocham
		{
			get
			{
				return m_iIdhocham;
			}
			set
			{
				SqlInt32 iIdhochamTmp = (SqlInt32)value;
				if(iIdhochamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iIdhocham", "iIdhocham can't be NULL");
				}
				m_iIdhocham = value;
			}
		}


		public SqlInt32 iIdhocvi
		{
			get
			{
				return m_iIdhocvi;
			}
			set
			{
				SqlInt32 iIdhocviTmp = (SqlInt32)value;
				if(iIdhocviTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iIdhocvi", "iIdhocvi can't be NULL");
				}
				m_iIdhocvi = value;
			}
		}


		public SqlString sHienthiten
		{
			get
			{
				return m_sHienthiten;
			}
			set
			{
				SqlString sHienthitenTmp = (SqlString)value;
				if(sHienthitenTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sHienthiten", "sHienthiten can't be NULL");
				}
				m_sHienthiten = value;
			}
		}


		public SqlInt32 iId_loaicanbo
		{
			get
			{
				return m_iId_loaicanbo;
			}
			set
			{
				SqlInt32 iId_loaicanboTmp = (SqlInt32)value;
				if(iId_loaicanboTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iId_loaicanbo", "iId_loaicanbo can't be NULL");
				}
				m_iId_loaicanbo = value;
			}
		}


		public SqlInt32 iTacgiachinh_0_phu1
		{
			get
			{
				return m_iTacgiachinh_0_phu1;
			}
			set
			{
				SqlInt32 iTacgiachinh_0_phu1Tmp = (SqlInt32)value;
				if(iTacgiachinh_0_phu1Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iTacgiachinh_0_phu1", "iTacgiachinh_0_phu1 can't be NULL");
				}
				m_iTacgiachinh_0_phu1 = value;
			}
		}


		public SqlBoolean bTontai
		{
			get
			{
				return m_bTontai;
			}
			set
			{
				SqlBoolean bTontaiTmp = (SqlBoolean)value;
				if(bTontaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTontai", "bTontai can't be NULL");
				}
				m_bTontai = value;
			}
		}
		#endregion
	}
}
