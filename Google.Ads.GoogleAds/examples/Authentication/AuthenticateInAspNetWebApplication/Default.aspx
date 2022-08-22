<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Google.Ads.GoogleAds.Examples.Default" Async="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <table>
      <tr>
        <td>Login Status</td>
        <% if (loginHelper.IsLoggedIn)
            {%>
        <td>Logged In</td>
        <td>
          <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" /></td>
        <% }
          else
          {%>
        <td>Not Logged In</td>
        <td>
          <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
        <% } %>
      </tr>
      <tr>
        <td>Customer ID
        </td>
        <td>
          <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        </td>
        <td>
          <asp:Button ID="btnGetCampaigns" runat="server" Text="Get Campaigns" OnClick="btnGetCampaigns_Click" />
        </td>
      </tr>
    </table>
    <asp:Table ID="CampaignTable" runat="server">
    </asp:Table>
  </form>
</body>
</html>