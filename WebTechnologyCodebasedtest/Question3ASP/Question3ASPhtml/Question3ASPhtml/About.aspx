<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Question3ASPhtml.Pages.About" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validator</title>
    <script type="text/javascript">
        function validateDetails() {
            var name = document.getElementById('<%= txtName.ClientID %>').value;
            var familyName = document.getElementById('<%= txtFamilyName.ClientID %>').value;
            var address = document.getElementById('<%= txtAddress.ClientID %>').value;
            var city = document.getElementById('<%= txtCity.ClientID %>').value;
            var zipCode = document.getElementById('<%= txtZipCode.ClientID %>').value;
            var phone = document.getElementById('<%= txtPhone.ClientID %>').value;
            var email = document.getElementById('<%= txtEmail.ClientID %>').value;

            if (name.trim() === familyName.trim()) {
                alert("Name must be different from Family Name.");
                return false;
            }

            if (address.trim().length < 2) {
                alert("Address must have at least 2 letters.");
                return false;
            }

            if (city.trim().length < 2) {
                alert("City must have at least 2 letters.");
                return false;
            }

            if (!/^\d{5}$/.test(zipCode)) {
                alert("Zip Code must be 5 digits.");
                return false;
            }

            if (!/^(\d{2}-\d{2} \d{2}|\d{3}-\d{3}-\d{4})$/.test(phone)) {
                alert("Phone must be in the format XX-XX XX or XXX-XXX-XXXX.");
                return false;
            }

            if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
                alert("Invalid E-Mail address.");
                return false;
            }

            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Insert your details</h2>
            <asp:Label ID="lblValidationMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label><br />
 
            Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            Family Name: <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox><br />
            Address: <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />
            City: <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
            Zip Code: <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox><br />
            Phone: <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br />
            E-Mail: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
 
            <asp:Button ID="btnCheck" runat="server" Text="Check" OnClientClick="return validateDetails();" OnClick="btnCheck_Click" />
        </div>
    </form>
</body>
</html>