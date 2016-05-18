using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
using System.Text;

namespace hm.Web
{
    /// <summary>
    /// 公共方法类
    /// </summary>
    public class ClassHelper
    {
        /// <summary>
        /// 生成订单号
        /// </summary>
        /// <param name="reqFrom">请求来源</param>
        /// <param name="orderType">订单类型</param>
        /// <returns></returns>
        public static string generateOrderNo(int reqFrom, int orderType)
        {
            Random r = new Random();
            string orderNo = reqFrom.ToString() + orderType.ToString() + DateTime.Now.ToString("yyyyMMddHHmmss") + r.Next(1000, 9999);
            return orderNo;
        }

        /// <summary>
        /// 发送系统消息
        /// </summary>
        /// <param name="title"></param>
        /// <param name="remark"></param>
        /// <param name="receiverId"></param>
        /// <returns></returns>
        public static bool sendSysMessage(string title, string remark, int receiverId)
        {
            return sendMessage(title, remark, receiverId, 0, 0);
        }
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="title"></param>
        /// <param name="remark"></param>
        /// <param name="receiverId">接收者</param>
        /// <param name="senderId">发送者0为系统</param>
        /// <param name="type">类型0系统1站内信</param>
        /// <returns></returns>
        public static bool sendMessage(string title,string remark,int receiverId,int senderId,int type )
        {
            try
            {
                BLL.message mbll = new BLL.message();
                Model.message model = new Model.message();
                model.receiverId = receiverId;
                model.receiverName = new BLL.users().GetModel(receiverId).userName;
                model.senderId = senderId;
                if (senderId == 0)
                {
                    model.senderName = "系统";
                }
                else
                {
                    model.senderName = new BLL.users().GetModel(senderId).userName;
                }
                model.title = title;
                model.remark = remark;
                model.type = type;
                model.addTime = DateTime.Now;
                model.status = StatusHelpercs.Message_Status_UnRead;
                mbll.Add(model);
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// 根据编码获取地名
        /// </summary>
        /// <param name="addressNo"></param>
        /// <returns></returns>
        public static string getAddressNoString(string addressNo)
        {
            BLL.t_province pbll = new BLL.t_province();
            BLL.t_city cbll = new BLL.t_city();
            BLL.t_distinct dbll = new BLL.t_distinct();

            string provinceString = pbll.GetList("code='" + addressNo.Substring(0, 2) + "0000'").Tables[0].Rows[0]["name"].ToString();
            string cityString = cbll.GetList("code='" + addressNo.Substring(0, 4) + "00'").Tables[0].Rows[0]["name"].ToString();
            string distinctString = dbll.GetList("code='" + addressNo + "'").Tables[0].Rows[0]["name"].ToString();
            string result = provinceString + " " + cityString + " " + distinctString;
            return result;
        }
        /// <summary>
        /// 获得省份
        /// </summary>
        /// <returns></returns>
        public static string getProvinceOptions()
        {
            BLL.t_province pbll = new BLL.t_province();
            DataTable dt = pbll.GetAllList().Tables[0];
            StringBuilder sb = new StringBuilder();
            sb.Append("<option value='0'>请选择</option>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.AppendFormat("<option value=\"{0}\">{1}</option>", dr["code"].ToString(), dr["name"].ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// 获取城市列表
        /// </summary>
        /// <param name="provinceCode"></param>
        /// <returns></returns>
        public static string getCityOptions(string provinceCode)
        {
            BLL.t_city pbll = new BLL.t_city();
            DataTable dt = pbll.GetList("provinceCode='" + provinceCode + "'").Tables[0];
            StringBuilder sb = new StringBuilder();
            sb.Append("<option value='0'>请选择</option>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.AppendFormat("<option value='{0}'>{1}</option>", dr["code"].ToString(), dr["name"].ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// 获取区县列表
        /// </summary>
        /// <param name="cityCode"></param>
        /// <returns></returns>
        public static string getDistinceOptions(string cityCode)
        {
            BLL.t_distinct pbll = new BLL.t_distinct();
            DataTable dt = pbll.GetList("cityCode='" + cityCode + "'").Tables[0];
            StringBuilder sb = new StringBuilder();
            sb.Append("<option value='0'>请选择</option>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.AppendFormat("<option value='{0}'>{1}</option>", dr["code"].ToString(), dr["name"].ToString());
            }
            return sb.ToString();
        }


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
            return sBll.GetList("sicId in (select sicId from [sysItemCategory] where innerName='" + innerName + "') order by orders asc");
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