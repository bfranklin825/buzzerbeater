﻿using System.Web;
using System.Web.Optimization;

namespace BuzzerBeater
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.2.0.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/require").Include(
                "~/Scripts/require.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.united.css",
                      "~/Content/site.css"));

            //bundles.Add(new ScriptBundle("~/bundles/app").Include(
            //       "~/Scripts/knockout-{version}.js",
            //       "~/Scripts/ko/login.js"));

            //bundles.Add(new ScriptBundle("~/bundles/verify").Include(
            //    "~/Scripts/knockout-{version}.js",
            //    "~/Scripts/ko/EmailVerification.js"));

            //bundles.Add(new ScriptBundle("~/bundles/confirm").Include(
            //    "~/Scripts/knockout-{version}.js",
            //    "~/Scripts/ko/ConfirmEmail.js"));

            bundles.Add(new ScriptBundle("~/bundles/config").Include(
                "~/Scripts/RequireConfig.js"
                //"~/Scripts/knockout-{version}.js"
                ));
        }
    }
}
