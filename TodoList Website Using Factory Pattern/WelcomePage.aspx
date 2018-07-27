<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="WelcomePage.aspx.cs" Inherits="WelcomePage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <p style="text-align: center">
        <strong><span class="auto-style8">Welcome to Todolist</span></strong>
    </p>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <p class="auto-style2">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">

    <table  style="align-content: center; vertical-align: central; height: 512px; width: 100%;" >
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">Click here for User Login&nbsp; </td>
            <td class="auto-style13">
                <asp:button id="UserLoginButton" runat="server" class="Bluey" height="31px" width="232px" text="User Login" postbackurl="~/UserLogin.aspx" />
            </td>
            <td class="auto-style14"></td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style16">Click here for New/Update Registration </td>
            <td class="auto-style17">
                <asp:button id="NewRegistrationButton" runat="server" class="Bluey" text="New Registration" height="31px" width="232px" postbackurl="~/New Registration.aspx" />
            </td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style19"></td>
            <td class="auto-style20">Click here for Admin Login</td>
            <td class="auto-style21">
                <asp:button id="AdminLoginButton" runat="server" class="Bluey" height="31px" width="232px" text="Admin Login" postbackurl="~/AdminLogin.aspx" />
            </td>
            <td class="auto-style22"></td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style7"></td>
            <td></td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
         <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
    </table>
    <p>
        &nbsp;
    </p>
</asp:Content>

<asp:Content ID="Content5" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style6 {
            width: 238px;
        }

        .auto-style7 {
            width: 279px;
        }
    .auto-style8 {
        font-size: medium;
    }
    .auto-style9 {
        width: 145px;
    }
    .auto-style10 {
            width: 52px;
        }
    .auto-style11 {
        width: 145px;
        height: 50px;
    }
    .auto-style12 {
        width: 279px;
        height: 50px;
    }
    .auto-style13 {
        font-size: x-large;
        height: 50px;
    }
    .auto-style14 {
        width: 52px;
        height: 50px;
    }
    .auto-style15 {
        width: 145px;
        height: 74px;
    }
    .auto-style16 {
        width: 279px;
        height: 74px;
    }
    .auto-style17 {
        height: 74px;
    }
    .auto-style18 {
        width: 52px;
        height: 74px;
    }
    .auto-style19 {
        width: 145px;
        height: 48px;
    }
    .auto-style20 {
        width: 279px;
        height: 48px;
    }
    .auto-style21 {
        font-size: x-large;
        height: 48px;
    }
    .auto-style22 {
        width: 52px;
        height: 48px;
    }
    </style>
</asp:Content>






