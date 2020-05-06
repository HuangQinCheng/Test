<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Alan.Test.WebApp.WebForm1" %>

<!DOCTYPE>
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Test</title>
    <meta http-equiv="X-UA-Compatible" content="IE=7,chrome=1">
    <link href="UI/layui-v2.5.5/layui/css/layui.css" rel="stylesheet" />
    <style type="text/css">
        .layui-tab {
            margin: 0px;
            height: 50px;
        }

        .layui-tab-title {
            color: ghostwhite;
            background-color: gray;
        }
        .form-input {
            width: 200px;
            height: 50px;
        }
    </style>
    <!--[if gte IE 9]>
        <script src="Scripts/jquery-3.4.1.min.js"></script>
    <![endif]-->
    <!--[if lt IE 9]>
        <script src="https://code.jquery.com/jquery-1.7.2.min.js"></script>
    <![endif]-->
     <!--[if !IE]> <-->
        <script src="Scripts/jquery-3.4.1.min.js"></script>
    <!--> <![endif]-->
    <script>
        $(function () {
            $('.form-input').focus(function () {
                $(this).css('border-color', 'red');
            })
            $('.form-input').blur(function () {
                 $(this).css('border-color', '');
            })
            $('input:radio[name="lstTab"]').click(function () {
                var a = $(this).val();
                var b = $("#lstTab");
                for (var i = 0; i < b[0].rows[0].cells.length; i++) {
                    if (a == i) {
                        $('#pnl' + i + 'Tab').show();
                    }
                    else {
                        $('#pnl' + i + 'Tab').hide();
                    }
                }
            })
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="lstTab" runat="server" TextAlign="Right" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="0">男</asp:ListItem>
                <asp:ListItem value="1">女</asp:ListItem>
                <asp:ListItem value="2">女</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div id="pnl0Tab" style="width: 800px; height: 600px; background-color:red;">
            1
        </div>
        <div id="pnl1Tab" style="width: 800px; height: 600px; background-color:yellow;">
            2
        </div>
        
        <div>
            <span class="form-span">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input"></asp:TextBox>
            </span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="layui-tab layui-tab-brief">
            <ul class="layui-tab-title">
                <li class="layui-this">Process</li>
                <li>工作站信息</li>
                <li>工作站INI</li>
            </ul>
            <div class="layui-tab-content" style="height: 500px;">
                <div class="layui-tab-item layui-show">
                    <div class="layui-form-item">
                        <label class="layui-form-label">单行选择框</label>
                        <div class="layui-input-block">
                            <select name="interest" lay-filter="aihao">
                                <option value=""></option>
                                <option value="0">写作</option>
                                <option value="1" selected="">阅读</option>
                                <option value="2">游戏</option>
                                <option value="3">音乐</option>
                                <option value="4">旅行</option>
                            </select>
<%--                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Selected="True"></asp:ListItem>
                                <asp:ListItem>写作</asp:ListItem>
                                <asp:ListItem>阅读</asp:ListItem>
                                <asp:ListItem>游戏</asp:ListItem>
                            </asp:DropDownList>--%>
                        </div>
                    </div>
                </div>
                <div class="layui-tab-item">内容2</div>
                <div class="layui-tab-item">内容3</div>
            </div>
        </div>
    </form>
    <script src="UI/layui-v2.5.5/layui/layui.js"></script>
    <script src="UI/layui-v2.5.5/layui/layui.all.js"></script>
</body>
</html>
