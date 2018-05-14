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

        public override void Initialize(Rendering rendering)
        {
            base.Initialize(rendering);
            //IsHideable = MainUtil.GetBool()
        }

    }
}