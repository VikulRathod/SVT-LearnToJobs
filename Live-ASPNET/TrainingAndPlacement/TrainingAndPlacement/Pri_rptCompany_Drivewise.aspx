<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pri_rptCompany_Drivewise.aspx.cs" Inherits="TrainingAndPlacement.Pri_rptCompany_Drivewise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Company Wise Drive List
        <small>Reports</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">All Reports</a></li>
            <li><a href="#">Company Reports</a></li>
            <li><a href="#">Company Wise Drive</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-4 ser-fet">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Academic: </button>
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
                        <div class="col-md-4">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Company Id:</button>
                                </div>
                                <asp:DropDownList ID="ddlCompany" runat="server" class="form-control">
                                </asp:DropDownList>
                            </div>
                            <br />
                        </div>
                        <div class="col-md-3 ser-fet">
                            <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                        </div>

                    </div>
                </div>
                <!-- /.box-body -->
           </div>
        </div>

        <div class="box box-info ">

            <div class="box-header with-border">
                <h3 class="box-title">Company Wise Drive Reports View</h3>
                <div class="box-tools pull-right">
                    <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click"><i class="fa fa-download"></i> Download Excel</asp:LinkButton>
                </div>
            </div>
            <!-- /.box-header -->
            <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                <div class="form-group">
                    <asp:GridView ID="gvCompany_Drive" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                        <RowStyle HorizontalAlign="Center" />
                        <Columns>
                            <asp:BoundField HeaderText="Company Id" DataField="Company_ID" />
                             <asp:BoundField HeaderText="Academic_Year" DataField="Academic_Year" />
                            <asp:BoundField HeaderText="Company Name" DataField="Company_Name" />
                            <asp:BoundField HeaderText="Drive_Title" DataField="Drive_Title" />
                            <asp:BoundField HeaderText="Post_Opened" DataField="Post_Opened" />
                            <asp:BoundField HeaderText="Job_Type" DataField="Job_Type" />
                            <asp:BoundField HeaderText="Job_Profile" DataField="Job_Profile" />
                            <asp:BoundField HeaderText="Salary" DataField="Salary" />
                            <asp:BoundField HeaderText="Vacancies" DataField="Vacancies" />
                            <asp:BoundField HeaderText="Bond" DataField="Bond" />
                            <asp:BoundField HeaderText="Bond_Duration" DataField="Bond_Duration" />
                            <asp:BoundField HeaderText="Bond_Amount" DataField="Bond_Amount" />
                            <asp:BoundField HeaderText="Bond_Terms" DataField="Bond_Terms" />
                            <asp:BoundField HeaderText="Security_Deposite" DataField="Security_Deposite" />
                            <asp:BoundField HeaderText="Joining_Date" DataField="Joining_Date" />
                            <asp:BoundField HeaderText="Gender_Allowed" DataField="Gender_Allowed" />
                            <asp:BoundField HeaderText="Recruitment_Method" DataField="Recruitment_Method" />
                            <asp:BoundField HeaderText="Job_Location" DataField="Job_Location" />
                            <asp:BoundField HeaderText="Reg_From_Date" DataField="Reg_From_Date" />
                            <asp:BoundField HeaderText="Reg_To_Date" DataField="Reg_To_Date" />
                            <asp:BoundField HeaderText="Doc_Needed" DataField="Doc_Needed" />
                            <asp:BoundField HeaderText="Remark" DataField="Remark" />
                            <asp:BoundField HeaderText="Company_Coordinator" DataField="Company_Coordinator" />
                            <asp:BoundField HeaderText="Company_Designation" DataField="Company_Designation" />
                            <asp:BoundField HeaderText="Company_Contact" DataField="Company_Contact" />
                            <asp:BoundField HeaderText="Institute_Coordinator" DataField="Institute_Coordinator" />
                            <asp:BoundField HeaderText="Institute_Designation" DataField="Institute_Designation" />
                            <asp:BoundField HeaderText="Institute_Contact" DataField="Institute_Contact" />
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
    </section>
</asp:Content>
