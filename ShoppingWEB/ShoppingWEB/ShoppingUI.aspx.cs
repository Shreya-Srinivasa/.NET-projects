using System;
using Services;

namespace ShoppingWEB
{
    public partial class ShoppingUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicesCode objServices = new ServicesCode();
            gvProducts.DataSource = objServices.GetProductsBAL();
            gvProducts.DataBind();
        }
    }
}