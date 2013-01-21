using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace DemoControls
{
    [ToolboxData("<{0}:Browser runat=server></{0}:Browser>")]
    public class browser : EmbeddedUserControl
    {
        protected TextBox txtUrl;
        protected Button btnDisplay;
        protected HtmlGenericControl ifBrowser;

        protected override void OnLoad(EventArgs e)
        {
            txtUrl = Control<TextBox>("txtUrl");
            btnDisplay = Control<Button>("btnDisplay");
            ifBrowser = Control<HtmlGenericControl>("ifBrowser");            
            btnDisplay.Click += new EventHandler(btnDisplay_Click);
            base.OnLoad(e);
        }

        void btnDisplay_Click(object sender, EventArgs e)
        {
            ifBrowser.Attributes["src"] = txtUrl.Text;
        }
    }
}
