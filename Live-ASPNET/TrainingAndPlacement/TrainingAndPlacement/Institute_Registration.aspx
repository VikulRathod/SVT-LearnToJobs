<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Institute_Registration.aspx.cs" Inherits="TrainingAndPlacement.Master_Panel.Institute_Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Institute 
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Institute Registration</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <asp:Panel ID="Panel1" runat="server">
                <div class="col-md-7">
                    <div class="box box-info">
                        <div class="box-header with-border">
                            <h3 class="box-title">Training And Placement</h3>
                        </div>
                        <div class="box-body">
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Institute Name :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_name" runat="server" placeholder="Eneter Institute Name *" required="required"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" Display="Dynamic" ValidationExpression="[a-zA-Z ]*$" ControlToValidate="txtI_name" ForeColor="Red" ErrorMessage="TextBox accept only alphabeti & Space" />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Contact No :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_contact" runat="server" placeholder="Enter Contact No "></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" Display="Dynamic" ValidationExpression="^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$" ControlToValidate="txtI_contact" ForeColor="Red" ErrorMessage="Invalid Mobile Number." />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Email ID :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_email" runat="server" placeholder="Enter Email ID "></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtI_email" ForeColor="Red" ErrorMessage="Invalid email address." />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Web Site :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_web" runat="server" placeholder="Enter Web Site "></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Address Line 1 * :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_add1" runat="server" placeholder="Enter Addres Line 1 *" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Address Line 2 :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_add2" runat="server" placeholder="Enter Addres Line 2 "></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Town / City * :</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_city" runat="server" placeholder="Enter Town / City *" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>District  *:</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_disc" runat="server" placeholder="Enter District *" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4">
                                    <label>Post Code *:</label>
                                </div>
                                <div class="col-md-8">
                                    <asp:TextBox class="form-control" ID="txtI_pin" runat="server" placeholder="Enter Post Code *" MaxLength="6" required="required"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtI_pin" ForeColor="Red" ErrorMessage="Invalid Pincode NUmber." />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="box box-primary">
                        <div class="box-header" align="center">
                            <h3 class="box-title">Upload Profile Photo</h3>
                        </div>
                        <div class="box-body">
                            <asp:FileUpload ID="FileUpload1" runat="server" class="btn btn-danger" Style="width: 100%;" />
                        </div>
                        <!-- /.box-body -->
                    </div>

                    <div class="panel panel-danger">
                        <div class="panel-heading">
                            Send Mail Setting
                        </div>
                        <div class="panel-body" style="font-family: Georgia;">
                            <div class="form-group">
                                <div class="col-md-4 ser-fet">
                                    <label>Email Id *:</label>
                                </div>
                                <div class="col-md-8 ser-fet">

                                    <asp:TextBox class="form-control" ID="txtsendmail" runat="server" placeholder="Enter Email Id *" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4 ser-fet">
                                    <label>Password *:  </label>
                                </div>
                                <div class="col-md-8 ser-fet">

                                    <asp:TextBox class="form-control" ID="txtsendmailpwd" runat="server" placeholder="Enter Password *" required="required"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-4 ser-fet">
                                    <label>smtp *:</label>
                                </div>
                                <div class="col-md-8 ser-fet">

                                    <asp:TextBox class="form-control" ID="txtsmtp" runat="server" placeholder="Enter smtp*" required="required"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <div class="col-md-4 ser-fet">
                                        <label>port *:</label>
                                    </div>
                                    <div class="col-md-8 ser-fet">

                                        <asp:TextBox class="form-control" ID="txtport" runat="server" placeholder="Enter port *" required="required"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <div class="col-md-4 ser-fet">
                                        <label>link:</label>
                                    </div>
                                    <div class="col-md-8 ser-fet">

                                        <asp:TextBox class="form-control" ID="txtlink" runat="server" placeholder="Enter link"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-md-4 ser-fet">
                                        <label>SMS ID:</label>
                                    </div>
                                    <div class="col-md-8 ser-fet">

                                        <asp:TextBox class="form-control" ID="txtsmsid" runat="server" placeholder="Enter SMS ID"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-md-4 ser-fet">
                                        <label>SMS Password: </label>
                                    </div>
                                    <div class="col-md-8 ser-fet">

                                        <asp:TextBox class="form-control" ID="txtsmspass" runat="server" placeholder="Enter SMS Password "></asp:TextBox>
                                    </div>

                                </div>
                            </div>

                        </div>
                    </div>
                    <!-- /.box -->
                </div>
                <!-- /.box -->
            </asp:Panel>
        </div>
        <!-- /.row -->
        <div class="row">
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-12" align="Right">
                            <div class="col-md-3 ser-fet"></div>
                            <div class="col-md-3 ser-fet">
                                <asp:Button ID="btnedit" runat="server" Text="Edit!" class="btn btn-primary" Font-Bold="True" OnClick="btnedit_Click" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="btnsave" runat="server" Text="Save / Update Now!" class="btn btn-primary" Font-Bold="True" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="tbnclear" runat="server" Text="Reset" class="btn btn-primary" OnClick="tbnclear_Click" />
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
        </div>
    </section>
</asp:Content>
