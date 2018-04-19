using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Web;
using Sitecore.Web.PageCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCH.Foundation.ExperienceForms.Client.Pages
{
    public class PropertyGridForm : PageCodeBase
    {
        private const string FormParametersTemplateId = "{72E58860-AC29-47E1-A1C5-8F9E492DB999}";

        public Rendering PropertiesForm
        {
            get;
            set;
        }

        public override void Initialize()
        {
            Item item = PropertyGridForm.GetSettingsItem(WebUtil.GetQueryString("settingsid")) ?? PropertyGridForm.GetSettingsItem(this.PropertiesForm.Parameters["ConfigurationItem"]);
            if (item != null)
            {
                this.PropertiesForm.Parameters["ConfigurationItem"] = item.ID.ToString();
            }
        }

        protected override void MapRenderingsToProperties(RenderingContext context)
        {
            var renderings = context.PageContext.PageDefinition.Renderings;
            base.MapRenderingsToProperties(context);
        }

        private static Item GetSettingsItem(string itemId)
        {
            if (!string.IsNullOrEmpty(itemId) && ID.IsID(itemId))
            {
                Item item = ClientHost.Databases.Database.GetItem(itemId);
                if (item != null && item.TemplateID.ToString().Equals("{72E58860-AC29-47E1-A1C5-8F9E492DB999}", StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }
    }
}