<%@ Page Title="" Language="C#" MasterPageFile="~/TodoListMasterPage.master" AutoEventWireup="true" CodeFile="UserTodoListLand.aspx.cs" Inherits="UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width:87%; height: 44px;">
        <tr>
            <td class="auto-style22"></td>
           
            <td style="width:70%;" ><p style="text-align: center; height: 38px; width: 695px; margin-left: 295px;">
        <strong>TODO LIST PAGE </strong> </td>
            
            <td><strong>User:</strong><asp:label Id="UserLabel" runat="server" text="Label"></asp:label></td>
        </tr>
    </table>
     
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <asp:TreeView ID="TreeView1" runat="server" NodeIndent="0" Height="34px" Width="16px" BorderStyle="None" BorderWidth="20px">
            <Nodes>
                <asp:TreeNode NavigateUrl="~/LogedInUser/UserTodoListLand.aspx" Text="TodoLists" Value="TodoLists"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/LogedInUser/UserTodoListArchive.aspx" Text="Completed Items" Value="Archives"></asp:TreeNode>
            </Nodes>
        </asp:TreeView>
    </p>
</asp:Content>








<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">

    <div>
        <asp:MultiView ID="UserMultiView" runat="server">
            <asp:View ID="TodolistView" runat="server">
               <table style="align-content: center; vertical-align: central">
                   <tr>
                       <td></td>
                       <td class="auto-style9"></td>
                       <td class="auto-style10"></td>
                       <td></td>
                       <td class="auto-style12">
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:LinkButton ID="LogOutLinkButton" runat="server" PostBackUrl="~/WelcomePage.aspx" style="font-size: medium" OnClick="LogOutLinkButton_Click">Logout</asp:LinkButton>
                       </td>
                   </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style9"></td>
                        <td class="auto-style10">
                            <asp:GridView ID="UserListsGridView" runat="server" ShowHeaderWhenEmpty="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="font-size: medium">
                                <EmptyDataTemplate>
                                    No Lists To Display
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
                        <td></td>
                        <td class="auto-style12">&nbsp;</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style10">&nbsp;</td>
                        <td></td>
                        <td class="auto-style12">&nbsp;</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style10">
                            <asp:Button ID="AddEditButton" runat="server" class="Bluey" OnClick="AddEditButton_Click" Text="Add/Edit TodoList" Height="32px" Width="170px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="EmailButton" runat="server" CssClass="Bluey" Height="34px" OnClick="EmailButton_Click" Text="Email TodoList " Width="170px" />
                        </td>
                        <td></td>
                        <td class="auto-style12">&nbsp;</td>
                    </tr>
                     <tr>
                         <td></td>
                        <td class="auto-style9">&nbsp;</td>
                        <td class="auto-style10">
                            <asp:Label ID="ErrorLabel" runat="server" ForeColor="#FF6600" style="font-size: medium"></asp:Label>
                         </td>
                         <td></td>
                        <td class="auto-style12">
                            
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="auto-style9"></td>
                        <td class="auto-style10">&nbsp;<asp:Label ID="EmailLabel" runat="server" Text="Please provide the Email ID:"></asp:Label>
&nbsp;
                            <asp:TextBox ID="EmailTextBox" required="required" runat="server"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="SendEmailButton" runat="server" CssClass="Bluey" OnClick="SendEmailButton_Click" Text="Send " />
                        </td>
                        <td></td>
                        <td class="auto-style12"></td>
                    </tr>
                </table>
                <br />
                <br />
            </asp:View>
            <asp:View ID="EditView" runat="server">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />


                <table style="align-content: center; vertical-align: central; width: 907px;">
                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style33"></td>
                        <td style="width: 250px"></td>

                    </tr>
                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style31">
                             <asp:Button ID="AddButton" runat="server" CssClass="Greeny" Height="36px" OnClick="AddButton_Click" Text="Add List" Width="106px" />
                             &nbsp;&nbsp;
                             <asp:Button ID="EditButton" runat="server" CssClass="Yelowy" Height="36px" OnClick="EditButton_Click" Text="Edit" Width="95px" />
                             &nbsp;&nbsp;
                             <asp:Button ID="DeleteButton" runat="server" CssClass="Redy" Height="35px" OnClick="DeleteButton_Click" Text="Delete" Width="103px" />
                             &nbsp; &nbsp;
                <br />
                        </td>
                        <td class="auto-style11">

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style25">
                            
