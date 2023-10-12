<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Add_Update_Staff.aspx.cs" Inherits="TrainingAndPlacement.Add_Update_Staff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add / Update Staff
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li>Add / Update Staff</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-2">
                            <asp:RadioButton ID="Radionew" GroupName="attend" runat="server" AutoPostBack="true" Text="  New" OnCheckedChanged="Radionew_CheckedChanged" />
                        </div>
                        <div class="col-md-2">
                            <asp:RadioButton ID="Radiold" GroupName="attend" runat="server" AutoPostBack="true" Text="  Update" OnCheckedChanged="Radiold_CheckedChanged" />
                        </div>
                        <asp:Panel ID="ID" runat="server">
                            <div class="col-md-5">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Coordinator ID: </button>
                                    </div>
                                    <asp:TextBox class="form-control" ID="txtC_emp_id" runat="server" placeholder="Enter Search Id *" />
                                </div>
                            </div>
                        </asp:Panel>
                        <div class="col-md-3">
                            <div class="input-group">
                                <asp:LinkButton ID="search" class="btn btn-primary" runat="server" ValidationGroup="id" OnClick="search_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header">
                        <div class="col-md-4 ser-fet">
                            <h3 class="box-title">Basic Information</h3>
                        </div>
                        <div class="col-md-4 ser-fet">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Select Department *: </button>
                                </div>
                                <asp:DropDownList ID="ddlDepartment" runat="server" class="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-4 ser-fet">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Select Designation *: </button>
                                </div>
                                <asp:DropDownList ID="ddlDesignation" runat="server" class="form-control">
                                    <asp:ListItem>---Select Designation---</asp:ListItem>
                                    <asp:ListItem Value="Coordinator">Coordinator</asp:ListItem>
                                    <asp:ListItem Value="HOD">HOD</asp:ListItem>
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
                                        First Name *
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
                                        Last Name *
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
                                <label>ID Proof:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlIdCardTypeC" runat="server" class="form-control">
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Adhar Card</asp:ListItem>
                                    <asp:ListItem>Voting Card</asp:ListItem>
                                    <asp:ListItem>Pan Card</asp:ListItem>
                                    <asp:ListItem>Driving Licence</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtcardnoC" runat="server" placeholder="Enter Card No. " />
                            </div>

                            <!-- /.input group -->
                        </div>
                        <!-- /.form group -->

                        <!-- phone mask -->
                        <div class="form-group" align="center">
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <i class="fa fa-calendar"></i>
                                    </div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="Validators" Display="Dynamic" ValidationGroup="Teacher" ControlToValidate="txtC_dob" runat="server" ErrorMessage="Please Enter Date of Birth." ForeColor="#0066ff"></asp:RequiredFieldValidator>
                                    <ajaxToolkit:CalendarExtender ID="txtC_dob_CalendarExtender" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtC_dob" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtC_dob" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                    <asp:TextBox ID="txtC_dob" runat="server" class="form-control" format="dd/mm/yyyy" placeholder="Select Date Of Birth *" />
                                </div>
                            </div>
                            <div class="col-md-4 ser-fet" align="right">
                                <label>Gender:</label>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <asp:RadioButton ID="RadiomaleC" runat="server" GroupName="gender" Text="Male" />
                            </div>
                            <div class="col-md-2 ser-fet">
                                <asp:RadioButton ID="RadiofemaleC" runat="server" GroupName="gender" Text="Female" />
                            </div>
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
                                    <asp:TextBox class="form-control" ID="txtC_contact" runat="server" placeholder="Contact no. *" />

                                </div>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <div class="input-group">
                                    <div class="input-group-addon">
                                        <i class="fa fa-phone"></i>
                                    </div>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Display="Dynamic" ValidationExpression="^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$" ControlToValidate="txtC_alt" ForeColor="Red" ErrorMessage="Invalid Mobile Number." />
                                    <asp:TextBox class="form-control" ID="txtC_alt" runat="server" placeholder="Alternate No."></asp:TextBox>

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
                                    <asp:Button ID="btnsave" runat="server" Text="Save / Update" class="btn btn-primary btn-success" ValidationGroup="Teacher" OnClick="btnsave_Click" />
                                </div>
                                <div class="col-md-6">
                                    <asp:Button ID="tbnclear" runat="server" Text="Clear All" class="btn btn-primary" OnClick="tbnclear_Click" />
                                </div>
                            </div>
                        </div>

                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>


        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header with-border">
                        <div class=" row col-md-5">
                            <h3 class="box-title">List of Staff</h3>
                        </div>

                    </div>
                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 550px; width: 100%">
                        <asp:GridView ID="gvsearch_name" CssClass="table table-striped table-bordered table-hover" runat="server"
                            AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" DataKeyNames="emp_id"
                            BorderWidth="1px" CellPadding="3" PageIndex="10" AutoPostBack="true" OnSelectedIndexChanged="gvsearch_name_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" ControlStyle-ForeColor="Blue" />
                                <asp:BoundField DataField="emp_id" HeaderText="Staff ID" ReadOnly="True" />
                                <asp:BoundField DataField="fnm" HeaderText="fnm" ReadOnly="True" />
                                <asp:BoundField DataField="mnm" HeaderText="mnm" ReadOnly="True" />
                                <asp:BoundField DataField="lnm" HeaderText="lnm " ReadOnly="True" />
                                <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" />
                                <asp:BoundField DataField="contact" HeaderText="contact" ReadOnly="True" />
                                <asp:BoundField DataField="Department" HeaderText="Department" ReadOnly="True" />
                                <asp:BoundField DataField="Designation" HeaderText="Designation" ReadOnly="True" />
                                <asp:BoundField DataField="Joining_Date" HeaderText="Joining_Date" ReadOnly="True" />
                                <asp:BoundField DataField="status" HeaderText="status" ReadOnly="True" />
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
    </section>
    <!-- /.content -->
</asp:Content>

