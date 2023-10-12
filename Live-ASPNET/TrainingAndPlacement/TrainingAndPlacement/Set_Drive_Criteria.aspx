<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Admin_Placement.Master" CodeBehind="Set_Drive_Criteria.aspx.cs" Inherits="TrainingAndPlacement.Set_Drive_Criteria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Set_Drive_Criteria
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li>Set_Drive_Criteria</li>
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
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Academic Year *: </button>
                                    </div>
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
                                <br />
                            </div>


                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Company_ID *:</button>
                                    </div>
                                    <asp:DropDownList ID="ddlCompany_ID" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCompany_ID_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Drive_Title *: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlDrive_Title" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlDrive_Title_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>
                        </div>

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
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtsscPassingYear" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                <asp:TextBox class="form-control" ID="txtsscPassingYear" runat="server" Text="0" placeholder="Enter   SSC Passing Year " MaxLength="4"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-md-3 ser-fet">
                                <label>HSC Percentage</label>
                            </div>
                            <div class="col-md-3 ser-fet">
                                <asp:TextBox class="form-control" ID="txtHSCper" runat="server" Text="0" placeholder="Enter   HSC Percentage " ></asp:TextBox>
                            </div>
                            <div class="col-md-3 ser-fet">
                                <label>HSC Passing Year *</label>
                            </div>
                            <div class="col-md-3 ser-fet">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txthscPYear" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                <asp:TextBox class="form-control" ID="txthscPYear" runat="server" Text="0" placeholder="Enter   HSC Passing Year" MaxLength="4" ></asp:TextBox>

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
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtDpyear" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
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
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtUGPassingY" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
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
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtPGpassingY" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
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

                        <!-- /.form group -->

                        <!-- /.form group -->

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
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtEntranceScore" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                <asp:TextBox class="form-control" ID="txtEntranceScore" runat="server" Text="0" placeholder="Enter  Entrance Score"></asp:TextBox>
                            </div>
                            <div class="col-md-3 ser-fet">
                                <label>Aggregate %</label>
                            </div>
                            <div class="col-md-3 ser-fet">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" Display="Dynamic" ValidationExpression="^[0-9]*$" ControlToValidate="txtAggregate" ForeColor="Red" ErrorMessage="This field accepts only Numbers." />
                                <asp:TextBox class="form-control" ID="txtAggregate" runat="server" Text="0" placeholder="Enter Aggregate %"></asp:TextBox>
                            </div>
                        </div>
                        <!-- /.form group -->
                        <div class="form-group">
                            <div class="col-md-6 ser-fet"></div>
                            <div class="col-md-3">
                                <asp:Button ID="btnsave" runat="server" Text="Submit Now!" class="btn btn-primary" ValidationGroup="id" OnClick="btnsave_Click" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button ID="btnclear" runat="server" Text="Reset" class="btn btn-primary" OnClick="btnclear_Click" />
                            </div>
                            <!-- /.form group -->
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%--  <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height:550px; width:100%">
                    <asp:GridView ID="gvSubmitNow" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                                    <Columns>
                                        <asp:BoundField HeaderText="Academic_Year" DataField="Academic_Year" InsertVisible="False" ReadOnly="True" SortExpression="Academic_Year" />
                                        <asp:BoundField HeaderText="Company_ID" DataField="Company_ID" SortExpression="Company_ID" />
                                        <asp:BoundField HeaderText="Drive_Title" DataField="Drive_Title" SortExpression="Drive_Title" />
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
                    
                <%--</div>--%>
    </section>
</asp:Content>
