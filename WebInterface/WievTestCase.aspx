<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WievTestCase.aspx.cs" Inherits="WebInterface.WievTestCase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="StyleSheet.css"/>
    <title>Wiew TestCase</title>
</head>
<body>

    <form id="form1" runat="server">
                <div id="menu">
            <ul>
                <li><a href="WievTestCase.aspx">Check on Html tags</a></li>
                <li><a href="Default.aspx">Result of checking</a></li>
            </ul>
        </div>
                <h2>&nbsp;</h2>
                <h2>TestCase</h2>
         <asp:RadioButton ID="RadioButton1" Text="Загрузить свой файл"  GroupName="RadioGroup1" runat="server" Checked="True" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
         &nbsp;&nbsp;&nbsp;
         <br />
         <asp:RadioButton ID="RadioButton2" Text="Найти тестовый пример по id"  GroupName="RadioGroup1" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="True"  />
         <br />
         <asp:RadioButton ID="RadioButton3" runat="server" GroupName="RadioGroup1" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Ввести свой текст" AutoPostBack="True" />
                <br />
         <br />
         
         <asp:FileUpload ID="FileUpload1" runat="server" ViewStateMode="Disabled" />
         <asp:Label ID="Label1" runat="server"></asp:Label>
         <br />
         <asp:TextBox ID="TextBoxId" runat="server" Height="19px" Width="205px" Visible="False"></asp:TextBox>
                <br />
         <br />
         <asp:Button ID="CheckButton" runat="server" OnClick="CheckButton_Click" Text="Поиск тестового варианта" Width="173px" />
         <br />
         <asp:Label ID="Label2" runat="server"></asp:Label>
         <br />
    </form>
</body>
</html>
