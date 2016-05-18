<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="hm.Web.business.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0">

    <title>商户登录平台</title>
    <meta name="keywords" content="商户登录平台">
    <meta name="description" content="商户登录平台">
    <link href="/admin/css/bootstrap.min.css" rel="stylesheet">
    <link href="/admin/css/font-awesome.min93e3.css?v=4.4.0" rel="stylesheet">
    <link href="/admin/css/animate.min.css" rel="stylesheet">
    <link href="/admin/css/style.min.css" rel="stylesheet">
    <link href="/admin/css/login.min.css" rel="stylesheet">
    <!--[if lt IE 9]>
    <meta http-equiv="refresh" content="0;ie.html" />
    <![endif]-->
    <script>
        if (window.top !== window.self) { window.top.location = window.location };
    </script>

</head>

<body class="signin">
    <div class="signinpanel">
        <div class="row">
            <div class="col-sm-7">
                <div class="signin-info">
                    <div class="logopanel m-b">
                        <h1><%=siteName%>商户平台</h1>
                    </div>
                    <div class="m-b"></div>
                    <h4>欢迎使用 <strong><%=siteName %></strong></h4>
                    <ul class="m-b">
                        <li><i class="fa fa-arrow-circle-o-right m-r-xs"></i> 供<%=siteName %>商户管理使用</li>
                        <li><i class="fa fa-arrow-circle-o-right m-r-xs"></i> 请使用任意第三方浏览器，360、谷歌、QQ、火狐等</li>
                        <li><i class="fa fa-arrow-circle-o-right m-r-xs"></i> 不支持IE9以下浏览器</li>
                    </ul>
                    <%--<strong>还没有账号？ <a href="#">立即注册&raquo;</a></strong>--%>
                </div>
            </div>
            <div class="col-sm-5">
                <form runat="server">
                    <h4 class="no-margins">登录：</h4>
                    <p class="m-t-md">登录到<%=siteName %>商户平台</p>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control uname" placeholder="用户名"></asp:TextBox>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control pword m-b" placeholder="密码"></asp:TextBox>
                    <%--<a href="#">忘记密码了？</a>--%>
                    <asp:Button ID="btnLogin" runat="server" Text="登 录" onclick="btnLogin_Click" CssClass="btn btn-success btn-block"></asp:Button>
                </form>
            </div>
        </div>
        <div class="signup-footer">
            <div class="pull-left">
                &copy; <%=copyright %>
            </div>
        </div>
    </div>
</body>
</html>
