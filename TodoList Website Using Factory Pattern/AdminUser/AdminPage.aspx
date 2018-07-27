<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="AdminUser_AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="height: 0px; width: 1343px">
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style47">
                <p style="text-align: center">
                    <strong>Admin Page</strong>
                </p>
            </td>

            <td><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User:</strong><asp:label id="UserLabel" runat="server" text="Label"></asp:label></td>

        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <asp:treeview id="TreeView1" runat="server">
        <Nodes>
            <asp:TreeNode NavigateUrl="~/WelcomePage.aspx" Text="Welcome Page" Value="Welcome Page"></asp:TreeNode>
        </Nodes>
    </asp:treeview>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">

    <br />
    <asp:multiview id="MultiView" runat="server">
            <asp:View ID="AdminView" runat="server">
                <table style="align-content: center; vertical-align: central">
                    <tr>
                        <td class="auto-style33"></td>
                        <td class="auto-style22"></td>
                        <td class="auto-style23"></td>
                        <td class="auto-style20">
                            <asp:LinkButton ID="LogoutLinkButton" runat="server" OnClick="LogoutLinkButton_Click">Logout</asp:LinkButton>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style34">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Select a User Id to get User TodoLists</td>
                        <td class="auto-style25">
                            <asp:DropDownList ID="MailIDDropDownList" runat="server" AutoPostBack="True" class="Yelowy" OnSelectedIndexChanged="MailIDDropDownList_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style26">
                            &nbsp;<asp:Button ID="UserDetailsButton" runat="server" class="Yelowy" Text="User Details&gt;&gt;" Height="32px" Width="147px" OnClick="UserDetailsButton_Click" />
                        </td>
                        <td class="auto-style27"></td>
                    </tr>
                    

                    </table>
                     
                <table style="width: 808px">       
                    <tr>
                        <td class="auto-style19"></td>
                        <td class="auto-style15">
                            <asp:GridView ID="UserListsGridView" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ShowHeaderWhenEmpty="True">
                                <EmptyDataTemplate>
                                    No Items To Display
                                </EmptyDataTemplate>
                                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" ForeColor="#003399" />
                                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                                <SortedDescendingHeaderStyle BackColor="#002876" />
                            </asp:GridView>
                        </td>
                        <td class="auto-style35">
                            <asp:Label ID="GridViewErrorLabel" runat="server" ForeColor="#FF6600"></asp:Label>
                        </td>
                        <td class="auto-style46"></td>
                    </tr>
                    <tr>
                        <td class="auto-style28"></td>
                        <td class="auto-style31"></td>
                        <td class="auto-style36"></td>
                        <td class="auto-style29"></td>

                    </tr>
                        <tr>
                        <td class="auto-style18"></td>
                        <td class="auto-style32"></td>
                        <td class="auto-style37"></td>
                        <td class="auto-style30"></td>

                    </tr>
                </table>
            </asp:View>
            <asp:View ID="AdminUserDetailsView" runat="server">
                <table style="align-content: center; vertical-align: central">
                    <tr>
                        <td class="auto-style33"></td>
                        <td class="auto-style22"></td>
                        <td class="auto-style23"></td>
                        <td class="auto-style20">
                            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WelcomePage.aspx">Logout</asp:LinkButton>
                        </td>
                    </tr>
                    
                    <tr>
                        <td class="auto-style34">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select a User Id to get User Details</td>
                        <td class="auto-style25">
                            <asp:DropDownList ID="UserMailIDDropDownList" runat="server" AutoPostBack="True" class="Yelowy" OnSelectedIndexChanged="UserMailIDDropDownList_SelectedIndexChanged" >
                            </asp:DropDownList>
                        </td>
                        <td class="auto-style26">
                            &nbsp;<asp:Button ID="UserListsButton" runat="server" class="Yelowy" Text="&lt;&lt; Back" Height="33px" Width="152px" OnClick="UserListsButton_Click" />
                        </td>
                        <td class="auto-style27"></td>
                    </tr>
                    </table>
                <table style="height: 274px; width: 831px">
                    <tr>
                        <td class="auto-style16"></td>
                        <td class="auto-style17">
                            <asp:GridView ID="UserDetailsGridView" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowHeaderWhenEmpty="True">
                              
                                
                                <EmptyDataTemplate>
                                    No User Details To Display
                                </EmptyDataTemplate>
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                        </td>
                        <td class="auto-style49">
                            <br />
                            <asp:Label ID="ErrorLabel" runat="server" ForeColor="#FF6600"></asp:Label>
                        </td>
                        <td class="auto-style48"></td>
                    </tr>
                    <tr>
                        <td class="auto-style50"></td>
                        <td></td>
                        <td class="auto-style49"></td>
                        <td class="auto-style48"></td>


                    </tr>
                    <tr>
                        <td class="auto-style50"></td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="DeleteButton" runat="server" CssClass="Redy" style="text-align: center" Text="Delete User" OnClick="DeleteButton_Click" OnClientClick="ConfrimDelete()" Height ="41px" Width="165px" />
                        </td>
                        <td class="auto-style49">
                            <script type="text/javascript">
                                function ConfrimDelete() {
                                    var confirmDelete_value = document.createElement("INPUT");
                                    confirmDelete_value.type = "hidden";
                                    confirmDelete_value.name = "confirmDelete_value";
                                    if (confirm("Alert! the deleted User cant Login if once deleted, Do you want to Delete")) {
                                        confirmDelete_value.value = "Yes";
                                    } else {
                                        confirmDelete_value.value = "No";
                                    }
                                    document.forms[0].appendChild(confirmDelete_value);
                                }
                        </script>
                        </td>
                        <td class="auto-style48"></td>
                    </tr>
                </table>
            </asp:View>
        </asp:multiview>

