using System;
using Services;
using Entities;

namespace ShoppingWEB
{
    public partial class ShoppingUI : System.Web.UI.Page
    {
        ServicesCode _objServices = new ServicesCode();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNewProduct.Visible = false;
            gvProducts.Visible = true;
            btnSubmit.Visible = false;

            ServicesCode _objServices = new ServicesCode();
            gvProducts.DataSource = _objServices.GetProductsBAL();
            gvProducts.DataBind();
            
            btnNewProduct.Click += BtnNewProduct_Click;
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewProduct.Text == "")
            {
                return;
            }
            else
            {
                Product objProduct = new Product() { productName = txtNewProduct.Text };
                if (_objServices.InsertProduct(objProduct))
                {
                    gvProducts.DataSource = _objServices.GetProductsBAL();
                    gvProducts.DataBind();
                    txtNewProduct.Visible = false;
                    gvProducts.Visible = true;
                    btnSubmit.Visible = false;
                }
                else
                {
                    gvProducts.DataSource = _objServices.GetProductsBAL();
                    gvProducts.DataBind();
                    txtNewProduct.Visible = false;
                    gvProducts.Visible = true;
                    btnSubmit.Visible = false;
                }

            }
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            btnSubmit.Visible = true;
            gvProducts.Visible = false;
            txtNewProduct.Visible = true;
            
        }
    }
}