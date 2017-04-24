using System;

namespace change_masterPage_dynamically
{
    public class BasePage:System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {

            if (Session["Selected_MasterPage"] != null)
                {
                 MasterPageFile = Session["Selected_MasterPage"].ToString();
                
                }
           

        }
    }
}