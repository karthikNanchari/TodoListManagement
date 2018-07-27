<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="UserLogin.aspx.cs" Inherits="UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p style="text-align: center">
        <strong style="font-size: medium">USER LOGIN PAGE&nbsp; </strong>
    </p>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <br />
    <br />
    <asp:TreeView runat="server">
        <Nodes>
            <asp:TreeNode NavigateUrl="~/WelcomePage.aspx" Text="Welcome Page" Value="Welcome Page"></asp:TreeNode>
        </Nodes>
    </asp:TreeView>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">


    <asp:MultiView ID="LoginMultiView" runat="server">
        <asp:View ID="LoginView" runat="server">
            <br />
            <table style="align-content: center; vertical-align: central; height: 141px; width: 83%;">
                <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>

                <tr>
                    <td class="auto-style64"></td>
                    <td class="auto-style59">
                        <p>
                            <span class="auto-style17">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MailId:</span>
                        </p>
                    </td>
                    <td class="auto-style68">
                        <asp:TextBox ID="UserNameTextBox" type="email"  runat="server"></asp:TextBox>
                        &nbsp;<span class="auto-style18"><br /> <span class="auto-style55">karthikaspdotnet@gmail.com</span><br />
                        <asp:RequiredFieldValidator ID="UserEmailIDRequiredFieldValidator" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Please Enter EmailId" ForeColor="#FF6600" EnableClientScript="False"></asp:RequiredFieldValidator>
                        </span></td>
                    <td class="auto-style7">
                        <asp:Button ID="DeActivateViewButton" runat="server" class="Yelowy" Height="30px" OnClick="DeActivateViewButton_Click" Text="De-Activate Account&gt;&gt;" Width="200px" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style65"></td>
                    <td class="auto-style60"><span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Password:</span><span class="auto-style5">&nbsp; </span></td>
                    <td class="auto-style69">
                        <asp:TextBox ID="PasswordTextBox"  runat="server"></asp:TextBox>
                        &nbsp;&nbsp; <span class="auto-style18"><span class="auto-style55">
                        <br />
                        karthik*123</span></span></td>
                    <td class="auto-style102">
                        <asp:Button ID="ActivateViewButton" runat="server" class="Yelowy" Height="30px" OnClick="ActivateViewButton_Click" Text="Activate Account&gt;&gt;" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style99"></td>
                    <td class="auto-style100"></td>
                    <td class="auto-style95">

                        <asp:Button ID="LoginButton" runat="server" class="Bluey" Text="Login" OnClick="LoginButton_Click" Height="32px" Width="149px" />
                        &nbsp;&nbsp;<asp:Button ID="ForgotPwdButton" runat="server" class="Bluey" Text="Forgot Password" OnClick="ForgotPwdButton_Click" Height="34px" Width="163px" />
                        &nbsp;<br />
                        &nbsp;<asp:Label ID="ErrorLabel" runat="server" ForeColor="#FF6600" Style="font-size: 14pt"></asp:Label>
                    </td>
                    <td class="auto-style101">

                        <br />
                        <br />

                        <br />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style67"></td>
                    <td class="auto-style88"></td>
                    <td class="auto-style68">
                        <asp:Label ID="SecurityQuestionLabel" runat="server" Text="Secuity Question:" Style="color: #003399"></asp:Label>
                        <asp:Label ID="SecurityQnLabel" runat="server" Style="color: #003399"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style22"></td>
                    <td class="auto-style89"></td>
                    <td class="auto-style28">
                        <asp:Label ID="SecurityAnsLabel" runat="server" Text="Security Answer:" Style="color: #003399"></asp:Label>
                        &nbsp;<asp:TextBox ID="SecurityAnsTextBox"  runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="SecurityAnswerLabel" runat="server" ForeColor="#009933" Text="(Same as Security Question)"></asp:Label>
                        <br />
                        <asp:RequiredFieldValidator ID="SecurityAnswerRequiredFieldValidator" runat="server" ControlToValidate="SecurityAnsTextBox" EnableClientScript="False" ErrorMessage="Please Enter Security Answer" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style24">
                        <asp:Button ID="SecurityAnsSubmitButton" runat="server" CssClass="Bluey" Height="31px" OnClick="SecurityAnsSubmitButton_Click" Text="Submit Answer" Width="156px" />
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                
                    
            </table>
            <br />
        </asp:View>

        <asp:View ID="DeActivateView" runat="server">
            <br />
            <br />
            <table style="align-content: center; vertical-align: central">
                <tr>

                    <td class="auto-style82"></td>
                    <td class="auto-style79">
                        <p>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MailId:
                        </p>
                    </td>
                    <td class="auto-style31">
                        <asp:TextBox ID="DeActivateMailTextbox"  runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;<span class="auto-style58">server@gmail.com<br /> </span>
                        <asp:RequiredFieldValidator ID="DeActivateRequiredFieldValidator" runat="server" ControlToValidate="DeActivateMailTextbox" ErrorMessage="Please Enter MailID" ForeColor="#FF6600" EnableClientScript="False"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="LoginViewButton" runat="server" class="Yelowy" OnClick="LoginViewButton_Click" Text="&lt;&lt;LoginView" Height="30px" Width="200px" />
                    </td>
                </tr>
                <tr>

                    <td class="auto-style83">&nbsp;</td>
                    <td class="auto-style25"><span class="auto-style6">Password:</td>
                    <td class="auto-style26">
                        <asp:TextBox ID="DeActivatePwdTextbox"  runat="server"></asp:TextBox>
                        &nbsp;&nbsp; <span class="auto-style58">server*111</span>
                        <br />
                        <asp:RequiredFieldValidator ID="DeactivatePwdRequiredFieldValidator" runat="server" ControlToValidate="DeActivatePwdTextbox" ErrorMessage="Plese Enter Password" ForeColor="#FF6600" EnableClientScript="False"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
                <tr>

                    <td class="auto-style84">&nbsp;</td>
                    <td class="auto-style80"></td>
                    <td class="auto-style15">

                        <asp:Button ID="DeActiveButton" runat="server" class="Bluey" Height="34px" Text="De-Activate" Width="127px" OnClick="DeActiveButton_Click" OnClientClick="ConfrimDeActivate()" />
                        <br />
                        <script type="text/javascript">
                            function ConfrimActivate() {
                                var confirmActivate_value = document.createElement("INPUT");
                                confirm_value.type = "hidden";
                                confirm_value.name = "confirmActivate_value ";
                                if (confirm("Do You want to Activate?")) {
                                    confirmActivate_value.value = "Yes";
                                } else {
                                    confirmActivate_value.value = "No";
                                }
                                document.forms[0].appendChild(confirmActivate_value);
                            }
                        </script>

                        <br />

                        <script type="text/javascript">
                            function ConfrimDeActivate() {
                                var confirm_value = document.createElement("INPUT");
                                confirm_value.type = "hidden";
                                confirm_value.name = "confirm_value";
                                if (confirm("Do You want to Deactivate?")) {
                                    confirm_value.value = "Yes";
                                } else {
                                    confirm_value.value = "No";
                                }
                                document.forms[0].appendChild(confirm_value);
                            }
                        </script>




                        <asp:Label ID="DeActivateErrLabel" runat="server" ForeColor="#FF6600"></asp:Label>
                    </td>
                    <td class="auto-style36">
                        <br />
                        <br />
                        &nbsp;</td>

                </tr>
                <tr>
                    <td class="auto-style85"></td>
                    <td class="auto-style86"></td>
                    <td class="auto-style31"></td>
                    <td></td>
                </tr>

            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:View>

        <asp:View ID="ActivateView" runat="server">
            <br />
            <br />
            <table style="align-content: center; vertical-align: central">
                <tr>

                    <td class="auto-style75"></td>

                    <script type="text/javascript">
                        function ConfrimActivate() {
                            var confirm_value = document.createElement("INPUT");
                            confirm_value.type = "hidden";
                            confirm_value.name = "confirm_value";
                            if (confirm("Do You want to Activate?")) {
                                confirm_value.value = "Yes";
                            } else {
                                confirm_value.value = "No";
                            }
                            document.forms[0].appendChild(confirm_value);
                        }
                    </script>
                    <td class="auto-style71">
                        <p>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MailId:
                        </p>
                    </td>
                    <td class="auto-style31">
                        <asp:TextBox ID="ActivateEmailTextbox"  runat="server"></asp:TextBox>
                        &nbsp;<span class="auto-style58">&nbsp;<br /> ucmcis@gmail.com<br /> &nbsp;<asp:RequiredFieldValidator ID="ActivateMailIdRequiredFieldValidator" runat="server" ControlToValidate="ActivateEmailTextbox" ErrorMessage="Please Enter MailID" ForeColor="#FF6600" EnableClientScript="False"></asp:RequiredFieldValidator>
                        &nbsp;</span></td>
                    <td class="auto-style7">
                        <asp:Button ID="ViewLoginButton" runat="server" class="Yelowy" Text="&lt;&lt;LoginView" Height="30px" Width="200px" OnClick="ViewLoginButton_Click" />
                    </td>
                </tr>
                <tr>

                    <td class="auto-style76"></td>
                    <td class="auto-style72"><span class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:</span> &nbsp;</td>
                    <td class="auto-style90">
                        <asp:TextBox ID="ActivatePwdTextbox"  runat="server"></asp:TextBox>

                        &nbsp;&nbsp;&nbsp; <span class="auto-style58">
                        <br />
                        ucmcis*<br /> </span>
                        <asp:RequiredFieldValidator ID="ActivatePwdRequiredFieldValidator" runat="server" ControlToValidate="ActivatePwdTextbox" ErrorMessage="Please Enter Password" ForeColor="#FF6600" EnableClientScript="False"></asp:RequiredFieldValidator>
                    </td>

                    <td class="auto-style91"></td>
                </tr>
                <tr>

                    <td class="auto-style77">&nbsp;</td>
                    <td class="auto-style36"></td>
                    <td class="auto-style15">

                        <asp:Button ID="ActivateButton" runat="server" class="Bluey" Height="34px" Text="Activate" Width="127px" OnClick="ActivateButton_Click" OnClientClick="ConfrimActivate()" />
                        <br />
                        <br />
                        <asp:Label ID="ActivateErrLabel" runat="server" ForeColor="#FF6600"></asp:Label>
                    </td>
                    <td class="auto-style36">
                        <br />
                        <br />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style78"></td>
                    <td></td>
                    <td class="auto-style31"></td>
                    <td></td>
                </tr>

            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:View>

    </asp:MultiView>
