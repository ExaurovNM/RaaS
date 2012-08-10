

namespace RadiantRFID.RaaS.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;

    using RadiantRFID.RaaS.Models;
    using RadiantRFID.RaaS.Services;
    using RadiantRFID.RaaS.Tools.Common;

    [Authorize]
    public class HomeController : Controller
    {

        private readonly IContextProvider contextProvider;

        private readonly DeviceRepositoryRMSService deviceRepositoryRMSService;

        public HomeController(IContextProvider contextProvider)
        {
            this.contextProvider = contextProvider;
            deviceRepositoryRMSService = new DeviceRepositoryRMSService();
        }

        public ActionResult Index()
        {
            var userSession = contextProvider.GetUserFromSession();
            var devices = deviceRepositoryRMSService.GetDevices(new NetworkCredential { UserName = userSession.UserName, Password = userSession.Password });

            IList<DeviceModel> model =
                devices.ToList().Select(
                    it => new DeviceModel { DeviceName = it.Description, MacAddress = it.MacAddress }).ToList();

            return this.View(model);
        }

        public ActionResult About()
        {
            return this.View();
        }
    }
}