</asp:Content>


<%--<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
        <meta http-equiv="X-UA-Compatible" content="IE=10" />

    

    <style type="text/css">
        .auto-style6 {
            width: 271px;
        }
        .auto-style7 {
            width: 366px;
        }
        .auto-style10 {
            width: 489px;
            height: 31px;
        }
        .auto-style11 {
            width: 277px;
            height: 31px;
        }
        .auto-style12 {
            width: 366px;
            height: 31px;
        }
        .auto-style13 {
            width: 271px;
            height: 31px;
        }
        .auto-style14 {
            width: 658px;
        }
        .auto-style15 {
            width: 347px;
        }
        .auto-style16 {
            width: 489px;
        }
        .auto-style17 {
            width: 277px;
        }
        .auto-style18 {
            text-align: center;
        }
    </style>
</asp:Content>--%>



<asp:Content ID="Content5" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        
        .auto-style8 {
            width: 333px;
        }

        .auto-style15 {
            height: 225px;
            width: 237px;
        }

        .auto-style16 {
            height: 234px;
            width: 304px;
        }

        .auto-style17 {
            width: 80px;
        }

        .auto-style18 {
            height: 42px;
            width: 610px;
        }

        .auto-style19 {
            width: 610px;
        height: 225px;
    }

        .auto-style20 {
            width: 457px;
        height: 37px;
    }

        .auto-style22 {
            height: 37px;
            width: 541px;
        }

        .auto-style23 {
            width: 736px;
        height: 37px;
    }

        .auto-style25 {
            height: 9px;
            width: 541px;
        }

        .auto-style26 {
            width: 736px;
            height: 9px;
        }

        .auto-style27 {
            width: 457px;
            height: 9px;
        }
    .auto-style28 {
        height: 17px;
        width: 610px;
    }
    .auto-style29 {
        height: 17px;
    }
    .auto-style30 {
        height: 42px;
    }
    .auto-style31 {
        height: 17px;
        width: 237px;
    }
    .auto-style32 {
        height: 42px;
        width: 237px;
    }
    .auto-style33 {
        width: 919px;
        height: 37px;
    }
    .auto-style34 {
        width: 919px;
        height: 9px;
    }
    .auto-style35 {
        width: 395px;
        height: 225px;
    }
    .auto-style36 {
        height: 17px;
        width: 395px;
    }
    .auto-style37 {
        height: 42px;
        width: 395px;
    }
    .auto-style46 {
        width: 71px;
        height: 225px;
    }
    .auto-style47 {
        width: 674px;
    }
        .auto-style48 {
        width: 59px;
    }
    .auto-style49 {
        width: 146px;
    }
    .auto-style50 {
        width: 304px;
    }
    </style>
</asp:Content>




