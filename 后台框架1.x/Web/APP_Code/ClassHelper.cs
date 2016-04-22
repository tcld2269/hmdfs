using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;

namespace hm.Web
{
    /// <summary>
    /// 公共方法类
    /// </summary>
    public class ClassHelper
    {

        public static int Common_Status_Lock = 0;
        public static int Common_Status_Normal = 1;
        public static string[] Common_Status_Arr = { "冻结", "正常" };

        /// <summary>
        /// 绑定部门列表
        /// </summary>
        /// <param name="ddl"></param>
        /// <returns></returns>
        public static bool AddDeptList(DropDownList ddl)
        {
            try
            {
                ddl.Items.Clear();
                BLL.dept deptBll = new BLL.dept();
                DataTable dt = deptBll.GetList("parentId=0").Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddl.Items.Add(new ListItem(dt.Rows[i]["deptName"].ToString(), dt.Rows[i]["deptId"].ToString()));
                    DataTable dt2 = deptBll.GetList("parentId=" + dt.Rows[i]["deptId"].ToString()).Tables[0];
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        ddl.Items.Add(new ListItem("┣" + dt2.Rows[j]["deptName"].ToString(), dt2.Rows[j]["deptId"].ToString()));
                        DataTable dt3 = deptBll.GetList("parentId=" + dt2.Rows[j]["deptId"].ToString()).Tables[0];
                        for (int k = 0; k < dt3.Rows.Count; k++)
                        {
                            ddl.Items.Add(new ListItem("┣╍" + dt3.Rows[k]["deptName"].ToString(), dt3.Rows[k]["deptId"].ToString()));
                            DataTable dt4 = deptBll.GetList("parentId=" + dt3.Rows[k]["deptId"].ToString()).Tables[0];
                            for (int l = 0; l < dt4.Rows.Count; l++)
                            {
                                ddl.Items.Add(new ListItem("┣╍╍" + dt4.Rows[l]["deptName"].ToString(), dt3.Rows[l]["deptId"].ToString()));
                            }
                        }
                    }
                }
                ddl.Items.Insert(0, new ListItem("请选择", "0"));
                return true;
            }
            catch {
                return false;
            }
        }
        /// <summary>
        /// 绑定上级部门列表
        /// </summary>
        /// <param name="ddl"></param>
        /// <returns></returns>
        public static bool AddDeptPaeent(DropDownList ddl)
        {
            try
            {
                ddl.Items.Clear();
                BLL.dept deptBll = new BLL.dept();
                DataTable dt = deptBll.GetList("parentId=0").Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddl.Items.Add(new ListItem(dt.Rows[i]["deptName"].ToString(), dt.Rows[i]["deptId"].ToString()));
                    DataTable dt2 = deptBll.GetList("parentId=" + dt.Rows[i]["deptId"].ToString()).Tables[0];
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        ddl.Items.Add(new ListItem("┣" + dt2.Rows[j]["deptName"].ToString(), dt2.Rows[j]["deptId"].ToString()));
                        DataTable dt3 = deptBll.GetList("parentId=" + dt2.Rows[j]["deptId"].ToString()).Tables[0];
                        for (int k = 0; k < dt3.Rows.Count; k++)
                        {
                            ddl.Items.Add(new ListItem("┣╍" + dt3.Rows[k]["deptName"].ToString(), dt3.Rows[k]["deptId"].ToString()));
                            
                        }
                    }
                }
                ddl.Items.Insert(0, new ListItem("无上级", "0"));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 取码表
        /// </summary>
        /// <param name="innerName">内部名</param>
        /// <returns></returns>
        public static DataSet GetSystemItem(string innerName)
        {
            BLL.sysItem sBll = new BLL.sysItem();
            return sBll.GetList("sicId in (select sicId from [sysItemCategory] where innerName='" + innerName + "')");
        }

        /// <summary>
        /// 取码表名称
        /// </summary>
        /// <param name="siId"></param>
        /// <returns></returns>
        public static string GetSystemItemName(string siId)
        {
            return new BLL.sysItem().GetModel(int.Parse(siId)).itemName;
        }

        

        
    }
}