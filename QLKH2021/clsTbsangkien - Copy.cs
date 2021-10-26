using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKH2021
{
	public partial class clsTbsangkien : clsDBInteractionBase
	{
        public void Update_5(int xid, int xinambaocao, int xinamdexuat, string xstensk, int ximuckhenthuong, int xiketqua)
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_tbsangkien_Update_5]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@inambaocao_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xinambaocao));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@inamdexuat_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xinamdexuat));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@stensangkien_", SqlDbType.NVarChar, 500, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, xstensk));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_muckhenthuong_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ximuckhenthuong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iid_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xiketqua));
                
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_tbsangkien_Update_5::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SA_id_ketquaxetduyet(int xtunam, int xdennam, int xid_ketquaxetduyet)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_dvthuchien(int xtunam, int xdennam, int xid_ketquaxetduyet, int xid_donvithuchien)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_dvthuchien]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_dvthuchien", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_dvthuchien_dvbaocao(int xtunam, int xdennam, int xid_ketquaxetduyet, int xid_donvithuchien, int xxid_donvibaocao)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_dvthuchien_dvbaocao]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvibaocao_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxid_donvibaocao));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_dvthuchien_dvbaocao", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_dvbaocao(int xtunam, int xdennam, int xid_ketquaxetduyet, int xxid_donvibaocao)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_dvbaocao]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvibaocao_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxid_donvibaocao));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_dvbaocao", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_theloai(int xtunam, int xdennam, int xid_ketquaxetduyet, int xxid_theloai)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_theloai]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet_W_id_theloai");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_theloai_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxid_theloai));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_theloai", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai(int xtunam, int xdennam, int xid_ketquaxetduyet,int xid_donvithuchien, int xxid_theloai)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_theloai_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxid_theloai));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai_id_dovibaocao(int xtunam, int xdennam, int xid_ketquaxetduyet, int xid_donvithuchien, int xxid_theloai, int xid_donvibaocao)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai_id_dovibaocao]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai_id_dovibaocao");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_theloai_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxid_theloai));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvibaocao_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvibaocao));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_dvthuchien_id_theloai_id_dovibaocao", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SA_id_ketquaxetduyet_W_id_theloai_id_dovibaocao(int xtunam, int xdennam, int xid_ketquaxetduyet, int xxid_theloai, int xid_donvibaocao)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_SA_id_ketquaxetduyet_W_id_theloai_id_dovibaocao]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_SA_id_ketquaxetduyet_W_id_theloai_id_dovibaocao");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@tunam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xtunam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dennam_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xdennam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_ketquaxetduyet_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_ketquaxetduyet));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvithuchien_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvithuchien));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_theloai_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxid_theloai));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@id_donvibaocao_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xid_donvibaocao));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_SA_id_ketquaxetduyet_W_id_theloai_id_dovibaocao", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

    }
}
