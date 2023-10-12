<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="Pri_rpt_Drive_Details.aspx.cs" Inherits="TrainingAndPlacement.Pri_rpt_Drive_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1> Drives
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
             <li><a href="../Index.aspx""><i class="fa fa-home"></i> Home</a></li>
            <li> Drives Information</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-info ">
                    <div class="box-header with-border">
                        <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Academic Year *: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlAcademicYear" runat="server" class="form-control">
                                        <asp:ListItem>Select Academic Year </asp:ListItem>
                                        <asp:ListItem Value="2011-2012">2011-2012</asp:ListItem>
                                        <asp:ListItem Value="2012-2013">2012-2013</asp:ListItem>
                                        <asp:ListItem Value="2013-2014">2013-2014</asp:ListItem>
                                        <asp:ListItem Value="2013-2014">2014-2015</asp:ListItem>
                                        <asp:ListItem Value="2015-2016">2015-2016</asp:ListItem>
                                        <asp:ListItem Value="2016-2017">2016-2017</asp:ListItem>
                                        <asp:ListItem Value="2017-2018">2017-2018</asp:ListItem>
                                        <asp:ListItem Value="2018-2019">2018-2019</asp:ListItem>
                                        <asp:ListItem Value="2019-2020">2019-2020</asp:ListItem>
                                        <asp:ListItem Value="2020-2021">2020-2021</asp:ListItem>
                                        <asp:ListItem Value="2021-2022">2021-2022</asp:ListItem>
                                        <asp:ListItem Value="2022-2023">2022-2023</asp:ListItem>
                                        <asp:ListItem Value="2023-2024">2023-2024</asp:ListItem>
                                        <asp:ListItem Value="2024-2025">2024-2025</asp:ListItem>
                                        <asp:ListItem Value="2025-2026">2025-2026</asp:ListItem>
                                        <asp:ListItem Value="2026-2027">2026-2027</asp:ListItem>
                                        <asp:ListItem Value="2027-2028">2027-2028</asp:ListItem>
                                        <asp:ListItem Value="2028-2029">2028-2029</asp:ListItem>
                                        <asp:ListItem Value="2029-2030">2029-2030</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>


                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Company_ID *:</button>
                                    </div>
                                    <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Drive_Title *: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlDrive_Title" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlDrive_Title_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
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
