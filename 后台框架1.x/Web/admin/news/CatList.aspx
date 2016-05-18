﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CatList.aspx.cs" Inherits="hm.Web.admin.news.CatList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="/admin/css/plugins/treeview/bootstrap-treeview.css" rel="stylesheet">
    <link href="/admin/css/plugins/chosen/chosen.css" rel="stylesheet">
    <link href="/admin/css/style.min862f.css?v=4.1.0" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
 <div class="col-sm-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>
                    新闻分类管理</h5>
                <div class="ibox-tools">
                    <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                </div>
            </div>
            <div class="ibox-content">
                <div class="col-sm-6">
                    <div id="menuTree" class="test">
                    </div>
                </div>
                <div class="col-sm-6">
                    <h5>
                        新闻分类编辑：</h5>
                    <hr>
                    <div id="event_output" class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                ID：</label>
                            <div class="col-sm-8">
                                <input id="cat_id" name="name" minlength="2" type="text" class="form-control" style="border:0;background-color:#fff" readonly="true">
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                上级分类：</label>
                            <div class="col-sm-8">
                                <select id="parentId" data-placeholder="选择上级..." class="chosen-select" style="width: 100%;"
                                    tabindex="2">
                                    <option value="0">请选择上级分类</option>
                                    <%=edithtml %>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                分类名称：</label>
                            <div class="col-sm-8">
                                <input id="cat_name" name="name" minlength="2" type="text" class="form-control"
                                    required="" aria-required="true">
                            </div>
                        </div>
                       
                        <div class="form-group">
                            <div class="col-sm-8 col-sm-offset-3">
                                <button id="btnsubmit" class="btn btn-warning" type="button" onclick="editsubmit()">
                                    添加</button>
                                    <button id="btndel" class="btn btn-danger hidden" type="button" onclick="del()">
                                    删除</button>
                                    <button id="btncancle" class="btn btn-default hidden" type="button" onclick="editcancle()">
                                    取消</button>
                            </div>
                        </div>
                        <%--<button class="btn btn-primary" type="button" onclick="test()">提</button>
                            <button class="btn btn-primary" type="button" onclick="test2()">提交</button>--%>
                    </div>
                </div>
                <div class="clearfix">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
    <script src="/admin/js/plugins/treeview/bootstrap-treeview.js"></script>
    <script src="/admin/js/plugins/chosen/chosen.jquery.js"></script>
    <script src="/admin/js/demo/form-advanced-demo.min.js"></script>
    
    <script>
        function load() {
            var e = [<%=menuhtml %>]
            $("#menuTree").treeview({ color: "#428bca", data: e, onNodeSelected: function (e, o) {
                var pars={catId:o.tags.toString()};
                ajax("/admin/news/CatList.aspx?act=edit&t="+Math.random(),pars,function(ret)
                {
                    if(ret.status==1)
			        {
			            $("#cat_id").val(ret.catId);
                        $("#cat_name").val(ret.catName);
                        
                        $("#parentId option[value='"+ret.parentId+"']").attr("selected","selected");  
                        $("#parentId").chosen();  
                        $("#parentId").trigger("chosen:updated");

                        $("#btnsubmit").attr("class", "btn btn-primary");
                        $("#btnsubmit").html("修改");
                        $("#btndel").attr("class", "btn btn-danger");
                        $("#btncancle").attr("class", "btn btn-default");
			        }
                });
             } })
        }
        load();

        function editcancle()
        {

			$("#cat_id").val("");
            $("#cat_name").val("");
            $("#parentId option[value='0']").attr("selected","selected");  
            $("#parentId").chosen();  
            $("#parentId").trigger("chosen:updated");

            $("#btnsubmit").attr("class", "btn btn-warning");
            $("#btnsubmit").html("添加");
            $("#btndel").attr("class", "btn btn-danger hidden");
            $("#btncancle").attr("class", "btn btn-default hidden");
        }

        function editsubmit()
        {
            var catId=$("#cat_id").val();
            var catName=$("#cat_name").val();
            var parentId=$("#parentId").val();
            
            
            if(catId=="")
            {
                //添加
                var pars={catName:catName,parentId:parentId};
                ajax("/admin/news/CatList.aspx?act=add&t="+Math.random(),pars,function(ret)
                {
                    if(ret.status==1)
			        {
			            location.href=location.href;
			        }
                });
            }
            else{
                //编辑
                var pars={catId:catId,catName:catName,parentId:parentId};
                ajax("/admin/news/CatList.aspx?act=editsubmit&t="+Math.random(),pars,function(ret)
                {
                    if(ret.status==1)
			        {
			            location.href=location.href;
			        }
                });
            }
            
        }

        function del()
        {
            if(confirm('是否删除此选项？'))
            {
                var catId=$("#cat_id").val();
                if(catId=="")
                {
                    layer.msg("请输入完整！");
                    return;
                }
                var pars={catId:catId};
                ajax("/admin/news/CatList.aspx?act=del&t="+Math.random(),pars,function(ret)
                {
                    if(ret.status==1)
			        {
			            location.href=location.href;
			        }
                });
            }
            
        }
    </script>
</asp:Content>
