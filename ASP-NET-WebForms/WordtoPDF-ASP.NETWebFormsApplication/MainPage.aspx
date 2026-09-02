<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WordtoPDF_ASP.NETWebFormsApplication.MainPage" %>

<!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
    <title>Word to PDF Converter</title>
    <link href="<%: ResolveUrl("~/Content/bootstrap.css") %>" rel="stylesheet" type="text/css" />
    <link href="<%: ResolveUrl("~/Content/Site.css") %>" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
            <div style="margin: 150px auto; width: 50%">
                <h2 class="mb-4">Word to PDF Converter</h2>
                <div class="mb-3">
                    <label for="FileUpload1" class="form-label">Select a Word document (.doc, .docx)</label>
                    <asp:FileUpload ID="FileUpload1" runat="server" accept=".doc,.docx" CssClass="form-control" />
                </div>
                <div>
                    <asp:Button ID="Button1" runat="server" Text="Convert to PDF" OnClick="OnButtonClicked"
                        CssClass="btn btn-primary" style="width:220px;height:38px" />
                </div>
                <div class="mt-3">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </div>
            </div>
        </form>
    </body>

    </html>
