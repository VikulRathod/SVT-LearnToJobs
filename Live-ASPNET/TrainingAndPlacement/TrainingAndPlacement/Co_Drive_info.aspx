﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Coordinator.Master" CodeBehind="Co_Drive_info.aspx.cs" Inherits="TrainingAndPlacement.Co_Drive_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-header">
        <h1>Drives
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-user"></i>Drives Information</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <!-- /.col -->
            <div class="col-md-12">
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#Company_Profile" data-toggle="tab">Company Profile</a></li>
                        <li><a href="#Criteria" data-toggle="tab">Set Drive Criteria</a></li>
                        <li><a href="#Drive" data-toggle="tab">Drive Details</a></li>
                        <li><a href="#Schedule" data-toggle="tab">Drive Schedule</a></li>
                    </ul>
                    <div class="tab-content">
                        <!-- /.tab-pane -->
                        <div class="active tab-pane" id="Company_Profile">
                            <!-- The timeline -->
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Company Details</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <asp:Panel ID="Panel1" runat="server" Enabled="False">
                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Company Name:</label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtcompany_name" runat="server" placeholder="Eneter Company Name *" />
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Contact Person Name: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtperson" runat="server" placeholder="Eneter Contact Person Name *" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Designation:</label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtDesignation" runat="server" placeholder="Eneter Designation*" />
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Mobile No.: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtContactNo" runat="server" placeholder="Enter Contact No *"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Office Contact No.:</label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtofc_no" runat="server" placeholder="Enter Office Contact No. *"></asp:TextBox>
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Email ID: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtcompany_email" runat="server" placeholder="Enter Email ID *"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Website:</label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtcweb" runat="server" placeholder="Enter Web Site *" required="required"></asp:TextBox>
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Office Address : </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtc_address" runat="server" placeholder="Eneter Registered Office Address *" />
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Company Type:</label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtc_type" runat="server" placeholder="Eneter Company Type*" />
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Type Of Services: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtc_services" runat="server" placeholder="Enter Type Of Services*"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Domain Of Services:</label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtcdomain_services" runat="server" placeholder="Enter Domain Of Services *"></asp:TextBox>
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Description:  </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtDescription" runat="server" placeholder="Eneter Description*" />
                                            </div>
                                        </div>

                                    </asp:Panel>
                                </div>
                            </div>
                            <!-- /.post -->
                        </div>

                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="Drive">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Drive Details</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <asp:Panel ID="Panel2" runat="server" Enabled="False">
                                        <!-- Member Full Name -->
                                        <div class="form-group">
                                            <div class="col-md-2 ser-fet">
                                                <label>Academic Year: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">
                                                <asp:DropDownList ID="ddlAcademic_Year" runat="server" class="form-control">
                                                    <asp:ListItem>Select </asp:ListItem>
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
                                                <label>Company ID: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtcompany_Id" runat="server" />
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-2 ser-fet">
                                                <label>Company Name: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtname" runat="server" placeholder="Enter Company Name" />
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Drive Title: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtDrive_Title" runat="server" placeholder="Enter Drive Title" />
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
                                                <label>Joining Date: </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtJoining_Date" runat="server" placeholder="Enter Joining Date" />
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Gender Allowed: </label>
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
                                                <label>Registration From Date : </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtfrom" runat="server" placeholder="Enter From Date" />
                                            </div>
                                            <div class="col-md-2 ser-fet">
                                                <label>Registration To Date :  </label>
                                            </div>
                                            <div class="col-md-4 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtto" runat="server" placeholder="Enter TO Date" />
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

                                        <!-- /.form group -->
                                        <div class="form-group">
                                            <div class="col-md-12 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtCourses" runat="server" TextMode="MultiLine" />
                                            </div>
                                        </div>

                                    </asp:Panel>
                                </div>
                            </div>
                            <!-- /.post -->

                        </div>

                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="Criteria">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Set_Drive_Criteria</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <asp:Panel ID="Panel3" runat="server" Enabled="False">

                                        <div class="form-group">
                                            <div class="col-md-3 ser-fet">
                                                <label>SSC Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtSSCper" runat="server" Text="0" placeholder=" SSC Percentage "></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>SSC Passing Year *</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtsscPassingYear" runat="server" Text="0" placeholder="Enter   SSC Passing Year " MaxLength="4"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>HSC Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtHSCper" runat="server" Text="0" placeholder="Enter   HSC Percentage "></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>HSC Passing Year *</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txthscPYear" runat="server" Text="0" placeholder="Enter   HSC Passing Year" MaxLength="4"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Diploma Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtDiplomaper" runat="server" Text="0" placeholder="Enter   Diploma Percentage "></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Diploma Passing Year</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtDpyear" runat="server" Text="0" placeholder="Enter   Diploma Passing Year " MaxLength="4"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>UG Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtUGper" runat="server" Text="0" placeholder="Enter   UG Percentage "></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>UG Passing Year*</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtUGPassingY" runat="server" Text="0" placeholder="Enter UG Passing Year " MaxLength="4"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>PG Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtPGper" runat="server" Text="0" placeholder="Enter PG Percentage "></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>PG Passing Year</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtPGpassingY" runat="server" Text="0" placeholder="Enter PG Passing Year " MaxLength="4"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- /.input group -->
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>1st Year Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt1sTYearper" runat="server" Text="0" placeholder="Enter 1st Year Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>1st Year Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt1styearPointer" runat="server" Text="0" placeholder="Enter 1st Year Pointer"></asp:TextBox>
                                            </div>
                                        </div>
                                        <!-- /.form group -->
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>2nd Year Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt2yearper" runat="server" Text="0" placeholder="Enter 2nd Year Percentage"></asp:TextBox>
                                            </div>

                                            <div class="form-group">

                                                <div class="col-md-3 ser-fet">
                                                    <label>2nd Year Pointer</label>
                                                </div>
                                                <div class="col-md-3 ser-fet">

                                                    <asp:TextBox class="form-control" ID="txt2Yearpointer" runat="server" Text="0" placeholder="Enter 2nd Year Pointer"></asp:TextBox>
                                                </div>

                                            </div>
                                        </div>

                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>3rd Year Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt3Yearper" runat="server" Text="0" placeholder="Enter 3rd Year Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>3rd Year Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt3Yearpointer" runat="server" Text="0" placeholder="Enter 3rd Year Pointer"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- /.input group -->

                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>4th Year Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt4Yearper" runat="server" Text="0" placeholder="Enter   4th Year Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>4th Year Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txt4thYPointer" runat="server" Text="0" placeholder="Enter   4th Year Pointer "></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>5th Year Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt5thYper" runat="server" Text="0" placeholder="Enter 5th Year Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>5th Year Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txt5thYpointer" runat="server" Text="0" placeholder="Enter 5th Year pointer"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 1 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS1per" runat="server" Text="0" placeholder="EnterSemester 1 Percentage "></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 1 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtS1pointer" runat="server" Text="0" placeholder="EnterSemester 1 Pointer "></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 2 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS2per" runat="server" Text="0" placeholder="Enter Semester 2 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 2 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS2Pointer" runat="server" Text="0" placeholder="Enter Semester 2 Pointer"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 3 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS3per" runat="server" Text="0" placeholder="Enter Semester 3 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 3 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS3pointer" runat="server" Text="0" placeholder="Enter Semester 3 Pointer"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 4 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS4per" runat="server" Text="0" placeholder="Enter Semester 4 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 4 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtS4pointer" runat="server" Text="0" placeholder="Enter Semester 4 Pointer "></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 5 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS5per" runat="server" Text="0" placeholder="Enter Semester 5 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 5 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS5pointer" runat="server" Text="0" placeholder="Enter Semester 5 Pointer"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 6 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS6per" runat="server" Text="0" placeholder="EnterSemester 6 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 6 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtS6pointer" runat="server" Text="0" placeholder="EnterSemester 6 Pointer"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 7 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS7per" runat="server" Text="0" placeholder="Enter Semester 7 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 7 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtS7pointer" runat="server" Text="0" placeholder="Enter Semester 7 Pointer "></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 8 Percentage</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">

                                                <asp:TextBox class="form-control" ID="txtS8per" runat="server" Text="0" placeholder="Enter Semester 8 Percentage"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Semester 8 Pointer</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtS8ponter" runat="server" Text="0" placeholder="Enter Semester 8 Pointer"></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Gap ( In Years )</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:DropDownList ID="ddlgap" runat="server" class="form-control">
                                                    <asp:ListItem Value="0">0</asp:ListItem>
                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                    <asp:ListItem Value="10">>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Live ATKT</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:DropDownList ID="ddlLive_ATKT" runat="server" class="form-control">
                                                    <asp:ListItem Value="0">0</asp:ListItem>
                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                    <asp:ListItem Value="10">>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Dead ATKT</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:DropDownList ID="ddlDead_ATKT" runat="server" class="form-control">
                                                    <asp:ListItem Value="0">0</asp:ListItem>
                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                    <asp:ListItem Value="10">>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Experience(In Months)</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:DropDownList ID="ddlExperience" runat="server" class="form-control">
                                                    <asp:ListItem Value="0">0</asp:ListItem>
                                                    <asp:ListItem Value="1">1</asp:ListItem>
                                                    <asp:ListItem Value="2">2</asp:ListItem>
                                                    <asp:ListItem Value="3">3</asp:ListItem>
                                                    <asp:ListItem Value="4">4</asp:ListItem>
                                                    <asp:ListItem Value="5">5</asp:ListItem>
                                                    <asp:ListItem Value="6">6</asp:ListItem>
                                                    <asp:ListItem Value="7">7</asp:ListItem>
                                                    <asp:ListItem Value="8">8</asp:ListItem>
                                                    <asp:ListItem Value="9">9</asp:ListItem>
                                                    <asp:ListItem Value="10">>10</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                        <div class="form-group">

                                            <div class="col-md-3 ser-fet">
                                                <label>Entrance Score</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtEntranceScore" runat="server" Text="0" placeholder="Enter  Entrance Score"></asp:TextBox>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <label>Aggregate %</label>
                                            </div>
                                            <div class="col-md-3 ser-fet">
                                                <asp:TextBox class="form-control" ID="txtAggregate" runat="server" Text="0" placeholder="Enter Aggregate %"></asp:TextBox>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                </div>
                            </div>
                        </div>

                        <div class="tab-pane" id="Schedule">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Drive Schedule Details</h3>
                                </div>
                                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                                    <asp:GridView ID="gvShowschedule" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                                        <Columns>
                                            <asp:BoundField HeaderText="Academic_Year" DataField="Academic_Year" SortExpression="Academic_Year" />
                                            <asp:BoundField HeaderText="Company_ID" DataField="Company_ID" SortExpression="Company_ID" />
                                            <asp:BoundField HeaderText="Drive_Id" DataField="Drive_Id" SortExpression="Drive_Id" />
                                            <asp:BoundField HeaderText="Round_Number" DataField="Round_Number" SortExpression="Round_Number" />
                                            <asp:BoundField HeaderText="Round_Title" DataField="Round_Title" SortExpression="Round_Title" />
                                            <asp:BoundField HeaderText="Round_Date" DataField="Round_Date" SortExpression="Round_Date" />
                                            <asp:BoundField HeaderText="Round_Timing" DataField="Round_Timing" SortExpression="Round_Timing" />
                                            <asp:BoundField HeaderText="Venue" DataField="Venue" SortExpression="Venue" />
                                            <asp:BoundField HeaderText="Description" DataField="Description" SortExpression="Description" />


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
                            <!-- /.post -->
                        </div>
                    </div>
                    <!-- /.tab-pane -->
                </div>
                <!-- /.tab-content -->

            </div>
            <!-- /.col -->
        </div>
    </section>
</asp:Content>