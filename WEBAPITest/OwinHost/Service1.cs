using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System;
using System.Net.Http;



namespace OwinHost
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:9090");
            config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{id}",

                 defaults: new { id = RouteParameter.Optional });

            HttpSelfHostServer server = new HttpSelfHostServer(config);
            server.OpenAsync().Wait();

                
           
        }

        protected override void OnStop()
        {
        }
    }
}
