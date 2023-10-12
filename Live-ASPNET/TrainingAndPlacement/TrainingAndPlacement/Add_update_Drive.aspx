<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Add_update_Drive.aspx.cs" Inherits="TrainingAndPlacement.Add_update_Drive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add / Update Drive
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Add / Update Drive</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">

                <div class="box box-danger">
                    <div class="box-header with-border">
                        <h3 class="box-title">Drive Information</h3>
                        <div class="box-tools pull-right">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Search Drive for Update: </button>
                                </div>
                                <asp:DropDownList ID="ddlDrive_name" runat="server" class="form-control" OnSelectedIndexChanged="ddlDrive_name_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="box-body">
                        <!-- Member Full Name -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Academic Year *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlAcademic_Year" runat="server" class="form-control">
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
                            <div class="col-md-2 ser-fet">
                                <label>Company ID *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Company Name: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:Label ID="txtcompany_name" runat="server" class="form-control" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Drive Title *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDrive_Title" runat="server" placeholder="Enter Drive Title *" />
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Post Opened: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtPost_Opened" runat="server" placeholder="Enter Post Opened " />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Job Type: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtJob_Type" runat="server" placeholder="Enter Job Type " />
                            </div>
                        </div>

                        <!-- /.input group -->

                        <!-- /.form group -->
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Job Profile: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtJob_Profile" runat="server" placeholder="Enter Job Profile" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>CTC / Salary: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtSalary" runat="server" placeholder="Enter CTC / Salary" />
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Number of Vacancies: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtVacancies" runat="server" placeholder="Enter Number of Vacancies" MaxLength="4" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Bond Yes / No: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:DropDownList ID="ddlbond" runat="server" class="form-control">
                                    <asp:ListItem>---Select----</asp:ListItem>
                                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                                    <asp:ListItem Value="No">No</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Bond Duration: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtBond_Duration" runat="server" placeholder="Enter Bond Duration" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Bond Amount: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtBond_Amount" runat="server" placeholder="Enter Bond Amount" />
                            </div>
                        </div>

                        <!-- /.input group -->

                        <!-- /.form group -->
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Bond Terms: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtBond_Terms" runat="server" placeholder="Enter  Bond Terms" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Security Deposite: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtSecurity_Deposite" runat="server" placeholder="Enter Security Deposite" />
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Joining Date *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <ajaxToolkit:CalendarExtender ID="txtC_dob_CalendarExtender" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtJoining_Date" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtJoining_Date" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                <asp:TextBox class="form-control" ID="txtJoining_Date" runat="server" placeholder="Enter Joining Date *" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Gender Allowed *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:DropDownList ID="ddlGender_Allowed" runat="server" class="form-control">
                                    <asp:ListItem Value="Both">Both</asp:ListItem>
                                    <asp:ListItem Value="Male">Male</asp:ListItem>
                                    <asp:ListItem Value="Female">Female</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>



                        <!-- /.form group -->
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Recruitment Method: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtRecruitment_Method" runat="server" placeholder="Enter Recruitment Method" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Job Location: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtJob_Location" runat="server" placeholder="Enter Job Location" />
                            </div>
                        </div>

                        <!-- /.input group -->

                        <!-- /.form group -->
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Registration From Date *: </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtfrom" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtfrom" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                <asp:TextBox class="form-control" ID="txtfrom" runat="server" placeholder="Enter From Date *" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Registration To Date* :  </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtto" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtto" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                <asp:TextBox class="form-control" ID="txtto" runat="server" placeholder="Enter TO Date *" />
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Documents Needed : </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtdoc_Needed" runat="server" placeholder="Enter Documents Needed" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Remark: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtRemark" runat="server" placeholder="Enter Remark" />
                            </div>
                        </div>

                        <!-- /.form group -->
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Company Coordinator: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtCompany_Coordinator" runat="server" placeholder="Enter Company Coordinator" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Designation:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtCompany_Designation" runat="server" placeholder="Enter Designation" />
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Contact Number: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtcompany_contact" runat="server" placeholder="Enter Contact Number" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Institute  Coordinator: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtInstitute_Coordi" runat="server" placeholder="Enter Institute Coordinator" />
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-2 ser-fet">
                                <label>Designation: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtInstitute_Designation" runat="server" placeholder="Enter Designation" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Contact Number: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtInstitute_Contact" runat="server" placeholder="Enter Contact Number" />
                            </div>
                        </div>

                        <!-- /.input group -->
                    </div>

                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
        </div>
        <!-- /.row -->
        <div class="row">
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-12">
                            <div class="col-md-12 ser-fet">
                                <label>Department : </label>
                                <asp:CheckBoxList ID="checkCourses" runat="server" EnableTheming="True" RepeatDirection="Horizontal"></asp:CheckBoxList>
                                <asp:TextBox class="form-control" ID="txtCourses" runat="server" TextMode="MultiLine" Visible="False" />
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class="box-footer">
                        <div class="col-md-6">
                            Befor Completion Drive Registration Please Check All Data.
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="btnsave" runat="server" Text="Save / Update" class="btn btn-primary btn-success" ValidationGroup="Teacher" OnClick="btnsave_Click" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button ID="tbnclear" runat="server" Text="Clear All" class="btn btn-primary" OnClick="tbnclear_Click" />
                        </div>
                    </div>
                </div>
                <!-- /.box -->
            </div>


        </div>
    </section>
    <!-- /.content -->


</asp:Content>

