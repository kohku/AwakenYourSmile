using Rainbow.Web.PostOffice;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AwakenYourSmile.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static CacheItemRemovedCallback OnCacheRemove = null;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AddTask("Notifications", Convert.ToInt32(ConfigurationManager.AppSettings["SecondsBetweenNotifications"]));
        }

        private void AddTask(string name, int seconds)
        {
            OnCacheRemove = new CacheItemRemovedCallback(CacheItemRemoved);
            HttpRuntime.Cache.Insert(name, seconds, null,
                DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration,
                CacheItemPriority.NotRemovable, OnCacheRemove);
        }

        public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
        {
            // do stuff here if it matches our taskname
            try
            {
                var today = DateTime.Now;

                var tomorrow = DateTime.Now.Date.AddDays(1);

                var appointments = Appointment.GetAppointments(today, tomorrow);

                if (appointments.Count > 0)
                {
                    var path = Server.MapPath(ConfigurationManager.AppSettings["NextAppointments"]);
                    var parameters = new Dictionary<string, string>();

                    using (var template = System.IO.File.OpenRead(path))
                    {
                        var message = PostOfficeService.Create(appointments, template, parameters);

                        message.IsBodyHtml = true;
                        message.To.Add(ConfigurationManager.AppSettings["AppointmentNotificationEmail"]);

                        PostOfficeService.SendMessage(message);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                AddTask("Notifications", Convert.ToInt32(ConfigurationManager.AppSettings["SecondsBetweenNotifications"]));
            }
        }
    }
}
