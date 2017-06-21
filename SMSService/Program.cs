using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace SMSService
{
    class Program
    {
        static void Main(string[] args)
        {
            Send();
        }

        static void Config()
        {

        }


        static void Send()
        {

            //17610068330
            ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", "24462822", "21e4c7b5bf58d8df23bb471269e545a4");
            AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
            req.Extend = "";
            req.SmsType = "normal";
            req.SmsFreeSignName = "咩咩程序";
            req.SmsParam = @"{'name':'咩咩','verify_code':'这是验证码'}";
            req.RecNum = "17610068330";
            req.SmsTemplateCode = "SMS_71545071";
            AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);
            Console.WriteLine(rsp.Body);
        }
    }
}
