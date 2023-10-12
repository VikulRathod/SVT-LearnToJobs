<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Add_Total_Marks.aspx.cs" Inherits="TrainingAndPlacement.Add_Total_Marks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Add_Total_Marks
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">Add_Total_Marks</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header">
                        <h3 class="box-title">ACADEMICS TOTAL MARKS </h3>
                        <div class="box-tools pull-right">
                            <div class="input-group">
                                <asp:DropDownList ID="ddlAcademicYear" runat="server" class="form-control">
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
                        </div>
                    </div>
                    <div class="box-body">
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>1st year Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txt1YMarks" runat="server" placeholder=" 1st year Marks "></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>2nd Year Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txt2YMarks" runat="server" placeholder="Enter 2nd Year Marks"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>3rd Year Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txt3YMarks" runat="server" placeholder="Enter  3rd Year Marks" MaxLength="6"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>4th Year Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txt4YMarks" runat="server" placeholder="    4th Year Marks "></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>5th Year Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txt5YMarks" runat="server" placeholder="Enter  5th Year Marks"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Sem 1 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS1Marks" runat="server" placeholder="Enter  Sem 1 Marks" MaxLength="6"></asp:TextBox>
                            </div>
                        </div>

                        <!-- /.input group -->

                        <!-- /.form group -->
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Sem 2 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS2Marks" runat="server" placeholder=" Enter Sem 2 Marks "></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Sem 3 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS3Marks" runat="server" placeholder="Enter  Sem 3 Marks"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Sem 4 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS4Marks" runat="server" placeholder="Enter  Sem 4 Marks" MaxLength="6"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Sem 5 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS5Marks" runat="server" placeholder="Enter    Sem 5 Marks "></asp:TextBox>
                            </div>
                        </div>

                        <!-- /.form group -->
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Sem 6 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS6Marks" runat="server" placeholder="Enter  Sem 6 Marks"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Sem 7 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS7Marks" runat="server" placeholder="Enter Sem 7 Marks" MaxLength="6"></asp:TextBox>
                            </div>
                        </div>
                        <!-- /.input group -->

                        <!-- /.form group -->
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Sem 8 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS8Marks" runat="server" placeholder="  Enter  Sem 8 Marks"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Sem 9 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS9Marks" runat="server" placeholder="Enter 1st Year Percentage"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Sem 10 Marks</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtS10Marks" runat="server" placeholder="Enter  Sem 10 Marks" MaxLength="6"></asp:TextBox>
                            </div>

                        </div>

                        <!-- /.input group -->
                        <div class="form-group">
                            <div class="col-md-6 ser-fet"></div>
                            <div class="col-md-3 ser-fet">
                                <asp:Button ID="btnsave" runat="server" Text="Submit Now!" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-3 ser-fet">
                                <asp:Button ID="btnclear" runat="server" Text="Reset" class="btn btn-primary" OnClick="btnclear_Click" />

                            </div>
                            <!-- /.input group -->
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </section>
</asp:Content>
