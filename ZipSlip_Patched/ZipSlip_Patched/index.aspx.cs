using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZipSlip_Patched
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadVulnerable_Click(object sender, EventArgs e)
        {
            if (FileUploadControlV.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadControlV.FileName);
                    string saveDirectory = "../../Users/Public/Passwords/File/";
                    string fileFilter = null;
                    //FileUploadControlV.SaveAs(Server.MapPath("~/File/") + filename);

                    FastZip badVulnerability = new FastZip();
                    badVulnerability.ExtractZip(filename, saveDirectory, fileFilter);

                    StatusVulnerable.InnerHtml = "File uploaded!";
                }
                catch (Exception ex)
                {
                    StatusVulnerable.InnerHtml = "The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
    }
}