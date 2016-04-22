<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="hm.Web.admin.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>后台管理登录</title>
    <meta name="keywords" content="后台管理登录">
    <meta name="description" content="后台管理登录">

    <link rel="shortcut icon" href="favicon.ico"> 
    <link href="css/bootstrap.min14ed.css?v=3.3.6" rel="stylesheet">
    <link href="css/font-awesome.min93e3.css?v=4.4.0" rel="stylesheet">

    <link href="css/animate.min.css" rel="stylesheet">
    <link href="css/style.min862f.css?v=4.1.0" rel="stylesheet">

</head>

<body class="gray-bg">

    <div class="middle-box text-center loginscreen  animated fadeInDown">
        <div>
            <div>

                <h1 class="logo-name"><asp:Literal ID="litLogo" runat="server"></asp:Literal></h1>

            </div>
            <h3>欢迎使用 <asp:Literal ID="litName" runat="server"></asp:Literal>后台管理</h3>

            <form id="formLogin" runat="server" class="m-t" >
                <div class="form-group">
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="用户名"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="密码"></asp:TextBox>
                </div>
                <asp:Button ID="btnLogin" runat="server" Text="登 录" onclick="btnLogin_Click" CssClass="btn btn-primary block full-width m-b"></asp:Button>

                <p class="text-muted text-center hidden"> <a href="login.html#"><small>忘记密码了？</small></a> | <a href="register.html">注册一个新账号</a>
                </p>

            </form>
        </div>
    </div>
    <script src="js/jquery.min.js?v=2.1.4"></script>
    <script src="js/bootstrap.min.js?v=3.3.6"></script>
</body>
</html>
