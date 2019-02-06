<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="RestaurentsApp.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    
<head runat="server">
    <title>Restaurant App</title>
    <script>
        
    </script>
</head>
    
<body>
    <div class="output"></div>
    <h2>Restuarant Finder</h2>
   <form runat="server"> 
    <div>
        <asp:Textbox runat="server" id="searchTb" ></asp:Textbox> <asp:Button runat="server" OnClick="searchBtn_Click" id="searchBtn" text="Search"></asp:Button>

    </div>
       <asp:GridView ID="GridView1" runat="server">
<Columns>
<asp:TemplateField>
    <ItemTemplate >
           <asp:Label ID="Label1" runat="server" Text='<%# Bind("name") %>'></asp:Label>
    </ItemTemplate>
</asp:TemplateField>
</Columns>
       </asp:GridView>
  </form>
</body>
</html>
