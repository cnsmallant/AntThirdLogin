using System;

/// <summary>
/// 组合链接方法
/// </summary>
public class UrlStr
{
    /// <summary>
    /// 组合QQ登录链接
    /// </summary>
    /// <returns></returns>
    public static string QQLoginUrl()
    {
        try
        {
            //具体参数说明请参考QQ互联
            var apiurl = "https://graph.qq.com/oauth2.0/authorize";
            var client_id = "client_id";//你的appid
            var response_type = "token";
            var scope = "all";
            var redirect_uri = "callbackUrl";//你的回调页面（例如：http://www.smallant.net/callbackurl/）
            var url = apiurl + "?" + "&client_id=" + client_id + "&response_type=" + response_type + "&scope" + scope + "&redirect_uri" + System.Web.HttpContext.Current.Server.UrlEncode(redirect_uri);
            return url;
        }
        catch (Exception)
        {

            throw;
        }
    }

    /// <summary>
    ///  组合微信登录链接
    /// </summary>
    /// <returns></returns>
    public static string WXLoginUrl()
    {
        try
        {
            //具体参数说明请到微信开放平台参看
            var apiurl = "https://open.weixin.qq.com/connect/qrconnect";
            var appid = "appid";//你的appid
            var redirect_uri = "redirect_uri";//填写你的回调页面（域名要和回调域写的域名一致 例如：http://www.smallant.net/callbackurl/）
            var response_type = "code";
            var scope = "snsapi_login";
            var state = "STATE";
            string url = apiurl + "?appid=" + appid + "&redirect_uri=" + System.Web.HttpContext.Current.Server.UrlEncode(redirect_uri) + "&response_type=" + response_type + "&scope=" + scope + "&state=" + state + "#wechat_redirect";
            return url;
        }
        catch (Exception)
        {

            throw;
        }
    }
}
