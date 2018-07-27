<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="New Registration.aspx.cs" Inherits="New_Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p style="text-align: center" >
        <strong>NEW REGISTRATION PAGE&nbsp;</strong>
    </p>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <p>
        <br />
        <asp:TreeView ID="TreeView1" runat="server" Height="27px" Width="189px">
            <Nodes>
                <asp:TreeNode NavigateUrl="~/WelcomePage.aspx" Text="Welcome Page" Value="Welcome Page"></asp:TreeNode>
            </Nodes>
        </asp:TreeView>
    </p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">

    <table style="align-content: center; vertical-align: top">
        <tr>
            <td class="auto-style12">*Mandatory Fields</td>
            <td class="auto-style7"></td>
            <td style="width:180px; height:30px"></td>
            
        </tr>

        <tr>
            <td class="auto-style12"><span >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User Name*:</span></span></span><asp:TextBox ID="NewUserTextBox" runat="server"  ></asp:TextBox>
                <span >
                    <br />
                    <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" ControlToValidate="NewUserTextBox" ErrorMessage="Please Enter User Name" ForeColor="#FF3300" EnableClientScript="False" CssClass="auto-style4"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style7">&nbsp; Registration Email*:</span></span><asp:TextBox ID="NewUserEmailTextBox" type="email" runat="server" TextMode="Email" ></asp:TextBox>
                <span >
                    <br />
                    <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ControlToValidate="NewUserEmailTextBox" ErrorMessage="Please Enter Email" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
                    <br />
                </span>
                <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator1" runat="server" ControlToValidate="NewUserEmailTextBox" ErrorMessage="InValid Email Format" ForeColor="#FF3300" Style="font-size: medium" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" EnableClientScript="False"></asp:RegularExpressionValidator>
            </td>
            <td style=" height:30px"></td>

        </tr>

        <tr>
            <td class="auto-style13"><span class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Password*:</span></span></span><asp:TextBox ID="PwdTextBox" runat="server"  ></asp:TextBox>
                <span class="auto-style21">
                    <br />
                    <asp:RequiredFieldValidator ID="PwdRequiredFieldValidator" runat="server" ControlToValidate="PwdTextBox" ErrorMessage="Please Enter Password" ForeColor="#FF3300" EnableClientScript="False" CssClass="auto-style4"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style8">
                <span class="auto-style21">Re-EnterPassword*:</span>&nbsp;</span><asp:TextBox ID="ReEnterPwdTextBox" runat="server" ></asp:TextBox>
                <span class="auto-style21">
                    <br />
                    <asp:RequiredFieldValidator ID="RePwdRequiredFieldValidator" runat="server" ControlToValidate="ReEnterPwdTextBox" ErrorMessage="Please Enter Password" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
                <br />
                </span>
                <asp:CompareValidator ID="PassworddCompareValidator" runat="server" ControlToCompare="PwdTextBox" ControlToValidate="ReEnterPwdTextBox" CssClass="auto-style21" ErrorMessage="ReEntered Password do not match" ForeColor="#FF3300" EnableClientScript="False"></asp:CompareValidator>
            </td>
            <td style=" height:5%"></td>


        </tr>
        <tr>
            <td class="auto-style14"><span class="auto-style4">Security Question
                *:</span></span><asp:TextBox ID="SecurityQTextBox" runat="server"  ></asp:TextBox>
                <span class="auto-style21">
                    <br />
                    <asp:RequiredFieldValidator ID="SecurityQnRequiredFieldValidator" runat="server" ErrorMessage="Please Enter Security Qn" ControlToValidate="SecurityQTextBox" ForeColor="#FF3300" EnableClientScript="False" CssClass="auto-style4"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style9">
                <span class="auto-style21">&nbsp;&nbsp; Security Answer
                *:</span><asp:TextBox ID="SecurityAnsTextBox" runat="server" ></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="SecurityARequiredFieldValidator" runat="server" ErrorMessage="Please Enter Security Ans" ControlToValidate="SecurityAnsTextBox" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style16"></td>
           

        </tr>
        <tr >
            <td class="auto-style14"><span class="auto-style4">&nbsp; 
                </span><span class="auto-style21">
                    <br />
                </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phone&nbsp;No*:&nbsp;&nbsp; <asp:TextBox ID="PhoneTextBox" runat="server" Height="18px" Width="154px" ></asp:TextBox>
                
                <br />
