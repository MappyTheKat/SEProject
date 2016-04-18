using System;
using System.Collections.Generic;
using System.Text;
using LitJson;

namespace SE_Project
{
    public static class HttpCommunication
    {
        private static string serverURL = "https://aa.bb.cc.dd:8111";

        
        public static async void HttpWebRequest(string service, string message, object param = null)
        {
            if(string.IsNullOrEmpty(message))
            {
                // message 가 없으므로 get

            }
            else
            {
                // message가 있으므로 postk
            }
        }
    }
}
