<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="TPO_Student_Profile.aspx.cs" Inherits="TrainingAndPlacement.TPO_Student_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Student
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Student_Profile.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Student Profile</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header with-border">
                        <div class="col-md-6 ser-fet">
                            <h3 class="box-title">Personal Information</h3>
                        </div>
                        <div class="col-md-6 ser-fet">
                            <div class="col-md-4">
                                <label>Student ID :</label>
                            </div>
                            <div class="col-md-5">
                                <asp:TextBox class="form-control" ID="txtStudID" runat="server" placeholder="Enter Search Id *" />
                            </div>
                            <div class="col-md-3">
                                <div class="input-group">
                                    <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="id" OnClick="Search_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="nav-tabs-custom">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#Basic" data-toggle="tab">Student Information</a></li>
                        <li><a href="#Project" data-toggle="tab">Student Project Details</a></li>
                        <li><a href="#Technical" data-toggle="tab">Student Technical Details</a></li>
                        <li><a href="#Activity" data-toggle="tab">Student Activity</a></li>
                        <li><a href="#Achievement" data-toggle="tab">Student Achievement</a></li>
                    </ul>
                    <div class="tab-content">
                        <!-- /.tab-pane -->
                        <div class="active tab-pane" id="Basic">
                            <!-- The timeline -->
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Student Information</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body">
                                    <!-- Member Full Name -->

                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Academic Year:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtacademic" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Course Name:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">
                                            <asp:DropDownList ID="ddlCourse_Name" runat="server" class="form-control">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Aadhaar No:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtcardno" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>University Reg No:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtuni_regiNo" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Class ID: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtClass_ID" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Roll No. :</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtRoll_No" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Student Name*:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtStudent_Name" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Email *:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtEmail" runat="server" class="form-control"></asp:Label>
                                        </div>

                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Contact No. *:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtcontact" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Alt Contact No.:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtalt_No" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Mother Name:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtMother_Name" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Gender:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtGender" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Date of Birth: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtDateofBirth" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Blood Group:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtBlood" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Mother Tongue:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtMother_Tongue" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Languages:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtLanguages" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Admission Date: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtAdmissionDate" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Address:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtAddress" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Nationality:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtNationality" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Domicile: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtDomicile" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Religion:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtReligion" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Category:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtCategory" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Caste:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtCaste" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Hostelite:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtHostelite" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Handicap:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtHandicap" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Sport:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtSport" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Defence: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtDefence" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>PAN No.: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtPan" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Passport No.: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtPassport_No" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Driving License:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtDriving_License" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Parent Name:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtFather" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Contact No.:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtfcontact" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Parent Email ID:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtfather_Email" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Occupation:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtOccupation" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Organization: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtOrganization" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Designation:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtDesignation" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Address: </label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtfAddress" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Annual Income:</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtIncome" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <br />
                                    <h3 class="box-title">Academics  Information</h3>
                                    <br />
                                    <!-- Color Picker -->
                                    <div class="form-group">
                                        <div class="bs-example animated wow fadeInLeft" data-wow-duration="1000ms" data-example-id="contextual-table" style="border: 1px solid #eee; font-family: Source Sans Pro; overflow-x: scroll;">
                                            <table class="table">
                                                <thead>
                                                    <tr>
                                                        <th>STD</th>
                                                        <th>Board/University</th>
                                                        <th>Institute</th>
                                                        <th>Percentage %</th>
                                                        <th>Passed Year</th>
                                                        <th>Attempt</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr class="active">
                                                        <th scope="row">SSC</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt10board" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt10sub" runat="server" /></td>
                                                        <td style="width: 20px;">
                                                            <asp:TextBox class="form-control" ID="txt10percent" runat="server" /></td>
                                                        <td style="width: 8em;">
                                                            <asp:TextBox class="form-control" ID="txt10year" runat="server" /></td>
                                                        <td style="width: 15px;">
                                                            <asp:TextBox class="form-control" ID="txt10Attempt" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">HSC</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt12board" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt12sub" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt12percent" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt12year" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt12Attempt" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Diploma</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdipboard" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdisub" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdipercent" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdiyear" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdiAttempt" runat="server" /></td>
                                                    </tr>
                                                    <tr class="success">
                                                        <th scope="row">UG</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdeboard" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdesub" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdepercent" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdeyear" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtdeAttempt" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">PG </th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtpgeboard" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtpgesub" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtpgepercent" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtpgeyear" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txtpgAttempt" runat="server" /></td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                    <!-- /.form group -->
                                    <div class="form-group">
                                        <h4>Semester wise Marks</h4>
                                        <div class="bs-example animated wow fadeInLeft" data-wow-duration="1000ms" data-example-id="contextual-table" style="border: 1px solid #eee; font-family: Source Sans Pro; overflow-x: scroll;">
                                            <table class="table">
                                                <thead>
                                                    <tr>
                                                        <th>Sem</th>
                                                        <th>Obtained Marks</th>
                                                        <th>Total Marks</th>
                                                        <th>Percentage %</th>
                                                        <th>SGPA</th>
                                                        <th>No. of Backlogs</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr class="active">
                                                        <th scope="row">Sem 1</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem1_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem1_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem1_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem1_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem1_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Sem 2</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem2_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem2_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem2_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem2_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem2_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Sem 3</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem3_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem3_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem3_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem3_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem3_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr class="success">
                                                        <th scope="row">Sem 4</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem4_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem4_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem4_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem4_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem4_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr class="active">
                                                        <th scope="row">Sem 5</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem5_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem5_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem5_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem5_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem5_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Sem 6</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem6_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem6_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem6_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem6_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem6_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Sem 7</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem7_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem7_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem7_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem7_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem7_Backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr class="success">
                                                        <th scope="row">Sem 8</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem8_Obtained_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem8_Total_Marks" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem8_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem8_SGPA" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="sem8_Backlogs" runat="server" /></td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                    <!-- /.form group -->
                                    <div class="form-group">
                                        <h4>Year wise Marks</h4>
                                        <div class="bs-example animated wow fadeInLeft" data-wow-duration="1000ms" data-example-id="contextual-table" style="border: 1px solid #eee; font-family: Source Sans Pro; overflow-x: scroll;">
                                            <table class="table">
                                                <thead>
                                                    <tr>
                                                        <th>Year</th>
                                                        <th>Obtained Marks</th>
                                                        <th>Total Marks</th>
                                                        <th>Percentage %</th>
                                                        <th>SGPA</th>
                                                        <th>No. of Backlogs</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr class="active">
                                                        <th scope="row">Year 1</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt1Year_mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt1Year_Total_Mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt1Year_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt1Year_sgpa" runat="server" /></td>
                                                        <td style="width: 20px;">
                                                            <asp:TextBox class="form-control" ID="txt1Year_backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Year 2</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt2Year_mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt2Year_Total_Mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt2Year_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt2Year_sgpa" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt2Year_backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr>
                                                        <th scope="row">Year 3</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt3Year_mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt3Year_Total_Mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt3Year_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt3Year_sgpa" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt3Year_backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr class="success">
                                                        <th scope="row">Year 4</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt4Year_mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt4Year_Total_Mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt4Year_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt4Year_sgpa" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt4Year_backlogs" runat="server" /></td>
                                                    </tr>
                                                    <tr class="active">
                                                        <th scope="row">Year 5</th>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt5Year_mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt5Year_Total_Mark" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt5Year_Percentage" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt5Year_sgpa" runat="server" /></td>
                                                        <td>
                                                            <asp:TextBox class="form-control" ID="txt5Year_backlogs" runat="server" /></td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                    <!-- /.form group -->
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Gap (Year)</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtGap_Year" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Live Backlogs</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtLive_Backlogs" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Dead Backlogs</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtDead_Backlogs" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Experience(Months)</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtExperience" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-md-2 ser-fet">
                                            <label>Entrance Score</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtEntrance_Score" runat="server" class="form-control"></asp:Label>
                                        </div>
                                        <div class="col-md-2 ser-fet">
                                            <label>Aggregate %</label>
                                        </div>
                                        <div class="col-md-4 ser-fet">

                                            <asp:Label ID="txtAggregate" runat="server" class="form-control"></asp:Label>
                                        </div>
                                    </div>


                                    <!-- /.box-body -->

                                </div>
                                <!-- /.post -->
                            </div>
                        </div>
                        <!-- /.tab-pane -->
                        <div class="tab-pane" id="Project">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Student Project Details</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                                    <asp:Label ID="error2" runat="server" Font-Bold="True" ForeColor="Red" /><br />
                                    <asp:GridView ID="gvProject_Details" CssClass="table table-striped table-bordered table-hover" runat="server"
                                        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" DataKeyNames="Student_ID"
                                        BorderWidth="1px" CellPadding="3" PageIndex="10">
                                        <Columns>
                                            <asp:BoundField HeaderText="Student ID" DataField="Student_ID" />
                                            <asp:BoundField HeaderText="Project Type" DataField="Project_Type" />
                                            <asp:BoundField HeaderText="Project Title" DataField="Project_Title" />
                                            <asp:BoundField HeaderText="Project Domain" DataField="Project_Domain" />
                                            <asp:BoundField HeaderText="Project Duration" DataField="Project_Duration" />
                                            <asp:BoundField HeaderText="Technologies" DataField="Technologies" />
                                            <asp:BoundField HeaderText="Team Size" DataField="Team_Size" />
                                            <asp:BoundField HeaderText="Guide Name" DataField="Guide_Name" />
                                            <asp:BoundField HeaderText="Description" DataField="Description" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane" id="Technical">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Student Technical Details</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                                    <asp:Label ID="error3" runat="server" Font-Bold="True" ForeColor="Red" /><br />
                                    <asp:GridView ID="gvTechnicalDetails" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                                        <Columns>
                                            <asp:BoundField HeaderText="stuID" DataField="stuID" InsertVisible="False" ReadOnly="True" SortExpression="stuID" />
                                            <asp:BoundField HeaderText="Course_Title" DataField="Course_Title" SortExpression="Course_Title" />
                                            <asp:BoundField HeaderText="Technical_Details" DataField="Technical_Details" SortExpression="Technical_Details" />
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
                        <div class="tab-pane" id="Activity">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Student Activity</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                                    <asp:Label ID="error4" runat="server" Font-Bold="True" ForeColor="Red" /><br />
                                    <div class="form-group">
                                        <asp:GridView ID="gvstudent_extraActivity" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                                            <Columns>
                                                <asp:BoundField HeaderText="Student Id" DataField="Student_id" />
                                                <asp:BoundField HeaderText="Activity Title" DataField="Activity_Title" />
                                                <asp:BoundField HeaderText="Activity Details" DataField="Activity_Details" />
                                                <asp:BoundField HeaderText="Description" DataField="Description" />

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
                            <!-- /.post -->
                        </div>
                        <div class="tab-pane" id="Achievement">
                            <!-- Post -->
                            <div class="box box-primary">
                                <div class="box-header with-border">
                                    <h3 class="box-title">Student Achievement</h3>
                                </div>
                                <!-- /.box-header -->
                                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                                    <asp:Label ID="error5" runat="server" Font-Bold="True" ForeColor="Red" /><br />
                                    <asp:GridView ID="gvAchievementDetails" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                                        <Columns>
                                            <asp:BoundField HeaderText="studentID" DataField="studentID" InsertVisible="False" ReadOnly="True" SortExpression="studentID" />
                                            <asp:BoundField HeaderText="Achievement_Title" DataField="Achievement_Title" SortExpression="Achievement_Title" />
                                            <asp:BoundField HeaderText="Achievement_Details" DataField="Achievement_Details" SortExpression="Achievement_Details" />
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





                        <!-- /.box -->
                    </div>
                    <!-- /.tab-pane -->
                </div>
            </div>
        </div>
        <!-- /.row -->
    </section>
    <!-- /.content -->


</asp:Content>
