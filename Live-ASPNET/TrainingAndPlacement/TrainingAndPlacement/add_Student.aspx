<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Coordinator.Master" CodeBehind="add_Student.aspx.cs" Inherits="TrainingAndPlacement.add_Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add / Update Student
        <small>Details</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Add / Update Student</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">

                <div class="box box-danger">
                    <div class="box-header with-border">
                        <div class="col-md-4 ser-fet">
                            <h3 class="box-title">Personal Information</h3>
                        </div>
                        <div class="col-md-8 ser-fet">
                            <div class="col-md-5" align="right">
                                <label>Search for Update Student:</label>
                            </div>
                            <div class="col-md-4">
                                <asp:TextBox class="form-control" ID="txtStudID" runat="server" placeholder="Enter Student ID" />
                            </div>
                            <asp:Panel ID="sh1" runat="server">
                                <div class="col-md-3">
                                    <div class="input-group">
                                        <asp:LinkButton ID="btnsearch" class="btn btn-primary" runat="server" ValidationGroup="id" OnClick="btnsearch_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                                    </div>
                                </div>
                            </asp:Panel>
                        </div>
                    </div>
                    <div class="box-body">
                        <!-- Member Full Name -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Academic Year *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
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
                            <div class="col-md-2 ser-fet">
                                <label>Course Name*:</label>
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

                                <asp:TextBox class="form-control" ID="txtcardno" runat="server" placeholder="Enter Aadhaar Card No. " />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>University Reg No:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtuni_regiNo" runat="server" placeholder=" University Reg No " />
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Class ID:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtClass_ID" runat="server" placeholder="Class ID " />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Roll No.:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtRoll_No" runat="server" placeholder="Roll No." />
                            </div>
                        </div>
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Student Name*: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtStudent_Name" runat="server" placeholder="Student Name*" />

                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Email *:</label>
                            </div>
                            <div class="col-md-4 ser-fet" data-toggle="tooltip" title="Email ID It would be Username!!!">
                                <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Email ID*" />

                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Contact No.: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtcontact" runat="server" placeholder="Contact no." />

                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Alt Contact No.:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtalt_No" runat="server" placeholder="Alt Contact No" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Mother Name: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtMother_Name" runat="server" placeholder="Mother Name" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Gender *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlGender" runat="server" class="form-control">
                                    <asp:ListItem>---Select---</asp:ListItem>
                                    <asp:ListItem Value="Male">Male</asp:ListItem>
                                    <asp:ListItem Value="Female">Female</asp:ListItem>

                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Date of Birth: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtdob" runat="server" placeholder="Select DOB"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Blood Group:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:DropDownList ID="ddlBlood" runat="server" class="form-control">
                                    <asp:ListItem>---Select---</asp:ListItem>
                                    <asp:ListItem Value="A+">A+</asp:ListItem>
                                    <asp:ListItem Value="B+">B+</asp:ListItem>
                                    <asp:ListItem Value="AB+">AB+</asp:ListItem>
                                    <asp:ListItem Value="O+">O+</asp:ListItem>
                                    <asp:ListItem Value="A-">A-</asp:ListItem>
                                    <asp:ListItem Value="B-">B-</asp:ListItem>
                                    <asp:ListItem Value="AB-">AB-</asp:ListItem>
                                    <asp:ListItem Value="O-">O-</asp:ListItem>
                                    <asp:ListItem Value="Dont Know">Dont Know</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <br />
                        </div>
                        <!-- /.input group -->

                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Mother Tongue:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtMother_Tongue" runat="server" placeholder="Mother Tongue" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Languages: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtLanguages" runat="server" placeholder="Enter Languages" />

                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Admission Date:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <ajaxToolkit:CalendarExtender ID="txtC_dob_CalendarExtender" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtAdmission_Date" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator83" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtAdmission_Date" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                <asp:TextBox class="form-control" ID="txtAdmission_Date" runat="server" placeholder="Enter Admission Date" />

                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Address:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtAddress" runat="server" placeholder="Enter Address" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Nationality:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtNationality" runat="server" placeholder="Enter Nationality "></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Domicile: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDomicile" runat="server" placeholder="Enetr Domicile" />

                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Religion:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtReligion" runat="server" placeholder="Enter Religion"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Category: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtCategory" runat="server" placeholder="Enter Category"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Caste:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtCaste" runat="server" placeholder="Enter Caste"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Hostelite: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:DropDownList ID="ddlHostelite" runat="server" class="form-control">
                                    <asp:ListItem>---Select---</asp:ListItem>
                                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                                    <asp:ListItem Value="NO">NO</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <br />
                        </div>


                        <!-- /.form group -->

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Handicap:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlHandicap" runat="server" class="form-control">
                                    <asp:ListItem>---Select---</asp:ListItem>
                                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                                    <asp:ListItem Value="NO">NO</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <br />

                            <div class="col-md-2 ser-fet">
                                <label>Sport:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlSport" runat="server" class="form-control">
                                    <asp:ListItem>---Select---</asp:ListItem>
                                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                                    <asp:ListItem Value="NO">NO</asp:ListItem>
                                </asp:DropDownList>

                            </div>
                        </div>


                        <!-- /.form group -->

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Defence:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:DropDownList ID="ddlDefence" runat="server" class="form-control">
                                    <asp:ListItem>---Select---</asp:ListItem>
                                    <asp:ListItem Value="Yes">Yes</asp:ListItem>
                                    <asp:ListItem Value="NO">NO</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>PAN No.: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtPan" runat="server" placeholder="Enter PAN No. "></asp:TextBox>
                            </div>
                        </div>


                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Passport No.:  </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtPassport_No" runat="server" placeholder="Enter Passport No."></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Driving License: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDriving_License" runat="server" placeholder="Enter Driving License"></asp:TextBox>
                            </div>
                        </div>

                        <!-- /.input group -->
                    </div>
                </div>

                <div class="box box-info">
                    <div class="box-header">
                        <h3 class="box-title">Parent  Information</h3>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Parent Name: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox ID="txtFather" runat="server" class="form-control" placeholder="Enter Parent Name" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Contact No.:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtfcontact" runat="server" placeholder="Contact no. *" MaxLength="10" />
                            </div>
                        </div>
                        <!-- /.form group -->

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Parent Email ID: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtfather_Email" runat="server" placeholder="Enter Email " />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Occupation:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtOccupation" runat="server" placeholder="Enter Occupation "></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Organization: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtOrganization" runat="server" placeholder="Enter Organization"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Designation: </label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtDesignation" runat="server" placeholder="Enter Designation" />
                            </div>
                        </div>

                        <!-- /.input group -->

                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Address:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtfAddress" runat="server" placeholder="Enter Address"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Annual Income:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtIncome" runat="server" placeholder="Enter Annual Income"></asp:TextBox>
                            </div>
                        </div>

                        <!-- /.input group -->
                    </div>
                </div>

                <div class="box box-info">
                    <div class="box-header">
                        <h3 class="box-title">Academics  Information</h3>
                    </div>
                    <div class="box-body">
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
                                                <asp:TextBox class="form-control" ID="txt10percent" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt10percent" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td style="width: 8em;">
                                                <asp:TextBox class="form-control" ID="txt10year" runat="server" MaxLength="4" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt10year" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td style="width: 15px;">
                                                <asp:TextBox class="form-control" ID="txt10Attempt" runat="server" MaxLength="2" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt10Attempt" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">HSC</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt12board" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt12sub" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt12percent" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt12percent" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt12year" runat="server" MaxLength="4" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt12year" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt12Attempt" runat="server" MaxLength="2" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt12Attempt" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Diploma</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdipboard" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdisub" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdipercent" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtdipercent" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdiyear" runat="server" MaxLength="4" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtdiyear" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdiAttempt" runat="server" MaxLength="2" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtdiAttempt" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr class="success">
                                            <th scope="row">UG</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdeboard" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdesub" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdepercent" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtdepercent" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdeyear" runat="server" MaxLength="4" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtdeyear" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtdeAttempt" runat="server" MaxLength="2" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtdeAttempt" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">PG </th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtpgeboard" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtpgesub" runat="server" /></td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtpgepercent" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtpgepercent" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtpgeyear" runat="server" MaxLength="4" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator14" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtpgeyear" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtpgAttempt" runat="server" MaxLength="2" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtpgAttempt" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
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
                                                <asp:TextBox class="form-control" ID="sem1_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem1_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem1_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem1_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem1_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator18" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem1_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem1_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator19" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem1_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem1_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator20" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem1_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Sem 2</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem2_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator21" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem2_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem2_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator22" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem2_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem2_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator23" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem2_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem2_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator24" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem2_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem2_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator25" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem2_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Sem 3</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem3_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator26" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem3_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem3_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator27" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem3_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem3_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator28" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem3_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem3_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator29" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem3_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem3_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator30" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem3_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr class="success">
                                            <th scope="row">Sem 4</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem4_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator31" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem4_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem4_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator32" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem4_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem4_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator33" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem4_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem4_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator34" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem4_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem4_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator35" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem4_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr class="active">
                                            <th scope="row">Sem 5</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem5_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator36" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem5_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem5_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator37" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem5_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem5_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator38" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem5_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem5_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator39" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem5_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem5_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator40" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem5_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Sem 6</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem6_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator41" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem6_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem6_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator42" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem6_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem6_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator43" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem6_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem6_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator44" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem6_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem6_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator45" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem6_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Sem 7</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem7_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator46" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem7_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem7_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator47" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem7_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem7_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator48" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem7_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem7_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator49" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem7_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem7_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator50" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem7_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr class="success">
                                            <th scope="row">Sem 8</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem8_Obtained_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator51" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem8_Obtained_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem8_Total_Marks" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator52" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem8_Total_Marks" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem8_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator53" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem8_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem8_SGPA" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator54" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem8_SGPA" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="sem8_Backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator55" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="sem8_Backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
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
                                                <asp:TextBox class="form-control" ID="txt1Year_mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator56" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt1Year_mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt1Year_Total_Mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator57" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt1Year_Total_Mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt1Year_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator58" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt1Year_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt1Year_sgpa" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator59" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt1Year_sgpa" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td style="width: 20px;">
                                                <asp:TextBox class="form-control" ID="txt1Year_backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator60" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt1Year_backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Year 2</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt2Year_mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator61" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt2Year_mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt2Year_Total_Mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator62" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt2Year_Total_Mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt2Year_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator63" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt2Year_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt2Year_sgpa" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator64" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt2Year_sgpa" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt2Year_backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator65" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt2Year_backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <th scope="row">Year 3</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt3Year_mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator66" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt3Year_mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt3Year_Total_Mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator67" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt3Year_Total_Mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt3Year_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator68" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt3Year_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt3Year_sgpa" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator69" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt3Year_sgpa" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt3Year_backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator70" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt3Year_backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr class="success">
                                            <th scope="row">Year 4</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt4Year_mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator71" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt4Year_mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt4Year_Total_Mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator72" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt4Year_Total_Mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt4Year_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator73" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt4Year_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt4Year_sgpa" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator74" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt4Year_sgpa" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt4Year_backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator75" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt4Year_backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                        <tr class="active">
                                            <th scope="row">Year 5</th>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt5Year_mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator76" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt5Year_mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt5Year_Total_Mark" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator77" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt5Year_Total_Mark" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt5Year_Percentage" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator78" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt5Year_Percentage" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt5Year_sgpa" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator79" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt5Year_sgpa" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txt5Year_backlogs" runat="server" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator80" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txt5Year_backlogs" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="bs-example animated wow fadeInLeft" data-wow-duration="1000ms" data-example-id="contextual-table" style="border: 1px solid #eee; font-family: Source Sans Pro; overflow-x: scroll;">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>Gap (Year)</th>
                                            <th>Live Backlogs</th>
                                            <th>Dead Backlogs</th>
                                            <th>Experience (Months)</th>
                                            <th>Entrance Score</th>
                                            <th>Aggregate %</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class="active">
                                            <td>
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
                                            </td>
                                            <td>
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

                                            </td>
                                            <td>
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

                                            </td>
                                            <td>
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

                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtEntrance_Score" runat="server" placeholder="Entrance Score" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator81" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtEntrance_Score" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                            <td>
                                                <asp:TextBox class="form-control" ID="txtAggregate" runat="server" placeholder="Enter Aggregate %" MaxLength="3" />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator82" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtAggregate" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>

                        <asp:Panel ID="profile" runat="server">
                            <!-- /.form group -->
                            <div class="form-group">

                                <div class="col-md-4 ser-fet">
                                    <div class="form-group" align="center">
                                        <div class="col-md-12">
                                            <h4>Upload Profile Photo</h4>
                                            <div class="input-group">
                                                <asp:Image ID="img" class="user-image" alt=" " runat="server" Style="width: 100%;" ImageUrl="~/img/add.png" />
                                            </div>
                                        </div>
                                        <div class="col-md-6" data-toggle="tooltip" title="( Format : JPG, PNG | File size : Max 5MB )!!!">
                                            <asp:FileUpload ID="FileUpload1" runat="server" Style="width: 100%;" />
                                        </div>
                                        <div class="col-md-6">
                                            <asp:Button ID="btnImgUpload" runat="server" OnClick="btnImgUpload_Click" Text="Upload" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-8 ser-fet">
                                    <div class="form-group">
                                        <h4>UPLOAD Resume</h4>
                                        <label>Note that if you upload Resume then your previous Resume will be replaced by new Resume automatically.</label>
                                        <asp:FileUpload ID="ResumeUpload" runat="server" Style="width: 100%;" />
                                        <br />
                                        <asp:HyperLink ID="linkResume" runat="server" Text="Download Resume" />


                                        <%--<div class="col-md-6 ser-fet">
                                        <div class="input-group">
                                            <div class="input-group-btn">
                                                <button type="button" class="btn btn-danger">Document: </button>
                                            </div>
                                            <asp:DropDownList ID="ddlDocument" runat="server" class="form-control">
                                                <asp:ListItem value="Select Document Type">Select Document Type</asp:ListItem>
				                                <asp:ListItem value="SSC_Marksheet">SSC_Marksheet</asp:ListItem>
				                                <asp:ListItem value="HSC_Marksheet">HSC_Marksheet</asp:ListItem>
				                                <asp:ListItem value="Diploma_Marksheet">Diploma_Marksheet</asp:ListItem>
				                                <asp:ListItem value="UG_Marksheet">UG_Marksheet</asp:ListItem>
				                                <asp:ListItem value="PG_Marksheet">PG_Marksheet</asp:ListItem>
				                                <asp:ListItem value="1st_Year_Marksheet">1st_Year_Marksheet</asp:ListItem>
				                                <asp:ListItem value="2nd_Year_Marksheet">2nd_Year_Marksheet</asp:ListItem>
				                                <asp:ListItem value="3rd_Year_Marksheet">3rd_Year_Marksheet</asp:ListItem>
				                                <asp:ListItem value="4th_Year_Marksheet">4th_Year_Marksheet</asp:ListItem>
				                                <asp:ListItem value="5th_Year_Marksheet">5th_Year_Marksheet</asp:ListItem>
				                                <asp:ListItem value="1st-Semester_Marksheet">1st-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="2nd-Semester_Marksheet">2nd-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="3rd-Semester_Marksheet">3rd-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="4th-Semester_Marksheet">4th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="5th-Semester_Marksheet">5th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="6th-Semester_Marksheet">6th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="7th-Semester_Marksheet">7th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="8th-Semester_Marksheet">8th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="9th-Semester_Marksheet">9th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="10th-Semester_Marksheet">10th-Semester_Marksheet</asp:ListItem>
				                                <asp:ListItem value="Adhar_Card">Adhar_Card</asp:ListItem>
				                                <asp:ListItem value="PAN_Card">PAN_Card</asp:ListItem>
				                                <asp:ListItem value="Passport">Passport</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <br />
                                    </div>
                                    <div class="col-md-6 ser-fet">
                                        <asp:FileUpload ID="FileUpload2" class="btn btn-danger" runat="server" Style="width: 100%;" />
                                    </div>--%>
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="Student_ResumeURL" runat="server" Visible="False" />
                            </div>
                            <!-- /.form group -->
                        </asp:Panel>
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
                            <div class="col-md-6 ser-fet">
                                <div class="col-md-4">
                                    <asp:RadioButton ID="Radiosms" GroupName="send" runat="server" Text="  Send SMS " />
                                </div>
                                <div class="col-md-4">
                                    <asp:RadioButton ID="Radioemail" GroupName="send" runat="server" Text="  Send Email " />
                                </div>
                                <div class="col-md-4">
                                    <asp:RadioButton ID="Radioboth" GroupName="send" runat="server" Text="  Send SMS + Email " />
                                </div>
                            </div>
                            <div class="col-md-6 ser-fet">
                                <div class="col-md-6">
                                    <asp:Button ID="btnsave" runat="server" Text="Save / Update" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                                </div>
                                <div class="col-md-6">
                                    <asp:Button ID="tbnclear" runat="server" Text="Clear All" class="btn btn-primary" OnClick="tbnclear_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class="box-footer">
                        Befor Completion Student Registration Please Check All Data.
                    </div>
                </div>
                <!-- /.box -->
            </div>


        </div>
    </section>
    <!-- /.content -->


</asp:Content>
