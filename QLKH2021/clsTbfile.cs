using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKH2021
{
	public partial class clsTbfile : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlInt32		m_iAnh_0_word_1_pdf_2, m_iId_sangkien, m_iId;
			private SqlString		m_sDuongdanfile, m_sChuthich;
		#endregion


		public clsTbfile()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbfile_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_sangkien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_sangkien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sduongdanfile", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDuongdanfile));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@schuthich", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sChuthich));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ianh_0_word_1_pdf_2", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iAnh_0_word_1_pdf_2));
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
				throw new Exception("clsTbfile::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbfile_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_sangkien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iId_sangkien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sduongdanfile", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDuongdanfile));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@schuthich", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sChuthich));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ianh_0_word_1_pdf_2", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iAnh_0_word_1_pdf_2));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbfile::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbfile_Delete]";
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
				throw new Exception("clsTbfile::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbfile_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbfile");
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
					m_sDuongdanfile = (string)dtToReturn.Rows[0]["duongdanfile"];
					m_sChuthich = (string)dtToReturn.Rows[0]["chuthich"];
					m_iAnh_0_word_1_pdf_2 = (Int32)dtToReturn.Rows[0]["anh_0_word_1_pdf_2"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbfile::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbfile_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbfile");
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
				throw new Exception("clsTbfile::SelectAll::Error occured.", ex);
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


		public SqlString sDuongdanfile
		{
			get
			{
				return m_sDuongdanfile;
			}
			set
			{
				SqlString sDuongdanfileTmp = (SqlString)value;
				if(sDuongdanfileTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDuongdanfile", "sDuongdanfile can't be NULL");
				}
				m_sDuongdanfile = value;
			}
		}


		public SqlString sChuthich
		{
			get
			{
				return m_sChuthich;
			}
			set
			{
				SqlString sChuthichTmp = (SqlString)value;
				if(sChuthichTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sChuthich", "sChuthich can't be NULL");
				}
				m_sChuthich = value;
			}
		}


		public SqlInt32 iAnh_0_word_1_pdf_2
		{
			get
			{
				return m_iAnh_0_word_1_pdf_2;
			}
			set
			{
				SqlInt32 iAnh_0_word_1_pdf_2Tmp = (SqlInt32)value;
				if(iAnh_0_word_1_pdf_2Tmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iAnh_0_word_1_pdf_2", "iAnh_0_word_1_pdf_2 can't be NULL");
				}
				m_iAnh_0_word_1_pdf_2 = value;
			}
		}
		#endregion
	}
}
