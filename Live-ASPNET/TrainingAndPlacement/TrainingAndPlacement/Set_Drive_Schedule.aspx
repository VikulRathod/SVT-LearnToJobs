<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Set_Drive_Schedule.aspx.cs" Inherits="TrainingAndPlacement.Set_Drive_Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Set_Drive_Schedule
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li>Set_Drive_Schedule</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header">
                        <h3 class="box-title">Basic Information</h3>
                    </div>
                    <div class="box-body">
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Academic Year *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
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
                            <div class="col-md-2 ser-fet">
                                <label>Select Company *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Select Drive *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:DropDownList ID="ddlDrive_Title" runat="server" class="form-control" OnSelectedIndexChanged="ddlDrive_Title_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Select Round Number *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:DropDownList ID="ddlRoundNumber" runat="server" class="form-control" OnSelectedIndexChanged="ddlRoundNumber_SelectedIndexChanged" AutoPostBack="True">
                                    <asp:ListItem>Select Round Number</asp:ListItem>
                                    <asp:ListItem>Round_1</asp:ListItem>
                                    <asp:ListItem>Round_2</asp:ListItem>
                                    <asp:ListItem>Round_3</asp:ListItem>
                                    <asp:ListItem>Round_4</asp:ListItem>
                                    <asp:ListItem>Round_5</asp:ListItem>
                                    <asp:ListItem>Round_6</asp:ListItem>
                                    <asp:ListItem>Round_7</asp:ListItem>
                                    <asp:ListItem>Round_8</asp:ListItem>
                                    <asp:ListItem>Round_9</asp:ListItem>
                                    <asp:ListItem>Round_10</asp:ListItem>

                                </asp:DropDownList>

                            </div>
                        </div>

                        <!-- /.input group -->

                        <!-- /.form group -->

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Round Title *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtRoundTitle" runat="server" placeholder="Enter Round Title *"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Round Date *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <ajaxToolkit:CalendarExtender ID="txtC_dob_CalendarExtender" CssClass="Calendar" Format="dd/MM/yyyy" runat="server" Enabled="True" TargetControlID="txtRoundDate" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Display="Dynamic" ValidationGroup="Teacher" ValidationExpression="^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$" ControlToValidate="txtRoundDate" ForeColor="Red" ErrorMessage="Invalid Date Format." />
                                <asp:TextBox class="form-control" ID="txtRoundDate" runat="server" placeholder="Enter  Round Date *"></asp:TextBox>
                            </div>
                        </div>

                        <!-- /.form group -->

                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Round Timing *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtRoundTiming" runat="server" placeholder="Enter  Round Timing *"></asp:TextBox>
                            </div>
                            <div class="col-md-2 ser-fet">
                                <label>Venue *:</label>
                            </div>
                            <div class="col-md-4 ser-fet">

                                <asp:TextBox class="form-control" ID="txtVenue" runat="server" placeholder="Enter  Venue *"></asp:TextBox>
                            </div>
                        </div>
                        <!-- /.form group -->

                        <!-- /.form group -->

                        <!-- /.form group -->

                        <div class="form-group">
                            <div class="col-md-2 ser-fet">
                                <label>Description :</label>
                            </div>
                            <div class="col-md-4 ser-fet">
                                <asp:TextBox class="form-control" ID="txtDescription" runat="server" placeholder="Enter Description"></asp:TextBox>

                            </div>



                        </div>

                        <!-- /.input group -->

                        <!-- /.input group -->

                        <div class="form-group">
                            <div class="col-md-6 ser-fet"></div>
                            <div class="col-md-3">
                                <asp:Button ID="btnsave" runat="server" Text="Submit Now!" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="btnclear" runat="server" Text="Reset" class="btn btn-primary" OnClick="btnclear_Click" />
                            </div>
                        </div>
                        <!-- /.input group -->

                        <!-- /.form group -->

                    </div>
                </div>
            </div>

            <div class="col-md-12">
                <div class="box box-danger">
                    <div class="box-header with-border">
                        <div class="col-md-6">
                            <h3 class="box-title">Set_Drive_Schedule </h3>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnshowall" class="btn btn-primary" runat="server" OnClick="btnshowall_Click"><i class="fa fa-download"></i> Show Current Schedule</asp:LinkButton>
                        </div>
                        <div class="col-md-3">
                            <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click"><i class="fa fa-download"></i> Download Excel</asp:LinkButton>
                        </div>
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
            </div>
        </div>
    </section>
</asp:Content>


