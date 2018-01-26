<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="QQLoginForASPX.index" %>

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>QQ登录ASPX版</title>
    <meta name="keywords" content="smallant,smallant.net,www.smallant.net" />
    <meta name="description" content="小蚂蚁技术问答社区-做最好的技术问答社区" />
    <meta name="author" content="smallant.net" />
    <meta name="copyright" content="2016 smallant.net" />
    <link href="/css/css.css" rel="stylesheet" />
</head>
<body>
    <div>
        <form runat="server">
            <div class="ant_login_box">
                <p>
                    <h3>QQ登录ASPX版</h3>
                </p>
                <p>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"> <img src="/img/qq.png" /> </asp:LinkButton>
                </p>
               <p>您还可以加入<a href="https://jq.qq.com/?_wv=1027&k=5kg07Vo" target="_blank">Java/.NET/PHP养老群： 574879752</a></p>
            </div>
        </form>
    </div>
</body>
</html>
