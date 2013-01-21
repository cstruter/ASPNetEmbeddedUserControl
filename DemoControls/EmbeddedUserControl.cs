using System.Web.UI.WebControls;
using System.Web.UI;
using System.IO;
using System.Reflection;

namespace DemoControls
{
    public abstract class EmbeddedUserControl : CompositeControl
    {
        protected Control UserControls;

        public T Control<T>(string id) where T : Control
        {
            this.EnsureChildControls();
            return (T)UserControls.FindControl(id);
        }

        protected override void CreateChildControls()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string name = this.GetType().Namespace + "." + this.GetType().Name + ".ascx";

            using (StreamReader sr = new StreamReader(assembly.GetManifestResourceStream(name)))
            {
                string content = sr.ReadToEnd();
                UserControls = (DesignMode) ? new LiteralControl(content) : Page.ParseControl(content);
            }
            this.Controls.Add(UserControls);
            base.CreateChildControls();
        }
    }
}