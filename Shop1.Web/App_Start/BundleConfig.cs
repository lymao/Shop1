﻿using System.Web;
using System.Web.Optimization;

namespace Shop1.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery").Include("~/Assets/client/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/js/plugins").Include(
                 "~/Assets/admin/libs/jquery-ui/jquery-ui.min.js",
                 "~/Assets/admin/libs/mustache/mustache.js",
                 "~/Assets/admin/libs/numeral/numeral.js",
                 "~/Assets/admin/libs/jquery-validation/dist/jquery.validate.js",
                 "~/Assets/client/js/common.js"
                ));

            bundles.Add(new StyleBundle("~/css/base")
                .Include("~/Assets/client/css/bootstrap.css",
                "~/Assets/client/font-awesome-4.6.3/css/font-awesome.css",
                "~/Assets/admin/libs/jquery-ui/themes/smoothness/jquery-ui.min.css",
                "~/Assets/client/css/style.css",
                "~/Assets/client/css/custom.css"
                ));
            BundleTable.EnableOptimizations = true;

        }
    }
}
