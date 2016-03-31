using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace hm.BLL
{
    public partial class sqlHelper
    {
        private static readonly hm.DAL.sqlHelper dal = new hm.DAL.sqlHelper();
        public static int ExecSql(string sql)
        {
            return dal.ExecSql(sql);
        }
        public static string GetSingle(string sql)
        {
            return dal.GetSingle(sql);
        }

        public static DataTable GetList(string sql)
        {
            return dal.GetList(sql);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetList(int PageSize, int PageIndex, string tableName, string primyKey, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, tableName, primyKey, strWhere);
        }
    }
}
