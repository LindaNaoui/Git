﻿using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region
            bundles.Add(new StyleBundle("~/Template/Css").Include(
                       "~/Content/main.css",
                       "~/Content/css/color_skins.css",
                      "~/Content/vendor/font-awesome/css/font-awesome.min.css",
                      "~/Content/css/bootstrap.css",
                      "~/Content/vendor/bootstrap-datepicker/css/bootstrap-datepicker3.min.css",
                      "~/Content/vendor/bootstrap-multiselect/bootstrap-multiselect.css",
                      "~/Content/vendor/summernote/dist/summernote.css",

                      "~/Content/vendor/dropify/css/dropify.min.css",

                      "~/Content/site.css"));
            #endregion
        }
    }
}
