using System;
using System.IO;
using System.Net;
using System.Text;

namespace SmsCode
{
    class Program
    {
        private static  String HOST = "https://api.zhuanxinyun.com/api/v2/sendSms.json";
	    private static  String SIGN = "【签名】";
	    private static  String APP_KEY = "app_key";
	    private static  String APP_SECRET = "APP_SECRET";

        static void Main(string[] args)
        {
            string mobile = "手机号";
            string code = "内容";
            string body = sendSmsCode(mobile, code);
 
            Console.WriteLine(body);
        }
        /**
	 * 发送短信验证码
	 * @param mobile		接收手机号
	 * @param code			验证码
	 */
        public static String sendSmsCode(String mobile, String code)
        {
            StringBuilder content = new StringBuilder().Append("验证码：").Append(code).Append("，如非本人操作请忽略。");
            return sendSms(mobile, content.ToString());

           // StringBuilder
        }

        /**
	 * 发送短信信息
	 * @param mobile		接收手机号
	 * @param content		短信内容
	 */
        public static string sendSms(String mobile, String content)
        {
            string msg = string.Empty;
            // 拼接请求参数
            StringBuilder url = new StringBuilder().Append(HOST).Append("?appKey=").Append(APP_KEY).Append("&appSecret=")
                    .Append(APP_SECRET).Append("&phones=").Append(mobile).Append("&content=").Append(SIGN).Append(content);
            // 封装请求参数
            try
            {
                // 发起请求

                 msg = Request_GET(url.ToString(), "UTF-8");
            
            }
            catch (Exception ex)
            {
                msg=ex.Message;
            }

            return msg;
        }

        public static string Request_GET(string urlString, string encoding)
        {
            HttpWebRequest httpWebRequest = null;
            HttpWebResponse httpWebResponse = null;
            Stream stream = null;
            StreamReader streamReader = null;
            string result = string.Empty;
            try
            {
                httpWebRequest = (WebRequest.Create(urlString) as HttpWebRequest);
                httpWebRequest.Method = "GET";
                //httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; Maxthon 2.0)";
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                stream = httpWebResponse.GetResponseStream();
                streamReader = new StreamReader(stream, Encoding.GetEncoding(encoding));
                result = streamReader.ReadToEnd();
            }
            catch (SystemException ex)
            {
                result = "err:" + ex.Message;
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                }
                if (httpWebResponse != null)
                {
                    httpWebResponse.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            return result;
        }
    }

  
}
