<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Placement.Master" AutoEventWireup="true" CodeBehind="Drive_Settings.aspx.cs" Inherits="TrainingAndPlacement.Drive_Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Drive Settings</h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Add Drive</a></li>
            <%--  <li><a href="Deactiveted.aspx">Deactiveted Edit</a></li>--%>
        </ol>
    </section>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-12 ser-fet">
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Academic Year *: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlAcademic" runat="server" class="form-control">
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
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Company ID *: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged" AutoPostBack="True">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Drive Title *:</button>
                                    </div>
                                    <asp:DropDownList ID="ddlDriveTitle" runat="server" class="form-control" AutoPostBack="False">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="col-md-12 ser-fet">
                            <div class="col-md-4"></div>
                            <div class="col-md-4">
                                <asp:Button ID="btnsave" runat="server" Text="Active Drive" class="btn btn-primary" ValidationGroup="Teacher" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-4">
                                <asp:Button ID="tbnDeactive" runat="server" Text="Deactive Drive" class="btn btn-primary" OnClick="tbnDeactive_Click" />
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
            <div class="col-md-1"></div>
        </div>

        <div class="box box-info ">
            <div class="box-header with-border">
                <h3 class="box-title">Drive List</h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                <asp:GridView ID="gvDrive" CssClass="table table-striped table-bordered table-hover" runat="server"
                    CellPadding="3" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                    BorderWidth="1px" DataKeyNames="Drive_Title" EnableModelValidation="True">
                    <Columns>
                        <asp:BoundField DataField="Drive_Title" HeaderText="Drive_Title" ReadOnly="True" />
                        <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" />
                        <asp:BoundField DataField="Reg_From_Date" HeaderText="Registration Date From" ReadOnly="True" />
                        <asp:BoundField DataField="Reg_To_Date" HeaderText="Registration Date To" ReadOnly="True" />
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </section>
</asp:Content>
