﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebInterface.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="ResultOfChecking" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Result of Checking</title>
</head>
<body>
    <form id="form1" runat="server">
       <h2>Checking Result</h2>

        <asp:ListView ID="ListWiewResult" runat="server">
         <LayoutTemplate>
        <table runat="server">
            <tr runat="server">
                <td runat="server">
                    <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                            <th runat="server">Id</th>
                            <th runat="server">IdTestCase</th>
                            <th runat="server">DateTime</th>
                            <th runat="server">Result</th>
                            <th runat="server">CountToken</th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server">
                        </tr>
                    </table>
                </td>
            </tr>
             <tr  runat="server">
                 <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
            </tr>
        </table>  
         </LayoutTemplate>
            <AlternatingItemTemplate>
                <tr style="background-color:#FFF8DC;">
                   <td><%# Eval("Id") %></td>
                <td><%# Eval("IdTestCase") %></td>
                <td><%# Eval("DateTime") %></td>
                <td><%# Eval("Result") %></td>
                <td><%# Eval("CountToken") %></td>
                </tr>
            </AlternatingItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>Нет данных.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
           
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                 <td><%# Eval("Id") %></td>
                <td><%# Eval("IdTestCase") %></td>
                <td><%# Eval("DateTime") %></td>
                <td><%# Eval("Result") %></td>
                <td><%# Eval("CountToken") %></td>
            </tr>
        </ItemTemplate>
           
        </asp:ListView>
 
    </form>
</body>
</html>
