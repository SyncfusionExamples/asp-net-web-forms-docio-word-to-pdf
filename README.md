# Word to PDF — ASP.NET Web Forms Sample 

A minimal **ASP.NET Web Forms (C#, .NET Framework 4.8)** application that lets a user upload a Microsoft Word document (`.doc` or `.docx`) and stream a converted PDF back to the browser. Conversion is powered by **Syncfusion's DocIO** and **DocToPDFConverter** libraries.

> Built as a reference / starter sample. Open in Visual Studio 2022 and press **F5** to run.



## ✨ Features

- Single-page upload form (`MainPage.aspx`) with client-side `accept=".doc,.docx"`
- Server-side validation of file presence and extension
- In-memory conversion — no files are written to disk on the server
- Streams the resulting PDF directly to the HTTP response for download
- Uses Syncfusion v22.1.34 for ASP.NET Web Forms(`Syncfusion.DocToPDFConverter.AspNet`)


### Run

1. Open `WordtoPDF-ASP.NETWebFormsApplication.sln` in Visual Studio 2022.
2. Restore NuGet packages if prompted (`packages/` is checked in).
3. Set the web project as the startup project.
4. Press **F5** (IIS Express launches on `https://localhost:44345` by default).
5. In the Main page, choose a `.doc` or `.docx` file, click **Convert Word to PDF**, and the PDF is offered as a download.


>`⚠️This ASP.NET Web Form platform is Deprecated, you can use the same product from ASP.NET MVC platform.`

# Word to PDF — ASP.NET MVC Sample 

A minimal **ASP.NET MVC (C#, .NET Framework 4.8)** applications that lets a user upload a Microsoft Word document (`.doc` or `.docx`) and stream a converted PDF back to the browser. Conversion is powered by **Syncfusion's DocIO** and **DocToPDFConverter** libraries.

> Built as a reference / starter sample. Open in Visual Studio 2022 and press **F5** to run.

## ✨ Features

- Single-page upload form (`MainPage.aspx`) with client-side `accept=".doc,.docx"`
- Server-side validation of file presence and extension
- In-memory conversion — no files are written to disk on the server
- Streams the resulting PDF directly to the HTTP response for download
- Uses Syncfusion v34.2.6 for ASP.NET MVC(`Syncfusion.DocToPdfConverter.AspNet.Mvc5`)


### Run

1. Open `WordtoPDF-ASP.NETMVCApplication.sln` in Visual Studio 2022.
2. Restore NuGet packages if prompted (`packages/` is checked in).
3. Set the web project as the startup project.
4. Press **F5** (IIS Express launches on `https://localhost:44346` by default).
5. In the Main page, choose a `.doc` or `.docx` file, click **Convert Word to PDF**, and the PDF is offered as a download.
