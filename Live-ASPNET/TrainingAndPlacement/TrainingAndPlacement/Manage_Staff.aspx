<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Principal.Master" CodeBehind="Manage_Staff.aspx.cs" Inherits="TrainingAndPlacement.Manage_Staff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script type="text/javascript">
         var TotalChkBx;
         var Counter;

         window.onload = function () {
             //Get total no. of CheckBoxes in side the GridView.
             TotalChkBx = parseInt('<%= this.gvManageStaff.Rows.Count %>');

             //Get total no. of checked CheckBoxes in side the GridView.
             Counter = 0;
         }

         function HeaderClick(CheckBox) {
             //Get target base & child control.
             var TargetBaseControl = document.getElementById('<%= this.gvManageStaff.ClientID %>');
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
        Manage Staff
        <small>Information</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="Coordinator_Profile.aspx"><i class="fa fa-home"></i> Home</a></li>
        <li><a href="Deactiveted.aspx">Manage Staff</a></li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
            <div class="col-md-2"></div>
        <div class="col-md-8">
        <div class="box box-default">
            <div class="box-header with-border">

                            <div class="col-md-8 ">
                               <div class="input-group">
                                    <div class="input-group-btn">
                                        <button type="button" class="btn btn-danger">Select Staff: </button>
                                    </div>
                                    <asp:DropDownList ID="ddlStaff" runat="server" class="form-control">
                                         <asp:ListItem>Select All Staff</asp:ListItem>
                                        <asp:ListItem Value="Admin">TPO</asp:ListItem>    
                                        <asp:ListItem Value="HOD">HOD</asp:ListItem>
                                         <asp:ListItem Value="Coordinator">Coordinator</asp:ListItem>
                                              
                                     </asp:DropDownList>
                                </div>
                            </div>
                    <div class="col-md-4 ser-fet">      
                        <asp:LinkButton ID="Search" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Search_Click"><i class="fa fa-search"></i> Show Staff </asp:LinkButton>
                    </div>
         </div>
      <!-- /.box -->
               </div>
        </div>
            <div class="col-md-2"></div>
        <div class="col-md-12">
        
        <div class="box box-info ">
            
                <div class="box-header with-border">
                    <div class="col-md-9 ser-fet">      
                        <h3 class="box-title">Staff List</h3>
                    </div>
                    <div class="col-md-3 ser-fet"">      
                        <asp:LinkButton ID="Approve" class="btn btn-primary" runat="server" ValidationGroup="staff" OnClick="Approve_Click"><i class="fa fa-search"></i> Send Notification</asp:LinkButton>
                    </div>
               </div>
                <!-- /.box-header -->
                <div class="box-body" align="center" style="font-family: Source Sans Pro; overflow-x: scroll; height:600px; width:100%">
                        <asp:GridView ID="gvManageStaff" CssClass="table table-striped table-bordered table-hover" runat="server"
                             CellPadding="3" AutoGenerateColumns="False" BackColor="White"
                             BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"  DataKeyNames="emp_id"
                             EnableModelValidation="True" OnRowCreated="gvManageStaff_RowCreated" >
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
                                
                                <asp:BoundField DataField="Department" HeaderText="Department" ReadOnly="True"/>
                                <asp:BoundField DataField="Designation" HeaderText="Designation" ReadOnly="True"/>
                                <asp:BoundField DataField="Joining_Date" HeaderText="Joining_Date" ReadOnly="True"/>
                                <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True"/>
                                <asp:BoundField DataField="contact" HeaderText="contact" ReadOnly="True"/>
                                <asp:BoundField DataField="fnm" HeaderText="fnm" ReadOnly="True"/>
                                <asp:BoundField DataField="mnm" HeaderText="mnm" ReadOnly="True"/>
                                <asp:BoundField DataField="lnm" HeaderText="lnm " ReadOnly="True"/>
                                <asp:BoundField DataField="id_proof" HeaderText="id_proof " ReadOnly="True"/>
                                <asp:BoundField DataField="id_no" HeaderText="id_no" ReadOnly="True"/>
                                <asp:BoundField DataField="dob" HeaderText="dob " ReadOnly="True"/>
                                <asp:BoundField DataField="city" HeaderText="city" ReadOnly="True"/>
                                <asp:BoundField DataField="state" HeaderText="state" ReadOnly="True"/>
                                <asp:BoundField DataField="pin" HeaderText="pin" ReadOnly="True"/>
                                <asp:BoundField DataField="address" HeaderText="address" ReadOnly="True"/>
                                <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True"/>
                                <asp:BoundField DataField="status" HeaderText="status" ReadOnly="True"/>

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
