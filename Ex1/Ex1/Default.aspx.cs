using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                this.diaDrpDwn.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                this.mesDrpDwn.Items.Add(i.ToString());
            }

            for (int i = 1900; i <= 2050; i++)
            {
                this.anoDrpDwn.Items.Add(i.ToString());
            }
        }
    }
}