</asp:Content>


<asp:Content ID="Content5" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style5 {
            font-size: small;
        }

        .auto-style6 {
            font-size: medium;
        }

        .auto-style7 {
            width: 12px;
        }

        .auto-style15 {
            font-size: medium;
            text-align: justify;
            width: 546px;
            height: 41px;
        }

        .auto-style17 {
            font-size: medium;
            text-align: justify;
        }

        .auto-style18 {
            font-size: medium;
            text-align: justify;
            width: 27px;
        }

        .auto-style22 {
            width: 193px;
            height: 52px;
        }

        .auto-style24 {
            height: 52px;
        }

        .auto-style25 {
            text-align: center;
            font-size: 20pt;
            height: 6px;
            width: 107px;
        }

        .auto-style26 {
            font-size: medium;
            text-align: justify;
            width: 546px;
            height: 6px;
        }

        .auto-style27 {
            height: 6px;
        }

        .auto-style28 {
            height: 52px;
            width: 526px;
        }

        .auto-style31 {
            width: 546px;
        }

        .auto-style36 {
            height: 41px;
        }

        .auto-style55 {
            color: #009933;
        }

        .auto-style58 {
            color: #009933;
            font-size: medium;
        }

        .auto-style59 {
            font-size: medium;
            width: 88px;
        }

        .auto-style60 {
            text-align: center;
            font-size: 20pt;
            height: 13px;
            width: 88px;
        }

        .auto-style64 {
            font-size: small;
            width: 193px;
        }

        .auto-style65 {
            font-size: medium;
            text-align: justify;
            width: 193px;
            height: 13px;
        }

        .auto-style67 {
            width: 193px;
        }

        .auto-style68 {
            width: 526px;
        }

        .auto-style69 {
            font-size: medium;
            text-align: justify;
            width: 526px;
            height: 13px;
        }

        .auto-style71 {
            font-size: medium;
        }

        .auto-style72 {
            text-align: center;
            font-size: 20pt;
            height: 31px;
        }

        .auto-style75 {
            font-size: small;
            width: 227px;
        }

        .auto-style76 {
            font-size: medium;
            text-align: justify;
            width: 227px;
            height: 31px;
        }

        .auto-style77 {
            width: 227px;
            height: 41px;
        }

        .auto-style78 {
            width: 227px;
        }

        .auto-style79 {
            font-size: medium;
            width: 107px;
        }

        .auto-style80 {
            height: 41px;
            width: 107px;
        }

        .auto-style82 {
            font-size: small;
            width: 189px;
        }

        .auto-style83 {
            font-size: medium;
            text-align: justify;
            width: 189px;
            height: 6px;
        }

        .auto-style84 {
            height: 41px;
            width: 189px;
        }

        .auto-style85 {
            width: 189px;
        }

        .auto-style86 {
            width: 107px;
        }

        .auto-style88 {
            width: 88px;
        }

        .auto-style89 {
            width: 88px;
            height: 52px;
        }

        .auto-style90 {
            font-size: medium;
            text-align: justify;
            width: 546px;
            height: 31px;
        }

        .auto-style91 {
            height: 31px;
        }
        .auto-style95 {
            font-size: medium;
            text-align: justify;
            width: 526px;
            height: 81px;
        }
        .auto-style99 {
            width: 193px;
            height: 81px;
        }
        .auto-style100 {
            width: 88px;
            height: 81px;
        }
        .auto-style101 {
            height: 81px;
        }
        .auto-style102 {
            height: 13px;
        }
    </style>
</asp:Content>






