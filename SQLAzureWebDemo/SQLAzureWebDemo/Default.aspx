<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SQLAzureWebDemo._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Tables Available 
         <asp:GridView ID="gvTables" runat="server">
        </asp:GridView>
        
            <asp:Panel ID="Panel2" runat="server">
        
         Table Name: <asp:TextBox ID="txtTableName" runat="server" Text="myTable"></asp:TextBox>
                
            <asp:Button ID="Button2" runat="server" Text="Add New Table"  OnClick="Button2_Click"/>
        </asp:Panel>
    
        Data
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Panel ID="Panel1" runat="server">
        
         First Name: <asp:TextBox ID="txtFName" runat="server" Text="Goog"></asp:TextBox>
         Last Name : <asp:TextBox ID="txtLName" runat="server" Text="Val"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Add"  OnClick="Button1_Click"/>
        </asp:Panel>
       
        
        
    </div>
    </form>
</body>
</html>
