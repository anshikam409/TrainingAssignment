using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspAssignment1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ddlItems.SelectedValue;
            if (!string.IsNullOrEmpty(selectedValue))
            {
                string imageUrl = GetImageUrl(selectedValue);
                imgItem.ImageUrl = imageUrl;
            }
            else
            {
                imgItem.ImageUrl = "~/Images/placeholder.jpg";
            }
        }
        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            string selectedValue = ddlItems.SelectedValue;
            if (!string.IsNullOrEmpty(selectedValue))
            {
                decimal itemCost = GetItemCost(selectedValue);
                lblCost.Text = "Cost: $" + itemCost.ToString();
            }
            else
            {
                lblCost.Text = "Please select an item.";
            }
        }

        private string GetImageUrl(string selectedItem)
        {
            return "~/Images/" + selectedItem.ToLower() + ".jpg";
        }

        private decimal GetItemCost(string selectedItem)
        {
            switch (selectedItem)
            {
                case "coke":
                    return 100.00m; 
                case "pizza":
                    return 600.00m; // Pizza price: $600
                case "oreo":
                    return 150.00m; // Oreo price: $150
                case "mcflurry":
                    return 150.00m; // McFlurry price: $150
                case "burger":
                    return 200.00m; // Burger price: $200
                default:
                    return 0.00m; // Default to 0 if item not found
            }
        }
    }
}
