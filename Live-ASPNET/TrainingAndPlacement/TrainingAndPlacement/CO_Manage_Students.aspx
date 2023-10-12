<%@ Page Title="" Language="C#" MasterPageFile="~/Coordinator.Master" AutoEventWireup="true" CodeBehind="CO_Manage_Students.aspx.cs" Inherits="TrainingAndPlacement.CO_Manage_Students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script type="text/javascript">
         var TotalChkBx;
         var Counter;

         window.onload = function () {
             //Get total no. of CheckBoxes in side the GridView.
             TotalChkBx = parseInt('<%= this.gvStudent.Rows.Count %>');

             //Get total no. of checked CheckBoxes in side the GridView.
             Counter = 0;
         }

         function HeaderClick(CheckBox) {
             //Get target base & child control.
             var TargetBaseControl = document.getElementById('<%= this.gvStudent.ClientID %>');
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
      <h1>
        Manage Students
        <small>Information</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="Coordinator_Profile.aspx"><i class="fa fa-home"></i> Home</a></li>
        <li><a href="Deactiveted.aspx">Manage Students</a></li>
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
                            <div class="col-md-4 ">
                               <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Course Name: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlCourse" runat="server" class="form-control">
                                     </asp:DropDownList>
                                </div>
                            </div>
                    <div class="col-md-3 ser-fet">      
                        <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Show </asp:LinkButton>
                    </div>
                    <div class="col-md-3 ser-fet">      
                    <asp:LinkButton ID="btnShow_All" class="btn btn-primary" runat="server" ValidationGroup="staff"  Visible="false" OnClick="btnShow_All_Click"><i class="fa fa-search"></i> Show All</asp:LinkButton>
                </div>
           </div>
        <!-- /.box-body -->
          
      </div>
      <!-- /.box -->
               </div>
        </div>
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
        <div class="box box-info ">
            
                <div class="box-header with-border">
                    <div class="col-md-6 ser-fet">      
                        <h3 class="box-title">List of Approve and Disapprove Students</h3>
                    </div>
                    <div class="col-md-3 ser-fet"">      
                        <asp:LinkButton ID="Approve" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Approve_Click"><i class="fa fa-search"></i> Send Notification</asp:LinkButton>
                    </div>
            <div class="col-md-3 ser-fet">      
                        <asp:LinkButton ID="Disapprove" class="btn btn-primary" runat="server" ValidationGroup="staff" Visible="false"><i class="fa fa-search"></i> Disapprove</asp:LinkButton>
                    </div>
               </div>
                <!-- /.box-header -->
                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height:600px; width:100%">
                        <asp:GridView ID="gvStudent" CssClass="table table-striped table-bordered table-hover" runat="server"
                             CellPadding="3" AutoGenerateColumns="False" BackColor="White"
                             BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"  DataKeyNames="Student_Name"
                             EnableModelValidation="True" OnRowCreated="gvStudent_RowCreated" >
                            <Columns>      
                                <asp:TemplateField HeaderText="select" >
                                    <ItemTemplate>
                                        <asp:CheckBox ID="chkBxSelect" runat="server"  
                                            OnCheckedChanged="chkBxSelect__CheckedChanged" />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                                    <HeaderTemplate>
                                        <asp:CheckBox ID="chkBxHeader" onclick="javascript:HeaderClick(this);" runat="server" />
                                    </HeaderTemplate>
                                </asp:TemplateField>   
                                
                                <asp:BoundField DataField="Approuvel" HeaderText="Approuvel" ReadOnly="True"/>
                                <asp:BoundField DataField="Student_ID" HeaderText="Student ID" ReadOnly="True"/>
                                <asp:BoundField DataField="Aggregate" HeaderText="Aggregate %" ReadOnly="True"/>
                                <asp:BoundField DataField="SSC_Percentage" HeaderText="SSC %" ReadOnly="True"/>
                                <asp:BoundField DataField="HSC_Percentage" HeaderText="HSC %" ReadOnly="True"/>
                                <asp:BoundField DataField="Diploma_Percentage" HeaderText="Diploma %" ReadOnly="True"/>
                                <asp:BoundField DataField="Student_Name" HeaderText="Student Name" ReadOnly="True"/>
                                <asp:BoundField DataField="Contact_No" HeaderText="Contact No." ReadOnly="True"/>
                                <asp:BoundField DataField="Email" HeaderText="	Email" ReadOnly="True"/>
                                <asp:BoundField DataField="Department" HeaderText="Department" ReadOnly="True"/>
                                <asp:BoundField DataField="Status" HeaderText="Status" ReadOnly="True"/>
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
</asp:Content>
