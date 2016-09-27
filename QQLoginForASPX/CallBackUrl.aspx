<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallBackUrl.aspx.cs" Inherits="QQLoginForASPX.CallBackUrl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>QQ登录回调页面</title>
    <script src="/js/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="http://qzonestyle.gtimg.cn/qzone/openapi/qc_loader.js" charset="utf-8" data-callback="true"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script>
                QC.api("get_user_info");
                if (QC.Login.check()) {//检测登录状态-如果已经登录
                    QC.Login.getMe(function (openId, accessToken) {
                        //在这里获取openId-QQ登录用户唯一ID值
                        //在这里可以做相关操作
                    });
                } else {
                    //在这里做相关操作
                }
            </script>
        </div>
    </form>
</body>
</html>
