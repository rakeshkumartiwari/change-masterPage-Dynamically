﻿using System;

namespace change_masterPage_dynamically
{
    public partial class Site1 : BaseMaster
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Selected_MasterPage"] = DropDownList1.SelectedValue;
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Session["Selected_MasterPage"] != null)
            {
                DropDownList1.SelectedValue = Session["Selected_MasterPage"].ToString();
            }

        }
    }
}