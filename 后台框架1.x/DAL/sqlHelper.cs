using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using System.Data;
using System.Data.SqlClient;

namespace hm.DAL
{
    public partial class sqlHelper
    {
        public int ExecSql(string sql)
        {
            return DbHelperSQL.ExecuteSql(sql);
        }

        public string GetSingle(string sql)
        {
            string result = "0";
            if (DbHelperSQL.GetSingle(sql) == null)
            {
                result = "0";
            }
            else
            {
                result = DbHelperSQL.GetSingle(sql).ToString();
            }
            return result;
        }

        public DataTable GetList(string sql)
        {
            return DbHelperSQL.Query(sql).Tables[0];
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string tableName, string primyKey,string strWhere)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,3000)
					};
            parameters[0].Value = tableName;
            parameters[1].Value = primyKey;
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage", parameters, "ds");
        }
    }
}
