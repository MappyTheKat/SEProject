using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using LitJson;

namespace SE_Project
{
    public class HttpCommunication
    {
        private static string serverURL = "https://aa.bb.cc.dd:8111";

        private static string postMethod = "POST";
        private static string getMethod = "GET";

        /// <summary>
        /// Async로 구현된 Http Web Request.
        /// </summary>
        /// <param name="address"> 요청 주소 </param>
        /// <param name="message"> 메시지 </param>
        /// <param name="responseEndedAction"> 요청 후 콜할 메소드 (JsonData, bool) </param>
        /// <param name="state"> 뭔가 허전하다 싶을때 붙이는거 </param>
        public static async void HttpWebRequest(string address, string message, Action <JsonData,bool> responseEndedAction, object state = null)
        {
            WebRequest req = WebRequest.Create(serverURL + address);

            req.Credentials = CredentialCache.DefaultCredentials;

            req.ContentType = "application/x-www-form-urlencoded";

            // TODO : OAUTH 2.0 구현 - request Header에 값을 쓰면 될듯
            // req.Headers

            if (string.IsNullOrEmpty(message))
            {
                req.Method = getMethod;
                // message 가 없으므로 get
            }
            else
            {
                req.Method = postMethod;
                byte[] byteArray = Encoding.UTF8.GetBytes(message);
                Stream dataStream = req.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                // message가 있으므로 post
            }

            StreamReader streamReader = null;
            WebResponse response = null;
            Stream responseStream = null;
            try
            {
                response = await req.GetResponseAsync();
                responseStream = response.GetResponseStream();
                streamReader = new StreamReader(responseStream);
                var readedString = streamReader.ReadToEnd();

                var responseJson = JsonMapper.ToJson(readedString);
                responseEndedAction?.Invoke(responseJson, true);
            }
            catch (Exception e)
            {
                responseEndedAction?.Invoke(null, false);
            }
            finally
            {
                streamReader.Close();
                responseStream.Close();
                response.Close();
            }
        }
    }
}