&nbsp;&nbsp;&nbsp;
                
                (999)999-9999 
                <br />
                <asp:RequiredFieldValidator ID="PhoneNoRequiredFieldValidator" runat="server" ErrorMessage="Please Enter Phone No." ControlToValidate="PhoneTextBox" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="PhoneRegularExpressionValidator1" runat="server" ControlToValidate="PhoneTextBox" ErrorMessage="Please Enter Valid Number Format" ValidationExpression="^[01]?[- .]?\(?[2-9]\d{2}\)?[- .]?\d{3}[- .]?\d{4}$" ForeColor="#FF3300" EnableClientScript="False"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style9">
                &nbsp;&nbsp;&nbsp;&nbsp;<span class="auto-style21"><span class="auto-style4">Date Of Birth*:<asp:ImageButton ID="CalendarImageButton" runat="server" Height="20px" OnClick="CalendarImageButton_Click1" Width="20px" ImageUrl="~/Images/Calendar.jpg" CausesValidation="False" />
                <asp:TextBox ID="AgeTextBox" runat="server" TextMode="Date" ></asp:TextBox>
                <br />
                <br />
                </span>
                    <asp:RequiredFieldValidator ID="CalendarRequiredFieldValidator" runat="server" ErrorMessage="Please Enter  Date" ControlToValidate="AgeTextBox" ForeColor="#FF3300" EnableClientScript="False" CssClass="auto-style4"></asp:RequiredFieldValidator>

            </td>
            <td class="auto-style16">
                <span class="auto-style21">

                    <asp:Calendar ID="AgeCalendar" runat="server"   OnSelectionChanged="AgeCalendar_SelectionChanged" Height="16px" Width="16px" style="font-size: small"></asp:Calendar></td>

        </tr>




        <tr>
            <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ZipCode*:</span></span></span><asp:TextBox ID="ZipCodeTextBox" runat="server" ></asp:TextBox>
                
                    <asp:RequiredFieldValidator ID="ZipCodeRequiredFieldValidator" runat="server" ErrorMessage="Please EnterZipCode" ControlToValidate="ZipCodeTextBox" EnableClientScript="False" ForeColor="#FF3300" CssClass="auto-style4"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style8">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Country*:</span></span>&nbsp;&nbsp;
                
                <asp:TextBox ID="CountryTextBox" runat="server" ></asp:TextBox>
                
                    <br />
                
                    <asp:RequiredFieldValidator ID="CountryRequiredFieldValidator" runat="server" ControlToValidate="CountryTextBox" ErrorMessage="Please Enter A Country" ForeColor="#FF3300" EnableClientScript="False"></asp:RequiredFieldValidator>
            </td>
            <td style=" height:5%"></td>
        </tr>

        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style11"></td>
            <td style=" height:20px"></td>
        </tr>

        <tr>
            <td class="auto-style13">
                
                    <asp:Button ID="SubmitButton" runat="server" class="Bluey" OnClick="SubmitButton_Click" Height="34px" Width="217px" Text="Submit Input" CssClass="Greeny" />
                
                    <br />
                
                <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="#FF6600" Style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style8">
                
                    &nbsp;&nbsp;&nbsp;
                <asp:Button ID="ClearInputButton" runat="server" class="Redy" Text="Clear Input" OnClick="ClearInputButton_Click" Height="34px" Width="217px" CssClass="Redy" />
                    <br />
                 
            </td>
            <td style=" height:5%"></td>

        </tr>
        <tr>
            <td class="auto-style13">
                <asp:Label ID="SubmissionLabel" runat="server" ForeColor="#339933" style="font-size: medium"></asp:Label>
                <asp:Button ID="LoginButton" runat="server" class="Bluey" OnClick="LoginButton_Click" Text="Go to Login Page" Height="34px" Width="217px" CssClass="Bluey" />
            </td>
            <td class="auto-style8">
                &nbsp;&nbsp;
                </td>
            <td style=" height:5%"></td>

        </tr>

    </table>

</asp:Content>


<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            height: 30px;
            width: 429px;
        }
        .auto-style8 {
            height: 5%;
            width: 429px;
        }
        .auto-style9 {
            height: 15%;
            width: 429px;
        }
        .auto-style11 {
            height: 20px;
            width: 429px;
        }
        .auto-style12 {
            height: 30px;
            width: 398px;
        }
        .auto-style13 {
            height: 5%;
            width: 398px;
        }
        .auto-style14 {
            height: 15%;
            width: 398px;
        }
        .auto-style15 {
            height: 20px;
            width: 398px;
        }
        .auto-style16 {
            height: 15%;
        }
    </style>
</asp:Content>



