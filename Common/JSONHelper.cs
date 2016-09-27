using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

/// <summary>
/// JSON操作
/// </summary>
public class JSONHelper
{

    /// <summary>
    /// 将对象序列化为JSON格式
    /// </summary>
    /// <param name="o">对象</param>
    /// <returns>json字符串</returns>
    public static string SerializeObject(object o)
    {
        string json = JsonConvert.SerializeObject(o);
        return json;
    }
    /// <summary>
    /// 根据KEY获取JSON值
    /// </summary>
    /// <param name="jsonstr">JSON字符串</param>
    /// <param name="Keys">JSON KEY</param>
    /// <returns>string</returns>
    public static string JsonToString(object jsonstr, string Keys)
    {
        try
        {
            JObject jo = (JObject)JsonConvert.DeserializeObject(jsonstr.ToString());
            return jo[Keys].ToString();
        }
        catch (Exception)
        {

            throw;
        }
    }





   /// <summary>
    /// 解析JSON字符串生成对象实体
   /// </summary>
    /// <typeparam name="T">对象类型</typeparam>
    /// <param name="json">json字符串</param>
    /// <returns>对象实体</returns>
    public static T DeserializeJsonToObject<T>(string json) where T : class
    {
        JsonSerializer serializer = new JsonSerializer();
        StringReader sr = new StringReader(json);
        object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
        T t = o as T;
        return t;
    }

    /// <summary>
    /// 解析JSON数组生成对象实体集合
    /// </summary>
    /// <typeparam name="T">对象类型</typeparam>
    /// <param name="json">json数组字符串(eg.[{"ID":"112","Name":"石子儿"}])</param>
    /// <returns>对象实体集合</returns>
    public static List<T> DeserializeJsonToList<T>(string json) where T : class
    {
        JsonSerializer serializer = new JsonSerializer();
        StringReader sr = new StringReader(json);
        object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
        List<T> list = o as List<T>;
        return list;
    }

    /// <summary>
    /// 反序列化JSON到给定的匿名对象.
    /// 匿名对象解析
    ///var tempEntity = new { ID = 0, Name = string.Empty };
    ///string json5 = JsonHelper.SerializeObject(tempEntity);
    ///json5 : {"ID":0,"Name":""}
    ///tempEntity = JsonHelper.DeserializeAnonymousType("{\"ID\":\"112\",\"Name\":\"石子儿\"}", tempEntity);
    ///var tempStudent = new Student();
    ///tempStudent = JsonHelper.DeserializeAnonymousType("{\"ID\":\"112\",\"Name\":\"石子儿\"}", tempStudent);
    /// </summary>
    /// <typeparam name="T">匿名对象类型</typeparam>
    /// <param name="json">json字符串</param>
    /// <param name="anonymousTypeObject">匿名对象</param>
    /// <returns>匿名对象</returns>
    public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
    {
        T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject);
        return t;
    }
}

