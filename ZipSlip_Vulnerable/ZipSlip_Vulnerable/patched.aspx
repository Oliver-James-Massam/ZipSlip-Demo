<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="patched.aspx.cs" Inherits="ZipSlip_Vulnerable.patched" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <main role="main">
        <br />
        <br />
        <br />

        <div class="jumbotron">
            <div class="container">
                <h1 class="display-3">Zip Slip Patched</h1>
                <p>This is an example of unloading a zip file and the web server being protected against the ZipSlip vulnerability.</p>
                <form>
                    <div class="input-group-append" style="padding-bottom: 10px">
                        <asp:FileUpload class="btn btn-light" id="FileUploadControlP" runat="server" />
                    </div>
                     
                    <div class="input-group-append" style="padding-bottom: 10px">
                        <asp:Button class="btn btn-primary" runat="server" ID="UploadPatched" Text="Upload" OnClick="UploadPatched_Click" />
                    </div>

                    <div class="alert alert-primary" role="alert" runat="server">
                        <p id="StatusPatched" runat="server">Upload status</p>
                    </div>
                </form>
            </div>
        </div>

    </main>
</asp:Content>
