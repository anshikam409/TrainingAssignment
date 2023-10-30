using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question3ASPhtml.Pages
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == txtFamilyName.Text.Trim())
            {
                lblValidationMessage.Text = "Name must be different from Family Name.";
                lblValidationMessage.Visible = true;
                return;
            }

            if (txtAddress.Text.Trim().Length < 2)
            {
                lblValidationMessage.Text = "Address must have at least 2 letters.";
                lblValidationMessage.Visible = true;
                return;
            }

            if (txtCity.Text.Trim().Length < 2)
            {
                lblValidationMessage.Text = "City must have at least 2 letters.";
                lblValidationMessage.Visible = true;
                return;
            }

            if (txtZipCode.Text.Trim().Length != 5 || !int.TryParse(txtZipCode.Text.Trim(), out _))
            {
                lblValidationMessage.Text = "Zip Code must be 5 digits.";
                lblValidationMessage.Visible = true;
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text.Trim(), @"^(\d{2}-\d{2} \d{2}|\d{3}-\d{3}-\d{4})$"))
            {
                lblValidationMessage.Text = "Phone must be in the format XX-XX XX or XXX-XXX-XXXX.";
                lblValidationMessage.Visible = true;
                return;
            }

            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                lblValidationMessage.Text = "Invalid E-Mail address.";
                lblValidationMessage.Visible = true;
                return;
            }

            // All validations passed
            lblValidationMessage.Text = "Validation successful!";
            lblValidationMessage.ForeColor = System.Drawing.Color.Green;
            lblValidationMessage.Visible = true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}