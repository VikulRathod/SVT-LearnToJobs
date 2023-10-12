<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pri_rptStud_Apply_Drive.aspx.cs" Inherits="TrainingAndPlacement.Pri_rptStud_Apply_Drive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <section class="content-header">
        <h1>Drive Wise Applied Student  
        <small>Report</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">All Reports</a></li>
            <li><a href="#">Student Reports</a></li>
            <li><a href="#">Drive Wise Applied Student </a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header  with-border">
                        <h3 class="box-title">Search Student List Option</h3>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <div class="col-md-3">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Academic: </button>
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
                            <div class="col-md-3">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Company Id:</button>
                                    </div>
                                    <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged" AutoPostBack="True">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Drive Title: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlDrive" runat="server" class="form-control">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-2">
                                <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                            </div>
                            <%--</div>--%>
                        </div>
                    </div>
                </div>
                <div class="box box-info ">

                    <div class="box-header with-border">
                        <div class="col-md-9">
                            <h3 class="box-title">List of Drive Wise Applied Student  </h3>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click"><i class="fa fa-download"></i> Download Excel</asp:LinkButton>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                        <div class="form-group">
                            <asp:GridView ID="gvStudent_Apply" CssClass="table table-striped table-bordered table-hover"
                                runat="server" CellPadding="3" AutoGenerateColumns="False" BackColor="White"
                                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" DataKeyNames="id"
                                EnableModelValidation="True">
                                <Columns>

                                    <asp:BoundField DataField="Student_ID" HeaderText="Student_ID" ReadOnly="True" />
                                    <asp:BoundField DataField="Student_Name" HeaderText="Student Name" ReadOnly="True" />
                                    <asp:BoundField DataField="Contact_No" HeaderText="Contact No." ReadOnly="True" />
                                    <asp:BoundField DataField="Email" HeaderText="	Email" ReadOnly="True" />
                                    <asp:BoundField DataField="Department" HeaderText="Department" ReadOnly="True" />
                                    <asp:BoundField DataField="AppliedDate" HeaderText="AppliedDate" ReadOnly="True" />
                                    <asp:BoundField DataField="Round" HeaderText="Round" ReadOnly="True" />
                                    <asp:BoundField DataField="id" HeaderText="Application ID" ReadOnly="True" />
                                </Columns>

                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#e1e7ea" Font-Bold="True" ForeColor="#000" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000" />
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
        </div>
    </section>
</asp:Content>
