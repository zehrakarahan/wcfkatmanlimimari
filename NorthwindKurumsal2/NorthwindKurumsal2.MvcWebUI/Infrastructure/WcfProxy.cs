using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace NorthwindKurumsal2.MvcWebUI.Infrastructure
{
    public static class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string address =String.Format("http://localhost:51483/{0}.svc?wsdl",typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();

            var channel = new ChannelFactory<T>(binding,address);

            return channel.CreateChannel();
        }
    }
}