<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.cs" Inherits="TrainingAndPlacement.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
    <section class="content">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-6">
                <br /><br /><br />
                <div class="login-box-body">
                    <p class="login-box-msg">Sign in to start your session</p>

                    
                        <div class="form-group has-feedback">
                            <asp:TextBox class="form-control" ID="username" runat="server" placeholder="Enter Login Id"></asp:TextBox>
                            <span class="glyphicon glyphicon-user form-control-feedback"></span>
                        </div>
                        <div class="form-group has-feedback">
                            <asp:TextBox class="form-control" ID="password" runat="server" TextMode="Password" placeholder=" Enter Password"></asp:TextBox>
                            <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                        </div>
                        <div class="row" align="center">
                            <div class="checkbox icheck">
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
                            </div>
                            <div class="col-xs-8">
                                <div class="checkbox icheck">
                                    <label>
                                        <a data-toggle="modal" data-target="#change_pswd">I forgot my password <i class="fa fa-arrow-circle-right"></i></a>
                                    </label>
                                </div>
                            </div>
                            <!-- /.col -->
                            <div class="col-xs-4">
                                <asp:Button ID="btnlogin" runat="server" class="btn btn-primary btn-block btn-flat" Text="Sign In" OnClick="btnlogin_Click" />
                            </div>
                            <!-- /.col -->
                        </div>

                        <!-- /.social-auth-links -->
                        <div class="modal fade" id="change_pswd" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                            <div class="modal-dialog">
                                <div class="panel panel-danger">
                                    <div class="panel-heading">
                                        Send Password Request
                                    </div>
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <div class="col-md-5" align="right">
                                                <label>Enter User Id :</label>
                                            </div>
                                            <div class="col-md-7" align="center">
                                                <asp:TextBox class="form-control" ID="txtforgot" runat="server" placeholder="Enter User Id  *" />
                                            </div>
                                        </div>
                                        <br />
                                        <div class="form-group" align="center">
                                            <div class="col-md-6">
                                                <asp:Label ID="txterror" runat="server" ForeColor="Red" Font-Bold="True" />
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Button ID="btnfogot_request" runat="server" Text="Send Password Request" class="btn btn-danger" OnClick="btnfogot_request_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                   
                    </div>
                <!-- /.login-box-body -->
            </div>
            <div class="col-md-3"></div>
        </div>
    </section>
</asp:Content>
