using Sitecore;
using Sitecore.Mvc.Presentation;
using Sitecore.Speak.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCH.Foundation.ExperienceForms.Client.Models
{
    public class PageDataSourceRenderingModel : ComponentRenderingModel
    {
        public bool IsHideable
        {
            get;
            set;
        }

        public string Path
        {
            get;
            set;
        }

        public string LabelForIsHiddenWhen
        {
            get;
            set;
        }

        public string LabelForIsVisibleWhen
        {
            get;
            set;
        }
        public override void Initialize(Rendering rendering)
        {
            base.Initialize(rendering);
            LabelForIsHiddenWhen = GetString("LabelForIsHiddenWhen", "");
            LabelForIsVisibleWhen = GetString("LabelForIsVisibleWhen", "");
        }
        //public override void Initialize(Rendering rendering)
        //{
        //    //ScriptCategory = "foundationexperienceforms";

        //    base.Initialize(rendering);
        //    //ScriptCategory = "foundationexperienceforms";
        //    //InitializeModel(rendering);
        //    //string path = ((Sitecore.Data.Items.BaseItem)rendering.RenderingItem.InnerItem)["Path"];
        //    //string text = System.IO.Path.ChangeExtension(path, ".js");
        //    //string text2 = System.IO.Path.ChangeExtension(path, ".min.js");
        //    //if (Sitecore.Configuration.SpeakSettings.Html.MinifyScripts && Sitecore.IO.FileUtil.FileExists(text2))
        //    //{
        //    //    Requires.Script(ScriptCategory, System.IO.Path.GetFileName(text2) ?? string.Empty);
        //    //}
        //    //else if (Sitecore.IO.FileUtil.FileExists(text))
        //    //{
        //    //    Requires.Script(ScriptCategory, System.IO.Path.GetFileName(text) ?? string.Empty);
        //    //}


        //    //IsHideable = MainUtil.GetBool()
        //    Path = GetString("Path", "");
        //    //base.ScriptCategory = "components";
        //}
        //protected override void InitializeModel(Rendering rendering)
        //{
        //    base.ScriptCategory = "foundationexperienceforms";
        //    base.InitializeModel(rendering);
        //}
    }
}