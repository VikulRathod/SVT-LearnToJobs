<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Student.Master" CodeBehind="Resume.aspx.cs" Inherits="TrainingAndPlacement.Resume" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <!-- Content Header (Page header) -->
    <section class="content-header">
         <h1>Resume
        <small>Information</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Staff_Home.aspx"><i class="fa fa-home"></i>Home</a></li>
            <li>Add / Update Coordinator</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
        
           
        <div class="col-md-12">
            <div class="box box-danger">
                <div class="box-header with-border">
                    <h3 class="box-title">Project Details List</h3>
                </div>
                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 300px; width: 100%">
                    <asp:GridView ID="gvProject_Details" CssClass="table table-striped table-bordered table-hover" runat="server"
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" DataKeyNames="Student_ID"
                        BorderWidth="1px" CellPadding="3" PageIndex="10">
                        <Columns>
                            <asp:BoundField HeaderText="Student ID" DataField="Student_ID" />
                            <asp:BoundField HeaderText="Project Type" DataField="Project_Type" />
                            <asp:BoundField HeaderText="Project Title" DataField="Project_Title" />
                            <asp:BoundField HeaderText="Project Domain" DataField="Project_Domain" />
                            <asp:BoundField HeaderText="Project Duration" DataField="Project_Duration" />
                            <asp:BoundField HeaderText="Technologies" DataField="Technologies" />
                            <asp:BoundField HeaderText="Team Size" DataField="Team_Size" />
                            <asp:BoundField HeaderText="Guide Name" DataField="Guide_Name" />
                            <asp:BoundField HeaderText="Description" DataField="Description" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

           
                <div class="box box-danger">
                    <div class="box-header with-border">
                        <h3 class="box-title">Add Achievement Details </h3>
                         </div>
                             <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 300px; width: 100%">
                                <asp:GridView ID="gvAchievementDetails" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                            <Columns>
                                <asp:BoundField HeaderText="studentID" DataField="studentID" InsertVisible="False" ReadOnly="True" SortExpression="studentID" />
                                <asp:BoundField HeaderText="Achievement_Title" DataField="Achievement_Title" SortExpression="Achievement_Title" />
                                <asp:BoundField HeaderText="Achievement_Details" DataField="Achievement_Details" SortExpression="Achievement_Details" />
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
            



            <div class="box box-info ">
                <div class="box-header with-border">
                    <h3 class="box-title">Student Activities Details </h3>
                </div>
                <!-- /.box-header -->
                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 300px; width: 100%">
                    <div class="form-group">
                        <asp:GridView ID="gvstudent_extraActivity" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                            <Columns>
                                <asp:BoundField HeaderText="Student Id" DataField="Student_id" />
                                <asp:BoundField HeaderText="Activity Title" DataField="Activity_Title" />
                                <asp:BoundField HeaderText="Activity Details" DataField="Activity_Details" />
                                <asp:BoundField HeaderText="Description" DataField="Description" />

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


            
                <div class="box box-danger">
                    <div class="box-header with-border">
                        <h3 class="box-title">Add Technical Details </h3>
                    </div>

                    <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height: 300px; width: 100%">
                        <asp:GridView ID="gvTechnicalDetails" CssClass="table table-striped table-bordered table-hover" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" PageIndex="10">
                            <Columns>
                                <asp:BoundField HeaderText="stuID" DataField="stuID" InsertVisible="False" ReadOnly="True" SortExpression="stuID" />
                                <asp:BoundField HeaderText="Course_Title" DataField="Course_Title" SortExpression="Course_Title" />
                                <asp:BoundField HeaderText="Technical_Details" DataField="Technical_Details" SortExpression="Technical_Details" />
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