<asp:GridView ID="EditGridView" runat="server" ShowHeaderWhenEmpty="True" OnSelectedIndexChanged="EditGridView_SelectedIndexChanged" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                        <asp:TemplateField HeaderText="Edit/Delete">

                            <ItemTemplate>
                                <asp:CheckBox ID="SelectCheckBox" runat="server" onclick ="CheckSingleCheckbox(this)" ></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>No Lists To Display</EmptyDataTemplate>
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
                        <td class="auto-style26">

                             
                            
                <br />


                
                        </td>
                    </tr>

                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style33">
                            <asp:Button ID="ArchiveButton" runat="server" class="Bluey" Height="36px" OnClick="ArchiveButton_Click" Text="Mark As Completed" Width="190px" />
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="ErrorSelectionLabel" runat="server" ForeColor="#FF6600" ></asp:Label>
                        </td>
                        <td></td>
                    </tr>
                     
                     <tr>
                         <td class="auto-style7"></td>
                        <td class="auto-style33">


                            <asp:Table ID="AddTable" runat="server" Height="80px" Width="278px">
                    <asp:TableRow ID="TableRow1" runat="server">
                        <asp:TableCell>
                            Title:<asp:TextBox  ID="AddTitleTextBox" runat="server"></asp:TextBox>
                            <asp:Label ID="TitleErrorLabel" runat="server"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            Description:<asp:TextBox ID="AddDescriptionTextBox"  runat="server"></asp:TextBox>
                            <asp:Label ID="DescriptionErrorLabel" runat="server"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="AddListButton" runat="server" class="Bluey" Height="31px" OnClick="AddSubmitButton_Click" Text="Submit" Width="80px" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                        </td>
                        <td class="auto-style19">
                        </td>
                    </tr>


                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style33">

                            <asp:Table ID="EditTable" runat="server" Height="74px" Width="472px">
                    <asp:TableRow ID="TableRow2" runat="server">
                        <asp:TableCell>
                            Title:<asp:TextBox ID="EditTitleTextBox"  runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            Description:<asp:TextBox ID="EditDescriptionTextBox"  runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="EditSubmitButton" runat="server" class="Bluey" Height="31px" OnClick="EditSubmitButton_Click" Text="Submit" Width="80px" />
                        </asp:TableCell>

                    </asp:TableRow>
                </asp:Table>



                        </td>
                        <td></td>

                    </tr>
                </table>
               


            </asp:View>
        </asp:MultiView>

    </div>

</asp:Content>



<asp:Content ID="Content5" runat="server" ContentPlaceHolderID="head">

    <script type="text/javascript">
        function CheckSingleCheckbox(ob) {
            var grid = ob.parentNode.parentNode.parentNode;
            var inputs = grid.getElementsByTagName("input");
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i].type == "checkbox") {
                    if (ob.checked && inputs[i] != ob && inputs[i].checked) {
                        inputs[i].checked = false;
                    }
                }
            }
        }
    </script>

    <%--<style type="text/css">
        .auto-style2 {
            width: 394px;
            height: 1px;
        }

        .auto-style3 {
            width: 468px;
        }

        .auto-style5 {
            width: 342px;
        }
        .auto-style11 {
            width: 342px;
            height: 8px;
        }
        .auto-style18 {
            width: 558px;
        }
        .auto-style19 {
            width: 558px;
            font-size: medium;
        }
        .auto-style21 {
            width: 287px;
        }
        .auto-style22 {
            width: 206px;
        }
        .auto-style25 {
            width: 443px;
            font-size: medium;
            height: 223px;
        }
        .auto-style26 {
            width: 143px;
            height: 223px;
        }
        .auto-style31 {
            height: 8px;
            width: 443px;
        }
        .auto-style33 {
            width: 443px;
        }
    </style>--%>
<style type="text/css">
    .auto-style7 {
        width: 192px;
    }
    .auto-style9 {
        width: 260px;
    }
    .auto-style10 {
        width: 532px;
    }
    .auto-style11 {
        width: 72px;
    }
    .auto-style12 {
        width: 121px;
    }
</style>
</asp:Content>



