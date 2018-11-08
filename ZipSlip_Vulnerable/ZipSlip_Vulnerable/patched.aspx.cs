using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZipSlip_Vulnerable
{
    public partial class patched : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadPatched_Click(object sender, EventArgs e)
        {
            if (FileUploadControlP.HasFile)
            {
                string message = "The file could not be uploaded. An error occured";
                try
                {
                    string filename = Path.GetFileName(FileUploadControlP.FileName);
                    string saveDirectory = "../../Users/Public/Passwords/File/";
                    string fileFilter = null;
                    //FileUploadControlP.SaveAs(Server.MapPath("~/File/") + filename);
                    FastZip badVulnerability = new FastZip();
                    badVulnerability.ExtractZip(filename, saveDirectory, fileFilter);

                    if (!message.Equals("The file could not be uploaded. An error occured"))
                    {
                        StatusPatched.InnerHtml = message;
                    }
                    else
                    {
                        StatusPatched.InnerHtml = "File uploaded!";
                    }
                }
                catch (Exception ex)
                {
                    StatusPatched.InnerHtml = message;
                }
            }
        }
    }
}