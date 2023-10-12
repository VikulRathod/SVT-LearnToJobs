<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pri_rptStud_Regi_list.aspx.cs" Inherits="TrainingAndPlacement.Pri_rptStud_Regi_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <!-- Content Header (Page header) -->
    <section class="content-header">
        <h1>Student Registration
        <small>Reports</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-home"></i>Home</a></li>
            <li><a href="#">All Reports</a></li>
            <li><a href="#">Student Reports</a></li>
            <li><a href="#">Student Registration</a></li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-12">
                <!-- SELECT2 EXAMPLE -->
                <div class="box box-default">
                    <div class="box-header with-border">
                        <div class="col-md-4 ser-fet">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Academic Year: </button>
                                </div>
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
                            <br />
                        </div>
                        <div class="col-md-5 ">
                            <div class="input-group">
                                <div class="input-group-btn">
                                    <button type="button" class="btn btn-danger">Department Name: </button>
                                </div>
                                <asp:DropDownList ID="ddlCourse" runat="server" class="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-2 ser-fet">
                            <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Search</asp:LinkButton>
                        </div>

                    </div>
                </div>
                <!-- /.box-body -->
                <div class="box-footer">
                    <div class="col-md-6">Complate Student Registration Reports View.</div>
                    <div class="col-md-6">
                        <asp:Label ID="txterror" runat="server" ForeColor="Red" Font-Bold="True" />
                    </div>
                </div>
            </div>
        </div>

        <div class="box box-info ">

            <div class="box-header with-border">
                <h3 class="box-title">Complate Student Registration Reports View</h3>
                <div class="box-tools pull-right">
                    <asp:LinkButton ID="btnexcel" class="btn btn-primary" runat="server" OnClick="btnexcel_Click"><i class="fa fa-download"></i> Download Excel</asp:LinkButton>
                </div>
            </div>
            <!-- /.box-header -->
            <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 600px; width: 100%">
                <div class="form-group">
                    <asp:GridView ID="gmStudent_Regi" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                        <Columns>
                            <asp:BoundField HeaderText="ID." DataField="Student_ID" />
                            <asp:BoundField HeaderText="Academic Year" DataField="Academic_Year" />
                            <asp:BoundField DataField="Department" HeaderText="Department" ReadOnly="True" />
                            <asp:BoundField HeaderText="Aadhaar No" DataField="Aadhaar_No" />
                            <asp:BoundField HeaderText="University RegNo" DataField="University_Reg_No" />
                            <asp:BoundField HeaderText="ClassID" DataField="Class_ID" />
                            <asp:BoundField HeaderText="RollNo" DataField="Roll_No" />
                            <asp:BoundField HeaderText="Name" DataField="Student_Name" />
                            <asp:BoundField HeaderText="Email" DataField="Email" />
                            <asp:BoundField HeaderText="ContactNo" DataField="Contact_No" />
                            <asp:BoundField HeaderText="alt_contact_no" DataField="alt_contact_no" />
                            <asp:BoundField HeaderText="Mother Name" DataField="Mother_name" />
                            <asp:BoundField HeaderText="Gender" DataField="Gender" />
                            <asp:BoundField HeaderText="DOB" DataField="DOB" HtmlEncode="false" DataFormatString="{0:d}" />
                            <asp:BoundField HeaderText="BloodGroup" DataField="Blood_Group" />
                            <asp:BoundField HeaderText="MotherTongue" DataField="Mother_Tongue" />
                            <asp:BoundField HeaderText="Languages" DataField="Languages" />
                            <asp:BoundField HeaderText="AdmissionDate" DataField="Admission_Date" />
                            <asp:BoundField HeaderText="Address" DataField="Address" />
                            <asp:BoundField HeaderText="Nationality" DataField="Nationality" />
                            <asp:BoundField HeaderText="Domicile" DataField="Domicile" />
                            <asp:BoundField HeaderText="Religion" DataField="Religion" />
                            <asp:BoundField HeaderText="Category" DataField="Category" />
                            <asp:BoundField HeaderText="Caste" DataField="Caste" />
                            <asp:BoundField HeaderText="Hostelite" DataField="Hostelite" />
                            <asp:BoundField HeaderText="Handicap" DataField="Handicap" />
                            <asp:BoundField HeaderText="Sport" DataField="Sport" />
                            <asp:BoundField HeaderText="Defence" DataField="Defence" />
                            <asp:BoundField HeaderText="PAN_No" DataField="PAN_No" />
                            <asp:BoundField HeaderText="Passport_No" DataField="Passport_No" />
                            <asp:BoundField HeaderText="D. License" DataField="Driving_License" />
                            <asp:BoundField HeaderText="F_Name" DataField="F_Name" />
                            <asp:BoundField HeaderText="F_Contact" DataField="F_Contact" />
                            <asp:BoundField HeaderText="F_Email" DataField="F_Email" />
                            <asp:BoundField HeaderText="F_Occupation" DataField="F_Occupation" />
                            <asp:BoundField HeaderText="F_Organization" DataField="F_Organization" />
                            <asp:BoundField HeaderText="F_Designation" DataField="F_Designation" />
                            <asp:BoundField HeaderText="F_Address" DataField="F_Address" />
                            <asp:BoundField HeaderText="F_Annual_Income" DataField="F_Annual_Income" />
                            <asp:BoundField HeaderText="SSC_Board" DataField="SSC_Board" />
                            <asp:BoundField HeaderText="SSC_Institute" DataField="SSC_Institute" />
                            <asp:BoundField HeaderText="SSC_Percentage" DataField="SSC_Percentage" />
                            <asp:BoundField HeaderText="SSC_Passed_Year" DataField="SSC_Passed_Year" />
                            <asp:BoundField HeaderText="SSC_Attempt" DataField="SSC_Attempt" />
                            <asp:BoundField HeaderText="HSC_Board" DataField="HSC_Board" />
                            <asp:BoundField HeaderText="HSC_Institute" DataField="HSC_Institute" />
                            <asp:BoundField HeaderText="HSC_Percentage" DataField="HSC_Percentage" />
                            <asp:BoundField HeaderText="HSC_Passed_Year" DataField="HSC_Passed_Year" />
                            <asp:BoundField HeaderText="HSC_Attempt" DataField="HSC_Attempt" />
                            <asp:BoundField HeaderText="Diploma_Board" DataField="Diploma_Board" />
                            <asp:BoundField HeaderText="Diploma_Institute" DataField="Diploma_Institute" />
                            <asp:BoundField HeaderText="Diploma_Percentage" DataField="Diploma_Percentage" />
                            <asp:BoundField HeaderText="Diploma_Passed_Year" DataField="Diploma_Passed_Year" />
                            <asp:BoundField HeaderText="Diploma_Attempt" DataField="Diploma_Attempt" />
                            <asp:BoundField HeaderText="UG_Board" DataField="UG_Board" />
                            <asp:BoundField HeaderText="UG_Institute" DataField="UG_Institute" />
                            <asp:BoundField HeaderText="UG_Percentage" DataField="UG_Percentage" />
                            <asp:BoundField HeaderText="UG_Passed_Year" DataField="UG_Passed_Year" />
                            <asp:BoundField HeaderText="UG_Attempt" DataField="UG_Attempt" />
                            <asp:BoundField HeaderText="PG_Board" DataField="PG_Board" />
                            <asp:BoundField HeaderText="PG_Institute" DataField="PG_Institute" />
                            <asp:BoundField HeaderText="PG_Percentage" DataField="PG_Percentage" />
                            <asp:BoundField HeaderText="PG_Passed_Year" DataField="PG_Passed_Year" />
                            <asp:BoundField HeaderText="PG_Attempt" DataField="PG_Attempt" />
                            <asp:BoundField HeaderText="Sem1_Obtained_Marks" DataField="Sem1_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem1_Total_Marks" DataField="Sem1_Total_Marks" />
                            <asp:BoundField HeaderText="Sem1_Percentage" DataField="Sem1_Percentage" />
                            <asp:BoundField HeaderText="Sem1_SGPA" DataField="Sem1_SGPA" />
                            <asp:BoundField HeaderText="Sem1_BackLog" DataField="Sem1_BackLog" />
                            <asp:BoundField HeaderText="Sem2_Obtained_Marks" DataField="Sem2_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem2_Total_Marks" DataField="Sem2_Total_Marks" />
                            <asp:BoundField HeaderText="Sem2_Percentage" DataField="Sem2_Percentage" />
                            <asp:BoundField HeaderText="Sem2_SGPA" DataField="Sem2_SGPA" />
                            <asp:BoundField HeaderText="Sem2_BackLog" DataField="Sem2_BackLog" />
                            <asp:BoundField HeaderText="Sem3_Obtained_Marks" DataField="Sem3_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem3_Total_Marks" DataField="Sem3_Total_Marks" />
                            <asp:BoundField HeaderText="Sem3_Percentage" DataField="Sem3_Percentage" />
                            <asp:BoundField HeaderText="Sem3_SGPA" DataField="Sem3_SGPA" />
                            <asp:BoundField HeaderText="Sem3_BackLog" DataField="Sem3_BackLog" />
                            <asp:BoundField HeaderText="Sem4_Obtained_Marks" DataField="Sem4_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem4_Total_Marks" DataField="Sem4_Total_Marks" />
                            <asp:BoundField HeaderText="Sem4_Percentage" DataField="Sem4_Percentage" />
                            <asp:BoundField HeaderText="Sem4_SGPA" DataField="Sem4_SGPA" />
                            <asp:BoundField HeaderText="Sem4_BackLog" DataField="Sem4_BackLog" />
                            <asp:BoundField HeaderText="Sem5_Obtained_Marks" DataField="Sem5_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem5_Total_Marks" DataField="Sem5_Total_Marks" />
                            <asp:BoundField HeaderText="Sem5_Percentage" DataField="Sem5_Percentage" />
                            <asp:BoundField HeaderText="Sem5_SGPA" DataField="Sem5_SGPA" />
                            <asp:BoundField HeaderText="Sem5_BackLog" DataField="Sem5_BackLog" />
                            <asp:BoundField HeaderText="Sem6_Obtained_Marks" DataField="Sem6_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem6_Total_Marks" DataField="Sem6_Total_Marks" />
                            <asp:BoundField HeaderText="Sem6_Percentage" DataField="Sem6_Percentage" />
                            <asp:BoundField HeaderText="Sem6_SGPA" DataField="Sem6_SGPA" />
                            <asp:BoundField HeaderText="Sem6_BackLog" DataField="Sem6_BackLog" />
                            <asp:BoundField HeaderText="Sem7_Obtained_Marks" DataField="Sem7_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem7_Total_Marks" DataField="Sem7_Total_Marks" />
                            <asp:BoundField HeaderText="Sem7_Percentage" DataField="Sem7_Percentage" />
                            <asp:BoundField HeaderText="Sem7_SGPA" DataField="Sem7_SGPA" />
                            <asp:BoundField HeaderText="Sem7_BackLog" DataField="Sem7_BackLog" />
                            <asp:BoundField HeaderText="Sem8_Obtained_Marks" DataField="Sem8_Obtained_Marks" />
                            <asp:BoundField HeaderText="Sem8_Total_Marks" DataField="Sem8_Total_Marks" />
                            <asp:BoundField HeaderText="Sem8_Percentage" DataField="Sem8_Percentage" />
                            <asp:BoundField HeaderText="Sem8_SGPA" DataField="Sem8_SGPA" />
                            <asp:BoundField HeaderText="Sem8_BackLog" DataField="Sem8_BackLog" />
                            <asp:BoundField HeaderText="Year1_Obtained_Marks" DataField="Year1_Obtained_Marks" />
                            <asp:BoundField HeaderText="Year1_Total_Marks" DataField="Year1_Total_Marks" />
                            <asp:BoundField HeaderText="Year1_Percentage" DataField="Year1_Percentage" />
                            <asp:BoundField HeaderText="Year1_SGPA" DataField="Year1_SGPA" />
                            <asp:BoundField HeaderText="Year1_BackLog" DataField="Year1_BackLog" />
                            <asp:BoundField HeaderText="Year2_Obtained_Marks" DataField="Year2_Obtained_Marks" />
                            <asp:BoundField HeaderText="Year2_Total_Marks" DataField="Year2_Total_Marks" />
                            <asp:BoundField HeaderText="Year2_Percentage" DataField="Year2_Percentage" />
                            <asp:BoundField HeaderText="Year2_SGPA" DataField="Year2_SGPA" />
                            <asp:BoundField HeaderText="Year2_BackLog" DataField="Year2_BackLog" />
                            <asp:BoundField HeaderText="Year3_Obtained_Marks" DataField="Year3_Obtained_Marks" />
                            <asp:BoundField HeaderText="Year3_Total_Marks" DataField="Year3_Total_Marks" />
                            <asp:BoundField HeaderText="Year3_Percentage" DataField="Year3_Percentage" />
                            <asp:BoundField HeaderText="Year3_SGPA" DataField="Year3_SGPA" />
                            <asp:BoundField HeaderText="Year3_BackLog" DataField="Year3_BackLog" />
                            <asp:BoundField HeaderText="Year4_Obtained_Marks" DataField="Year4_Obtained_Marks" />
                            <asp:BoundField HeaderText="Year4_Total_Marks" DataField="Year4_Total_Marks" />
                            <asp:BoundField HeaderText="Year4_Percentage" DataField="Year4_Percentage" />
                            <asp:BoundField HeaderText="Year4_SGPA" DataField="Year4_SGPA" />
                            <asp:BoundField HeaderText="Year4_BackLog" DataField="Year4_BackLog" />
                            <asp:BoundField HeaderText="Year5_Obtained_Marks" DataField="Year5_Obtained_Marks" />
                            <asp:BoundField HeaderText="Year5_Total_Marks" DataField="Year5_Total_Marks" />
                            <asp:BoundField HeaderText="Year5_Percentage" DataField="Year5_Percentage" />
                            <asp:BoundField HeaderText="Year5_SGPA" DataField="Year5_SGPA" />
                            <asp:BoundField HeaderText="Year5_BackLog" DataField="Year5_BackLog" />
                            <asp:BoundField HeaderText="Live_Backlogs" DataField="Live_Backlogs" />
                            <asp:BoundField HeaderText="Dead_Backlogs" DataField="Dead_Backlogs" />
                            <asp:BoundField HeaderText="Experience" DataField="Experience" />
                            <asp:BoundField HeaderText="Entrance_Score" DataField="Entrance_Score" />
                            <asp:BoundField HeaderText="Aggregate" DataField="Aggregate" />
                            <asp:BoundField HeaderText="status" DataField="status" />
                            <asp:BoundField HeaderText="Approuvel" DataField="Approuvel" />
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
    </section>
</asp:Content>
