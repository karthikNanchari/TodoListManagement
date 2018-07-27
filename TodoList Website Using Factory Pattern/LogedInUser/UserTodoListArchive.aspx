<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="UserTodoListArchive.aspx.cs" Inherits="LogedInUser_UserTodoListArchive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style10"> <p style="text-align: center"><strong>    ARCHIVE PAGE</strong>

</p></td>
            <td><strong>User:</strong><asp:label Id="UserLabel" runat="server" text="Label"></asp:label></td>
        </tr>
    </table>
   
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
    <table style="align-content: center;  height: 300px; width: 989px;">
        <tr>
            <td></td>
            <td></td>
            <td class="auto-style13"></td>
            <td></td>
            <td>

            <asp:LinkButton ID="LogoutLinkButton" runat="server" PostBackUrl="~/WelcomePage.aspx" style="font-size: medium" OnClick="LogoutLinkButton_Click">Logout</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">

            </td>
            <td class="auto-style15">

            </td>
            <td class="auto-style16"></td>
            <td class="auto-style17">

                </td>
            <td class="auto-style18">

                </td>
        </tr>
        
        <tr>
            <td class="auto-style4">

            </td>
            <td class="auto-style8">


    <asp:GridView ID="UserArchiveGridView" runat="server" ShowHeaderWhenEmpty="True" style="font-size: medium" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <Columns>
            <asp:TemplateField HeaderText="Edit/Delete">

                <ItemTemplate>
                    <asp:CheckBox ID="SelectCheckBox" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>No Completed Items To Display</EmptyDataTemplate>
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
            <td class="auto-style13">
                <asp:Label ID="ErrorLabel" runat="server" ForeColor="#FF6600"></asp:Label>
            </td>
            <td>

                &nbsp;</td>
        <td class="auto-style2">

            <br />
            <br />

        </td>
        </tr>
        <tr>
            <td class="auto-style7">  </td>
            <td class="auto-style9"><asp:Button ID="DeleteButton" runat="server" class="Redy" Text="Delete" OnClick="DeleteButton_Click" Height="30px" Width="70px" />  &nbsp;  <asp:Button ID="SendBackButton" runat="server" class="Bluey" OnClick="SendBackButton_Click" Text="Send Back To TodoList" Height="30px" Width="242px" /></td>
            <td class="auto-style13"></td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style4">

        </td>
            
            <td class="auto-style8">

    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    

            </td>
            <td class="auto-style13"></td>
        <td class="auto-style2">

        </td>
            <td></td>
        </tr>
       
    </table>


    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">


    <asp:TreeView ID="TreeView1" runat="server" NodeIndent="0" Height="136px" Width="16px" BorderStyle="None" BorderWidth="20px">
        <Nodes>
            <asp:TreeNode NavigateUrl="~/LogedInUser/UserTodoListLand.aspx" Text="TodoLists" Value="TodoLists"></asp:TreeNode>
        </Nodes>
    </asp:TreeView>


</asp:Content>


<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
        <meta http-equiv="X-UA-Compatible" content="IE=10" />
    <style type="text/css">
        .auto-style2 {
            width: 291px;
        }
        .auto-style4 {
            width: 240px;
        }
        .auto-style7 {
            height: 74px;
            width: 143px;
        }
        .auto-style8 {
            width: 393px;
            font-size: x-large;
        }
        .auto-style9 {
            height: 74px;
            width: 393px;
        }
        .auto-style10 {
            width: 902px;
        }
        .auto-style11 {
            width: 209px;
        }
        .auto-style13 {
        width: 199px;
    }
    .auto-style14 {
        width: 240px;
        height: 27px;
    }
    .auto-style15 {
        width: 393px;
        font-size: x-large;
        height: 27px;
    }
    .auto-style16 {
        width: 199px;
        height: 27px;
    }
    .auto-style17 {
        width: 143px;
        height: 27px;
    }
    .auto-style18 {
        height: 27px;
    }
    </style>
</asp:Content>



