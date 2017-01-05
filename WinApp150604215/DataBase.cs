using System;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinApp150604215
{
    public class DataBase
    {
        private string strConn = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;//数据库连接信息
        private OleDbConnection _oleDbConn;//Access数据库连接对象
        /// <summary>
        /// 连接是否打开
        /// </summary>
        public bool ConIsOpen()
        {
            try
            {
                _oleDbConn = new OleDbConnection(strConn);//根据链接信息实例化链接对象
                _oleDbConn.Open();//打开连接;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (_oleDbConn.State == ConnectionState.Open)
                {
                    _oleDbConn.Close();
                }

            }
        }
        /// <summary>
        /// 打开连接
        /// </summary>
        public bool Open()
        {
            try
            {
                _oleDbConn = new OleDbConnection(strConn);//根据链接信息实例化链接对象
                _oleDbConn.Open();//打开连接;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 获取一条user的信息
        /// </summary>
        /// <param name="ID">combobox.Text</param>
        /// <returns>ArrayList</returns>
        public ArrayList GetOneInfo(string ID)
        {
            try
            {
                this.Open();
                ArrayList list = new ArrayList();
                OleDbCommand oleCom = new OleDbCommand("select * from UserLogin where ID=?", _oleDbConn);
                oleCom.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 4)).Value = ID;
                OleDbDataReader oleReader = oleCom.ExecuteReader();
                if (oleReader.Read())
                {
                    list.Add(oleReader["UserName"].ToString());
                    list.Add(oleReader["major"].ToString());
                    list.Add(oleReader["SEX"].ToString());
                    list.Add(oleReader["photo"].ToString());
                    list.Add(oleReader["xuehao"].ToString());
                }
                oleReader.Close();
                _oleDbConn.Close();
                return list;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }

        }

        /// <summary>
        /// 返回一个包含UserID的List
        /// </summary>
        /// <returns> List<> </returns>
        public List<string> GetUserLoginID()
        {
            this.Open();
            List<string> list2;
            OleDbCommand command = new OleDbCommand("select ID from UserLogin", _oleDbConn);//生成一个选择_oleDbConn连接的UserLogin表中所有ID的command语句
            OleDbDataReader olereader = command.ExecuteReader();
            List<string> list = new List<string>();
            try
            {
                while (olereader.Read())
                {
                    list.Add(olereader["ID"].ToString());
                }
                list2 = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                list2 = null;
            }
            finally
            {
                olereader.Close();
                _oleDbConn.Close();
            }
            return list2;
        }
        /// <summary>
        /// 向数据库增加一个用户信息
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="xuehao"></param>
        /// <param name="major"></param>
        /// <param name="SEX"></param>
        /// <param name="photo"></param>
        public void InsertUser(string UserName, string xuehao, string major, string SEX, string photo)
        {
            try
            {
                this.Open();
                // OleDbCommand command = new OleDbCommand("INSERT INTO UserLogin(UserName,xuehao,major,SEX) values('UserName',xuehao,'major',True)", _oleDbConn);
                string commSql = "INSERT INTO UserLogin(UserName,xuehao,major,SEX,photo) values(" + "'" + UserName + "'," + xuehao.ToString() + ",'" + major + "'," + SEX + ",'" + photo + "')";
                new OleDbCommand(commSql, _oleDbConn).ExecuteNonQuery();
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("请完整填入数据");
            }


        }
        /// <summary>
        /// 删除一条用户信息
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteUserInfo(string ID)
        {
            try
            {
                this.Open();
                string commSql = "delete from UserLogin where ID = " + ID;
                new OleDbCommand(commSql, _oleDbConn).ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="UserName"></param>
        /// <param name="xuehao"></param>
        /// <param name="major"></param>
        /// <param name="SEX"></param>
        /// <param name="photo"></param>
        public void ModifyUserInfo(string ID, string UserName, string xuehao, string major, string SEX, string photo)
        {
            try
            {
                this.Open();
                string commSql = String.Empty;
                if (photo == string.Empty)
                {
                    commSql = "update UserLogin set UserName = '" + UserName + "' , xuehao = " + xuehao + " , major = '" + major + "' , SEX =" + SEX + " where ID =" + ID;
                }
                else
                {
                    commSql = "update UserLogin set UserName = '" + UserName + "' , xuehao = " + xuehao + " , major = '" + major + "' , SEX =" + SEX + ",photo = '"+photo+"'"+" where ID =" + ID;
                }
                new OleDbCommand(commSql, _oleDbConn).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取用户所有的信息
        /// </summary>
        /// <returns></returns>
        public OleDbDataAdapter GetAllUserInfo()
        {
            this.Open();
            OleDbDataAdapter oleda = new OleDbDataAdapter("SELECT UserName as 姓名 ,xuehao as 学号 , major as 专业 , SEX as 性别 , photo as 照片 from UserLogin",_oleDbConn);
            //DataSet ds = new DataSet();
            //OleDbCommand cmd = new OleDbCommand("select * from UserLogin", _oleDbConn);
            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            //dataAdapter.Fill(ds);
            //cmd.Dispose();
            //Close();
            //dataAdapter.Dispose();
            //return ds;
            return oleda;
        
        }
        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="query">查询的列</param>
        /// <param name="queryinfo">查询的值</param>
        /// <returns></returns>
        public OleDbDataAdapter QueryUserinfo(string query, string queryinfo)
        {
            this.Open();
            if (query == "姓名")
            {
                query = "UserName";
            }
            if (query == "学号")
            {
                query = "xuehao";              
            }
            if (query == "专业")
            {
                query = "major";                
            }         
            string strcomm = "SELECT UserName as 姓名 ,xuehao as 学号 , major as 专业 , SEX as 性别 , photo as 照片 from UserLogin where " + query + " = ?";
            OleDbCommand oleCom = new OleDbCommand(strcomm, _oleDbConn);
            oleCom.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 4)).Value = queryinfo;
            return new OleDbDataAdapter(oleCom);                    
        }
        ///// <summary>
        ///// 创建一个命令对象并返回该对象
        ///// </summary>
        ///// <param name="sqlStr">数据库语句</param>
        ///// <param name="file">数据库所在路径</param>
        ///// <returns>OleDbCommand</returns>
        ///// 
        //private OleDbCommand CreateCommand(string sqlStr, string file)
        //{
        //    // Open(file);
        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = sqlStr;
        //    cmd.Connection = _oleDbConn;
        //    return cmd;
        //}
        ///// <summary>
        ///// 执行
        ///// </summary>
        ///// <param name = "sqlStr" > SQL语句 </ param >
        ///// < param name="file">数据库所在路径</param>
        ///// <returns>返回数值当执行成功时候返回true,失败则返回false</returns>
        //public bool ExecuteNonQury(string sqlStr, string file)
        //{
        //    OleDbCommand cmd = CreateCommand(sqlStr, file);
        //    int result = cmd.ExecuteNonQuery();
        //    if (result == -1 | result == 0)
        //    {
        //        cmd.Dispose();
        //        Close();
        //        return false;
        //    }
        //    else
        //    {
        //        cmd.Dispose();
        //        Close();
        //        return true;
        //    }
        //}
        ///// <summary>
        ///// 执行数据库查询
        ///// </summary>
        ///// <param name="sqlStr">查询语句</param>
        ///// <param name="tableName">填充数据集表格的名称</param>
        ///// <param name="file">数据库所在路径</param>
        ///// <returns>查询的数据集</returns>
        //public DataSet GetDataSet()
        //{
        //    DataSet ds = new DataSet();
        //    OleDbCommand cmd = new OleDbCommand("select * from UserLogin", _oleDbConn);
        //    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
        //    dataAdapter.Fill(ds);
        //    cmd.Dispose();
        //    Close();
        //    dataAdapter.Dispose();
        //    return ds;
        //}
        ///// <summary>
        ///// 生成一个数据读取器OleDbDataReader并返回该OleDbDataReader
        ///// </summary>
        ///// <param name="sqlStr">数据库查询语句</param>
        ///// /// <param name="file">数据库所在路径</param>
        ///// <returns>返回一个DataReader对象</returns>
        //public OleDbDataReader GetReader()
        //{
        //    OleDbCommand cmd = new OleDbCommand("select * from UserLogin", _oleDbConn);
        //    OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //    //CommadnBehavior.CloseConnection是将于DataReader的数据库链接关联起来
        //    //当关闭DataReader对象时候也自动关闭链接
        //    return reader;
        //}

        ///// <summary>
        ///// 关闭数据库
        ///// </summary>
        //public void Close()
        //{
        //    if (_oleDbConn != null)
        //        _oleDbConn.Close();
        //    _oleDbConn = null;
        //}

        //public ArrayList GetOneUser(string strUid)
        //{
        //    ArrayList list2;
        //    OleDbConnection connection = new OleDbConnection();
        //    OleDbCommand command = new OleDbCommand();
        //    OleDbDataReader reader = null;
        //    ArrayList list = new ArrayList();
        //    try
        //    {
        //        connection.ConnectionString = this.strConn;
        //        command.Connection = connection;
        //        command.CommandText = "select * from UserLogin where ID=?";
        //        command.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 4)).Value = strUid;
        //        connection.Open();
        //        reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            list.Add(reader["UserName"].ToString());
        //            list.Add(reader["major"].ToString());
        //            list.Add(reader["SEX"].ToString());
        //            list.Add(reader["photo"].ToString());
        //        }
        //        list2 = list;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        list2 = null;
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //        {
        //            reader.Close();
        //        }
        //        connection.Close();
        //    }
        //    return list2;
        //}

    }
}
