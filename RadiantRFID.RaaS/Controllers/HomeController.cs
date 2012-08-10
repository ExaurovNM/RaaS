

namespace RadiantRFID.RaaS.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;

    using RadiantRFID.RaaS.Models;
    using RadiantRFID.RaaS.Tools.DeviceRepositoryService;


    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserSession userSession = new UserSession
                {
                    Password = "password",
                    UserName = "test"
                };

            var httpSessionStateBase = this.HttpContext.Session;
            if (httpSessionStateBase != null)
            {
                httpSessionStateBase.Add("CurrentUser", userSession);
            }
            var client = new DeviceRepositoryClient();
            var credentials = new NetworkCredential("test", "password");
            if (client.ClientCredentials != null)
            {
                UserSession session =  httpSessionStateBase["CurrentUser"] as UserSession;
                client.ClientCredentials.UserName.Password = session.Password;
                client.ClientCredentials.UserName.UserName = session.UserName;
            }

            var items = client.GetItems();
            this.ViewBag.Message = "Welcome to ASP.NET MVC!";
            IList<DeviceModel> model = items.ToList().Select(it => new DeviceModel
                {
                    DeviceName = it.Description,
                    MacAddress = it.MacAddress
                }).ToList();
            return this.View(model);
        }

        public class UserSession
        {
            public string UserName { get; set; }

            public string Password { get; set; }     
        }

        public ActionResult About()
        {
            return this.View();
        }
    }
}
