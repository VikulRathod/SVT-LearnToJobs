<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pri_rptCompany_Wise_Stud.aspx.cs" Inherits="TrainingAndPlacement.Pri_rptCompany_Wise_Stud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Company Wise Student List
        <small>Reports</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Student Reports</a></li>
            <li><a href="#">Company Wise Student List</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header  with-border">
                        <h3 class="box-title">Search By Student Placed / Unplaced</h3>
                    </div>
                    <div class="box-body">
                        <div class="box box-default">
                            <div class="box-header with-border">
                                <div class="col-md-4">
                                    <asp:RadioButton ID="RadioCmpny" GroupName="Apply" runat="server" Text="Company Wise" AutoPostBack="true" OnCheckedChanged="RadioCmpny_CheckedChanged" />
                                </div>
                                <div class="col-md-4">
                                    <asp:RadioButton ID="RadioYearly" GroupName="Apply" runat="server" Text="Year & Company Wise" AutoPostBack="true" OnCheckedChanged="RadioYearly_CheckedChanged" />
                                </div>
                                <asp:Panel ID="Yearly" runat="server">
                                    <div class="col-md-4">
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
                                </asp:Panel>
                            </div>
                            <!-- /.box-body -->
                        </div>
                        <div class="form-group">
                            <asp:Panel ID="Company" runat="server">
                                <div class="col-md-4">
                                    <div class="input-group">
                                        <div class="input-group-btn">
                                            <button type="button" class="btn btn-danger">Company Id:</button>
                                        </div>
                                        <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control"></asp:DropDownList>
                                    </div>
                                    <br />
                                </div>
                            </asp:Panel>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Apply Status:</button>
                                    </div>
                                    <asp:DropDownList ID="ddlround" runat="server" class="form-control">
                                        <asp:ListItem>Select Status</asp:ListItem>
                                        <asp:ListItem Value="AllStud">All Student</asp:ListItem>
                                        <asp:ListItem Value="Placed">Placed</asp:ListItem>
                                        <asp:ListItem Value="Unplaced">Unplaced</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>


                            <div class="col-md-4">
                                <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Show Students  List</asp:LinkButton>
                            </div>
                            <%--</div>--%>
                        </div>
                    </div>
                </div>
                <div class="box box-info ">

                    <div class="box-header with-border">
                        <div class="col-md-9">
                            <h3 class="box-title">List of Student Placed / Unplaced </h3>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click"><i class="fa fa-download"></i> Download Excel</asp:LinkButton>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                        <div class="form-group">
                            <asp:GridView ID="gvStudent_Apply_Status" CssClass="table table-striped table-bordered table-hover"
                                runat="server" CellPadding="3" AutoGenerateColumns="False" BackColor="White"
                                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" DataKeyNames="id"
                                EnableModelValidation="True">
                                <Columns>
                                    <asp:BoundField DataField="id" HeaderText="Application Id" ReadOnly="True" />
                                    <asp:BoundField DataField="Academic_Year" HeaderText="Academic_Year" ReadOnly="True" />
                                    <asp:BoundField DataField="Department" HeaderText="Department" ReadOnly="True" />
                                    <asp:BoundField DataField="Company_Name" HeaderText="Course_Name" ReadOnly="True" />
                                    <asp:BoundField DataField="Drive_Title" HeaderText="Drive_Title" ReadOnly="True" />
                                    <asp:BoundField DataField="Student_Name" HeaderText="Student Name" ReadOnly="True" />
                                    <asp:BoundField DataField="Contact_No" HeaderText="Contact No." ReadOnly="True" />
                                    <asp:BoundField DataField="Email" HeaderText="	Email" ReadOnly="True" />
                                    <asp:BoundField DataField="Round" HeaderText="Round Status" ReadOnly="True" />
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
