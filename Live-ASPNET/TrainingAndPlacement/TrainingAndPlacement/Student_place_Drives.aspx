<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="Student_place_Drives.aspx.cs" Inherits="TrainingAndPlacement.Student_place_Drives" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <script type="text/javascript">
         function openModal() {
             $('#change_pswd').modal('show');
         }

    </script>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1> Placement Drives
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
             <li><a href="../Index.aspx""><i class="fa fa-home"></i> Home</a></li>
            <li> Placement Drives</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-info ">
                    <div class="box-header with-border">
                        <h3 class="box-title">List of Placement Drives</h3>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body" align="center" style="overflow-x: scroll; height: 600px; width: 100%">
                        <asp:GridView ID="gvplace_Drives" CssClass="table table-striped table-bordered table-hover GridPager" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnPageIndexChanging="gvplace_Drives_PageIndexChanging" PageSize="22" AllowPaging="True" OnRowCommand="gvplace_Drives_RowCommand">
                            <Columns>
                                <asp:BoundField HeaderText="Drive ID" DataField="Drive_Id" />
                                <asp:BoundField HeaderText="Academic Year" DataField="Academic_Year" />
                                <asp:BoundField HeaderText="Company Id" DataField="Company_Id" />
                                <asp:BoundField HeaderText="Company Name" DataField="Company_Name" />
                                <asp:BoundField HeaderText="Drive Title" DataField="Drive_Title" />
                                <asp:BoundField HeaderText="Registration Start Date" DataField="Reg_From_Date" HtmlEncode="false" DataFormatString="{0:d}" />
                                <asp:BoundField HeaderText="Registration Last Date" DataField="Reg_To_Date" HtmlEncode="false" DataFormatString="{0:d}" />
                                <asp:TemplateField HeaderText="Drive Details">
                                    <ItemTemplate>
                                        <asp:Button ID="btnShowDrive" CommandArgument="<%#((GridViewRow)Container).RowIndex %>" CommandName="btnShowDrive" Text="Drive Details" runat="server"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apply">
                                    <ItemTemplate>
                                        <asp:Button ID="btnApply" CommandArgument="<%#((GridViewRow)Container).RowIndex %>" CommandName="btnApply" runat="server" Text="Apply Drive"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="White" ForeColor="#000066" />
                            <HeaderStyle BackColor="#e1e7ea" Font-Bold="True" ForeColor="#545252" />
                            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                            <RowStyle ForeColor="#000066" />
                            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#007DBB" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#00547E" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
