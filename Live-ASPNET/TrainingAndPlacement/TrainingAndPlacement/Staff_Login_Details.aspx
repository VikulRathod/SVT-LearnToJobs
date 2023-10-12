<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Placement.Master" AutoEventWireup="true" CodeBehind="Staff_Login_Details.aspx.cs" Inherits="TrainingAndPlacement.Staff_Login_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <script type="text/javascript">
        var TotalChkBx;
        var Counter;

        window.onload = function () {
            //Get total no. of CheckBoxes in side the GridView.
            TotalChkBx = parseInt('<%= this.gvUser.Rows.Count %>');

            //Get total no. of checked CheckBoxes in side the GridView.
            Counter = 0;
        }

        function HeaderClick(CheckBox) {
            //Get target base & child control.
            var TargetBaseControl = document.getElementById('<%= this.gvUser.ClientID %>');
            var TargetChildControl = "chkBxSelect";

            //Get all the control of the type INPUT in the base control.
            var Inputs = TargetBaseControl.getElementsByTagName("input");

            //Checked/Unchecked all the checkBoxes in side the GridView.
            for (var n = 0; n < Inputs.length; ++n)
                if (Inputs[n].type == 'checkbox' && Inputs[n].id.indexOf(TargetChildControl, 0) >= 0)

                    Inputs[n].checked = CheckBox.checked;

            //Reset Counter
            Counter = CheckBox.checked ? TotalChkBx : 0;
        }

        function ChildClick(CheckBox, HCheckBox) {
            //get target control.
            var HeaderCheckBox = document.getElementById(HCheckBox);

            //Modifiy Counter; 
            if (CheckBox.checked && Counter < TotalChkBx)
                Counter++;
            else if (Counter > 0)
                Counter--;

            //Change state of the header CheckBox.
            if (Counter < TotalChkBx)
                HeaderCheckBox.checked = false;
            else if (Counter == TotalChkBx)
                HeaderCheckBox.checked = true;
        }
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Staff Login 
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="Login_Details.aspx">Staff Login</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-3">
                            <label>
                                <asp:Label ID="id" runat="server" Text="Username :" /></label>
                        </div>
                        <div class="col-md-5">
                            <asp:TextBox class="form-control" ID="txtid" runat="server" placeholder="Enter Search Id *" />
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="btnsearch" runat="server" Text="Search Id" class="btn btn-primary" OnClick="btnsearch_Click" />
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
            <div class="col-md-1"></div>
        </div>
        <div class="box box-info ">

            <div class="box-header with-border">
                <div class="col-md-4 ser-fet">
                    <h3 class="box-title">Active and Deactiveted Details</h3>
                </div>
                <div class="col-md-2 ser-fet">
                    <asp:Button ID="btnemail" runat="server" Text="Active" class="btn btn-primary btn-success" OnClick="btnemail_Click" />
                </div>
                <div class="col-md-3 ser-fet">
                    <asp:Button ID="btnSMS" runat="server" Text="Deactive" class="btn btn-primary btn-success" OnClick="btnSMS_Click" />
                </div>
                <div class="col-md-3 ser-fet">
                    <asp:Button ID="btncompose" runat="server" Text="Add User" class="btn btn-primary btn-success" />
                </div>
            </div>
            <!-- /.box-header -->
            <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                <asp:GridView ID="gvUser" CssClass="table table-striped table-bordered table-hover" runat="server"
                    CellPadding="3" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC"
                    BorderStyle="None" BorderWidth="1px" DataKeyNames="username" EnableModelValidation="True"
                    OnRowCreated="gvUser_RowCreated">
                    <Columns>
                        <asp:TemplateField HeaderText="select">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkBxSelect" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                            <HeaderTemplate>
                                <asp:CheckBox ID="chkBxHeader" onclick="javascript:HeaderClick(this);" runat="server" />
                            </HeaderTemplate>
                        </asp:TemplateField>
                        <%--<asp:BoundField DataField="fnm" HeaderText="Name" ReadOnly="True" />--%>
                        <asp:BoundField DataField="contact" HeaderText="Mobile No" ReadOnly="True" />
                        <asp:BoundField DataField="email" HeaderText="Email Id" ReadOnly="True" />
                        <asp:BoundField DataField="username" HeaderText="Username" ReadOnly="True" />
                        <asp:BoundField DataField="login_password" HeaderText="Password" ReadOnly="True" />
                        <asp:BoundField DataField="login_role" HeaderText="Login Role" ReadOnly="True" />
                        <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True" />
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
    </section>
    <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" CancelControlID="Button1" TargetControlID="btncompose" PopupControlID="Panel1" BackgroundCssClass="bgcss"></ajaxToolkit:ModalPopupExtender>
    <asp:Panel ID="Panel1" runat="server">
        <div class="modal-dialog" style="font-family: Georgia;">
            <div class="panel panel-danger">
                <div class="panel-heading">
                    Add User
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtUsername" ForeColor="Red" ErrorMessage="Invalid email address." />
                        <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Username: </button>
                                    </div>
                            <asp:TextBox class="form-control" ID="txtUsername" runat="server" placeholder="Enter Username *" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Password: </button>
                                    </div>
                            <asp:TextBox class="form-control" ID="txtPassword" runat="server" placeholder="Enter Password*" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Select Login Role: </button>
                                </div>
                                <asp:DropDownList ID="ddlRole" runat="server" class="form-control">
                                    <asp:ListItem>---Select Login Role---</asp:ListItem>
                                    <asp:ListItem Value="Principal">Principal</asp:ListItem>
                                    <asp:ListItem Value="Admin">TPO</asp:ListItem>
                                    <asp:ListItem Value="Coordinator">Coordinator</asp:ListItem>
                                    <asp:ListItem Value="HOD">HOD</asp:ListItem>
                                    <asp:ListItem Value="Company">Company</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-3"></div>
                        <div class="col-md-5">
                            <asp:LinkButton ID="btnAddUser" class="btn btn-primary" runat="server" ValidationGroup="id" OnClick="btnAddUser_Click" ><i class="fa fa-Add"></i>  Add User</asp:LinkButton>
                        </div>
                        <div class="col-md-4">
                            <asp:Button ID="Button1" runat="server" Text="Close" class="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
