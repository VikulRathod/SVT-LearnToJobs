<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Coordinator.Master" CodeBehind="Coordinator_Profile.aspx.cs" Inherits="TrainingAndPlacement.Coordinator_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Coordinator Profile
        <small>Information</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-home"></i> Home</a></li>
        <li>Coordinator Profile</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header">
                        <h3 class="box-title">Basic Information</h3>
                        <div class="box-tools pull-right">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Select Department: </button>
                                </div>
                                <asp:DropDownList ID="ddlDepartment" runat="server" class="form-control">
                                
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="box-body">
                        <!-- Member Full Name -->
                        <div class="form-group">
                            <div class="col-md-4 ser-fet">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="Validators" Display="Dynamic" ValidationGroup="Teacher" ControlToValidate="Fname" runat="server" ErrorMessage="Please Enter First Name." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" Display="Dynamic" ValidationExpression="^[a-zA-Z]+$" ControlToValidate="Fname" ForeColor="Red" ErrorMessage="accept only alphabeti" />
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        First Name
                                    </div>
                                    <asp:TextBox class="form-control" ID="Fname" runat="server" placeholder="Frist Name *" />
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" Display="Dynamic" ValidationExpression="^[a-zA-Z]+$" ControlToValidate="Mname" ForeColor="Red" ErrorMessage="accept only alphabeti" />
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Middle Name
                                    </div>
                                    <asp:TextBox class="form-control" ID="Mname" runat="server" placeholder="Middle Name " />
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="Validators" Display="Dynamic" ValidationGroup="Teacher" ControlToValidate="Lname" runat="server" ErrorMessage="Please Enter Last Name." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" Display="Dynamic" ValidationExpression="^[a-zA-Z]+$" ControlToValidate="Lname" ForeColor="Red" ErrorMessage="accept only alphabeti" />
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Last Name
                                    </div>
                                    <asp:TextBox class="form-control" ID="Lname" runat="server" placeholder="Last Name *" />
                                </div>
                                <br />
                            </div>

                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->

                        <!-- Member Id car type -->
                        <div class="form-group">
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtcardnoC" runat="server" placeholder="Enter Card No. " />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <i class="fa fa-calendar"></i>
                                    </div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="Validators" Display="Dynamic" ValidationGroup="Teacher" ControlToValidate="txtC_dob" runat="server" ErrorMessage="Please Enter Date of Birth." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:CalendarExtender ID="txtC_dob_CalendarExtender" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtC_dob" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtC_dob" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                    <asp:TextBox ID="txtC_dob" runat="server" class="form-control" format="dd/mm/yyyy" placeholder="Select Date Of Birth *" />
                                </div><br />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Gender
                                    </div>
                                    <asp:Label ID="txtgender" class="form-control" runat="server" ></asp:Label>
                                </div><br />
                            </div>

                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        CIty
                                    </div>
                                    <asp:TextBox class="form-control" ID="txtC_City" runat="server" placeholder="Enter City "></asp:TextBox>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        State
                                    </div>
                                    <asp:TextBox class="form-control" ID="txtC_state" runat="server" placeholder="Enter State"></asp:TextBox>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        Pincode
                                    </div>
                                    <asp:TextBox class="form-control" ID="txtC_Pincode" runat="server" placeholder="Enter Pincode" MaxLength="6"></asp:TextBox>
                                </div>
                                <br />
                            </div>
                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->

                        <!-- IP mask -->
                        <div class="form-group">
                            <div class="col-md-12 ser-fet">
                                <asp:TextBox class="form-control" ID="txtC_address" runat="server" placeholder="Enter Address " TextMode="MultiLine" Rows="1" Style="margin-bottom: 14px;"></asp:TextBox>
                            </div>
                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->
                        <!-- phone mask -->
                        <div class="form-group">
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <i class="fa fa-phone"></i>
                                    </div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="Validators" Display="Dynamic" ValidationGroup="Teacher" ControlToValidate="txtC_contact" runat="server" ErrorMessage="Please Enter Contact Number." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$" ControlToValidate="txtC_contact" ForeColor="Red" ErrorMessage="Invalid Mobile Number." />
                                    <asp:TextBox class="form-control" ID="txtC_contact" runat="server" placeholder="Contact no. *" MaxLength="10" />

                                </div>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <i class="fa fa-phone"></i>
                                    </div>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Display="Dynamic" ValidationExpression="^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$" ControlToValidate="txtC_alt" ForeColor="Red" ErrorMessage="Invalid Mobile Number." />
                                    <asp:TextBox class="form-control" ID="txtC_alt" runat="server" placeholder="Alternate No." MaxLength="10"></asp:TextBox>

                                </div>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <i class="fa fa-envelope"></i>
                                    </div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" CssClass="Validators" Display="Dynamic" ValidationGroup="Teacher" ControlToValidate="txtC_email" runat="server" ErrorMessage="Please Enter Email Id." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtC_email" ForeColor="Red" ErrorMessage="Invalid email address." />
                                    <asp:TextBox class="form-control" ID="txtC_email" runat="server" placeholder="Enter Email *" />

                                </div>
                            </div>
                            <!-- /.input group -->
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>

        </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
 
  
</asp:Content>
