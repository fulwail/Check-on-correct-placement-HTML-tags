<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WievTestCase.aspx.cs" Inherits="WebInterface.WievTestCase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Wiew TestCase</title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>TestCase</h2>

         <br />
         <asp:RadioButton ID="RadioButton1" Text="Загрузить свой файл"  GroupName="RadioGroup1" runat="server" Checked="True" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
         &nbsp;&nbsp;&nbsp;
         <br />
         <asp:RadioButton ID="RadioButton2" Text="Найти тестовый пример по id"  GroupName="RadioGroup1" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="True"  />
         <br />
         <br />
         <asp:FileUpload ID="FileUpload1" runat="server" ViewStateMode="Disabled" />
         <br />
        
         <asp:Label ID="Label1" runat="server"></asp:Label>
         <asp:TextBox ID="TextBoxId" runat="server" Height="19px" Width="205px" Visible="False"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="CheckButton" runat="server" OnClick="CheckButton_Click" Text="Поиск тестового варианта" Width="173px" />
         <br />
    </form>
</body>
</html>
