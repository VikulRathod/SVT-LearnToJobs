<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="Pri_Student_Manage.aspx.cs" Inherits="TrainingAndPlacement.Pri_Student_Manage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Manage Student
        <small>"Notification to be sent to the records present in Grid Table"</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Coordinator_Profile.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Manage Student Details</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-4">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Academic Year: </button>
                                </div>
                                <asp:DropDownList ID="ddlAcademic" runat="server" class="form-control">
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
                        </div>
                        <div class="col-md-5 ">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Course Name: </button>
                                </div>
                                <asp:DropDownList ID="ddlCourse" runat="server" class="form-control">
                                 </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-2 ser-fet">
                            <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="Student" OnClick="Search_Click"><i class="fa fa-search"></i> Show </asp:LinkButton>
                        </div>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
        </div>

        <div class="box box-info ">

            <div class="box-header with-border">
                <h3 class="box-title">"Notification to be sent to the records present in Grid Table"</h3>
                <div class="box-tools pull-right">
                    <div class="input-group">
                        <asp:LinkButton ID="btnSend" class="btn btn-primary" runat="server" OnClick="btnSend_Click" ><i class="fa fa-send"></i> Send Notification</asp:LinkButton>        
                    </div>
                </div>
            </div>
            <!-- /.box-header -->
            <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                <div class="form-group">
                    <asp:GridView ID="gvregi_mem" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                        DataKeyNames="Student_ID" BorderWidth="1px" CellPadding="3">
                        <Columns>
                            <asp:BoundField HeaderText="ID." DataField="Student_ID" />
                            <asp:BoundField HeaderText="University RegNo" DataField="University_Reg_No" />
                            <asp:BoundField HeaderText="RollNo" DataField="Roll_No"/>
                            <asp:BoundField HeaderText="Name" DataField="Student_Name" />
                            <asp:BoundField HeaderText="Email" DataField="Email" />
                            <asp:BoundField HeaderText="ContactNo" DataField="Contact_No" />
                            <asp:BoundField HeaderText="Aggregate" DataField="Aggregate" />
                            <asp:BoundField HeaderText="status" DataField="status" />
                            <asp:BoundField HeaderText="Approuvel" DataField="Approuvel" />
                        </Columns>

                    </asp:GridView>
                </div>
            </div>

        </div>
    </section>
</asp:Content>
