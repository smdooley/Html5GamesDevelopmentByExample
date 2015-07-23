using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Html5GamesDevelopmentByExample.UI.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new LessBundle("~/bundles/less").Include(
            //    "~/Content/*.less"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/chaptertwo/css").Include(
                "~/Content/ChapterTwo/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chaptertwo/js").Include(
                "~/Content/ChapterTwo/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterthree/css").Include(
                "~/Content/ChapterThree/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterthree/js").Include(
                "~/Content/ChapterThree/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterfour/css").Include(
                "~/Content/chapterfour/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterfour/js").Include(
                "~/Content/chapterfour/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterfive/css").Include(
                "~/Content/chapterfive/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterfive/js").Include(
                "~/Content/chapterfive/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chaptersix/css").Include(
                "~/Content/chaptersix/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chaptersix/js").Include(
                "~/Content/chaptersix/js/*.js"));

            bundles.Add(new StyleBundle("~/bundles/chapterseven/css").Include(
                "~/Content/chapterseven/css/*.css"));
            bundles.Add(new ScriptBundle("~/bundles/chapterseven/js").Include(
                "~/Content/chapterseven/js/*.js"));
        }
    }
}