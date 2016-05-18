<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true"
    CodeBehind="ModAvatar.aspx.cs" Inherits="hm.Web.admin.users.ModAvatar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .fancybox
        {
        }
        .fancybox img
        {
            width: 90px;
        }
        .avatarlist tr td
        {
            padding: 5px 10px;
        }
        .avatar-list ul
        {
            list-style:none;
        }
        .avatar-list ul li
        {
            float:left;
            width:90px;
            margin-left:20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                    <h5>
                        修改头像</h5>
                    <div class="ibox-tools">
                        <a class="collapse-link"><i class="fa fa-chevron-up"></i></a><a class="dropdown-toggle"
                            data-toggle="dropdown" href="form_editors.html#"></a>
                    </div>
                </div>
                <div class="ibox-content">
                    <div class="tabs-container">
                        <ul class="nav nav-tabs">
                            <li class="active"><a data-toggle="tab" href="#tab-1" aria-expanded="true">头像选择</a>
                            </li>
                            <li class=""><a data-toggle="tab" href="#tab-2" aria-expanded="false">本地上传</a> </li>
                        </ul>
                        <div class="tab-content">
                            <div id="tab-1" class="tab-pane active">
                                <div class="panel-body">
                                    <div class="avatar-list">
                                        <ul>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar1.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(1)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar2.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(2)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar3.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(3)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar4.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(4)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar5.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(5)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar6.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(6)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar7.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(7)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar8.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(8)">
                                                        选择</button></center>
                                            </li>
                                            <li><a href="javascript:void(0)" class="fancybox">
                                                <img src="/img/avatar/avatar9.png" />
                                            </a>
                                                <br />
                                                <center>
                                                    <button class="btn btn-warning btn-xs" onclick="modAvatar(9)">
                                                        选择</button></center>
                                            </li>
                                        </ul>
                                    </div>
                                    
                                </div>
                            </div>
                            <div id="tab-2" class="tab-pane">
                                <div class="panel-body">
                                    尚未启用。。。
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
    <script>
        function modAvatar(id) {
            var pars = { id: id };
            ajax("/admin/users/ModAvatar.aspx?act=mod&t=" + Math.random(), pars, function (ret) {
                if (ret.status == 1) {
                    $(window.parent.$("#user_avatar").attr("src", "/img/avatar/avatar" + id + ".png"));
                    layer.msg('更换成功！')
                }
                else {
                    layer.msg(ret.msg)
                }
            });
        }
    </script>
</asp:Content>
