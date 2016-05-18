using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hm.Web
{
    /// <summary>
    /// 状态常量类
    /// </summary>
    public class StatusHelpercs
    {
        #region 常量
        //后台cookie常量
        public static string Cookie_Admin_UserId = "Admin_UserId";
        public static string Cookie_Admin_UserName = "Admin_UserName";
        public static string Cookie_Admin_TrueName = "Admin_TrueName";
        public static string Cookie_Admin_RoleId = "Admin_RoleId";
        public static string Cookie_Admin_RoleName = "Admin_RoleName";
        public static string Cookie_Admin_DeptId = "Admin_DeptId";
        public static string Cookie_Admin_IsAdmin = "Admin_IsAdmin";
        public static string Cookie_Admin_Avatar = "Admin_Avatar";
        public static string Cookie_Admin_LastLoginTime = "Admin_LastLoginTime";

        //请求来源
        public static int Request_From_PC = 0;
        public static int Request_From_APP = 1;
        public static int Request_From_WAP = 2;
        public static int Request_From_WX = 3;
        public static string[] Request_From_Arr = { "PC网站", "APP", "手机网站", "微信" };
        #endregion

        #region 状态
        //用户状态
        public static int User_Status_Normal = 1;
        public static int User_Status_Lock = 0;
        public static string[] User_Status_Arr = { "冻结", "正常" };

        //店铺状态
        public static int Store_Status_Lock = 0;
        public static int Store_Status_Normal = 1;
        public static int Store_Status_FeedBack = 2;
        public static string[] Store_Status_Arr = { "审核中", "正常", "审核失败" };

        //消息状态
        public static int Message_Status_UnRead = 0;
        public static int Message_Status_Read = 1;
        public static string[] Message_Status_Arr = { "未读", "已读" };

        //消息类型
        public static int Message_Type_Sys = 0;
        public static int Message_Type_Mess = 1;
        public static string[] Message_Type_Arr = { "系统消息", "站内信" };

        //商品状态
        public static int Goods_Status_Del = 0;
        public static int Goods_Status_Normal = 1;
        public static int Goods_Status_Verify = 2;
        public static int Goods_Status_FeedBack = 3;
        public static string[] Goods_Status_Arr = { "删除", "正常", "审核中", "审核失败" };

        //购物车状态
        public static int Cart_Status_Cart = 0;
        public static int Cart_Status_Order = 1;
        public static string[] Cart_Status_Arr = { "购物车", "已加入订单"};

        

        //订单类型
        public static int Order_Type_Recharge = 0;
        public static int Order_Type_Goods = 1;
        public static int Order_Type_Crowd = 2;
        public static int Order_Type_Auction = 3;
        public static string[] Order_Type_Arr = { "充值", "商品", "众筹", "拍卖" };

        //订单状态
        public static int Order_Status_Del = 0;
        public static int Order_Status_Unpay = 1;
        public static int Order_Status_Payed = 2;
        public static int Order_Status_Send = 3;
        public static int Order_Status_Received = 4;
        public static int Order_Status_Success = 5;
        public static int Order_Status_RefundReq = 6;
        public static int Order_Status_RefundIng = 7;
        public static int Order_Status_Refunded = 8;
        public static string[] Order_Status_Arr = { "已删除", "待付款", "已付款", "已发货", "已收货", "已完成", "退款申请", "退款中", "已退款" };

        //退款类型
        public static int Order_Refund_Type_All = 0;
        public static int Order_Refund_Type_Price = 1;
        public static int Order_Refund_Type_Part = 2;
        public static string[] Default_Goods_Status_Arr = { "退款并退货", "退款", "部分退款" };

        //广告位状态
        public static int AdvPos_Status_Lock = 0;
        public static int AdvPos_Status_Normal = 1;
        public static string[] AdvPos_Status_Arr = { "未启用", "启用" };

        //广告状态
        public static int Adv_Status_Lock = 0;
        public static int Adv_Status_Normal = 1;
        public static string[] Adv_Status_Arr = { "未启用", "启用" };

        //支付方式状态
        public static int Payment_Status_Lock = 0;
        public static int Payment_Status_Normal = 1;
        public static string[] Payment_Status_Arr = { "停用", "启用" };
        #endregion

        #region 默认值
        //默认用户头像
        public static string Default_User_Avatar = "/img/avatar/avatar1.png";
        //默认店铺Logo
        public static string Default_Store_Logo = "/img/default_store_logo.gif";
        //默认审核提示
        public static string Default_Store_Verify_Success = "您的店铺审核通过！";
        public static string Default_Store_Verify_Fail = "您的店铺审核失败！";

        //默认字典
        public static string Default_Item_StoreType = "Store_Type";
        public static string Default_Item_StoreCat = "Goods_Cat";
        public static string[] Default_Item_Arr = { "店铺类型", "商品分类" };
        
        #endregion
    }
}