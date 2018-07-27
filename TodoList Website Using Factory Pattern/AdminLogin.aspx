<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p  style="text-align: center" >
        <strong>ADMIN LOGIN PAGE</strong></p>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        &nbsp;<asp:treeview runat="server" Height="17px" Width="71px" OnSelectedNodeChanged="Unnamed1_SelectedNodeChanged">
            <Nodes>
                <asp:TreeNode NavigateUrl="~/WelcomePage.aspx" Text="Welcome Page" Value="Welcome Page"></asp:TreeNode>
            </Nodes>
        </asp:treeview>
        </p>
</asp:Content>


<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" Runat="Server">
    
    <table style="align-content: center; vertical-align: central">

        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14">&nbsp;&nbsp;&nbsp;&nbsp;User Email:</td>
            <td class="auto-style15">
                <asp:TextBox ID="AdminNameTextBox"  type="email" runat="server"></asp:TextBox>
                <span class="auto-style4">
                <br />
                nanchariaspdotnet@gmail.com<br />
                </span>
                <asp:RequiredFieldValidator ID="UserEmailRequiredFieldValidator" runat="server" ControlToValidate="AdminNameTextBox" ErrorMessage="Please Enter Email" ForeColor="#FF6600"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:</td>
            <td class="auto-style11">
                <asp:TextBox ID="AdminPwdTextBox"  runat="server"></asp:TextBox>
                <span class="auto-style4">
                <br />
                nanchari*123<br />
                </span></td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style12"></td>
            <td class="auto-style12"></td>
            <td class="auto-style12"></td>

        </tr>
        <tr>
             <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Button ID="AdminSignInButton" runat="server" class="Bluey" Height="32px" OnClick="AdminSignInButton_Click" Text="Sign In" Width="120px" />
                &nbsp;&nbsp;
                <asp:Button ID="ForgotPasswordButton" runat="server" OnClick="ForgotPasswordButton_Click" Height="32px" class="Bluey" Text="Forgot Password" />
                <br />
                <asp:Label ID="ErrorLabel" runat="server" ForeColor="#FF6600" style="font-size: medium"></asp:Label>
             </td>
            <td class="auto-style6"></td>

        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="SecurityQnLabel" runat="server" Text="Security Question:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="SecurityQuestionLabel" runat="server"></asp:Label>
            </td>
            <td class="auto-style6"></td>

        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Label ID="SecurityAnsLabel" runat="server" Text="Security Answer:"></asp:Label>
&nbsp;&nbsp;
                <asp:TextBox ID="SecurityAnsTextBox"  runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="SecurityAnswerLabel" runat="server" ForeColor="#009933" Text="(Same As Security Question)"></asp:Label>
                <br />
                <asp:RequiredFieldValidator ID="SecurityAnswerRequiredFieldValidator" runat="server" ControlToValidate="SecurityAnsTextBox" EnableClientScript="False" ErrorMessage="Please Enter Answer" ForeColor="#FF6600"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style6">
                <asp:Button ID="SecuritySubmitButton" runat="server" class="Bluey" Text="Submit" OnClick="SecuritySubmitButton_Click" />
            </td>

        </tr>
      
    </table>
        
    
    </asp:Content>


<%--<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    

    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 252px;
            font-size: medium;
        }
        .auto-style4 {
            width: 241px;
        }
        .auto-style5 {
            width: 241px;
            height: 31px;
        }
        .auto-style6 {
            width: 252px;
            height: 31px;
            font-size: medium;
        }
        .auto-style7 {
            width: 208px;
        }
        .auto-style8 {
            width: 208px;
            height: 31px;
        }
        .auto-style9 {
            font-size: medium;
        }
    </style>
</asp:Content>--%>



<%--<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            height: 3px;
            width: 802px;
        }
        .auto-style5 {
            font-size: medium;
            text-align: justify;
            width: 446px;
        }
        .auto-style7 {
            font-size: medium;
            text-align: justify;
            width: 457px;
        }
        .auto-style9 {
            font-size: medium;
            text-align: justify;
            width: 221px;
        }
        .auto-style10 {
            font-size: medium;
            text-align: justify;
            width: 409px;
        }
        .auto-style11 {
            width: 446px;
        }
        .auto-style12 {
            width: 457px;
        }
        .auto-style13 {
            width: 409px;
        }
    </style>
</asp:Content>--%>




<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style4 {
            color: #009933;
        }
        .auto-style6 {
            width: 482px;
        }
        .auto-style9 {
            width: 259px;
        }
        .auto-style10 {
            width: 139px;
        }
        .auto-style11 {
            width: 441px;
        }
    .auto-style12 {
        height: 31px;
    }
    .auto-style13 {
        width: 259px;
        height: 71px;
    }
    .auto-style14 {
        width: 139px;
        height: 71px;
    }
    .auto-style15 {
        width: 441px;
        height: 71px;
    }
    .auto-style16 {
        width: 569px;
        height: 71px;
    }
    </style>
</asp:Content>





