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
    public partial class patched : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadPatched_Click(object sender, EventArgs e)
        {
            if (FileUploadControlP.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadControlP.FileName);
                    string saveDirectory = "../../Users/Public/Passwords/File/";
                    string fileFilter = null;
                    //FileUploadControlP.SaveAs(Server.MapPath("~/File/") + filename);
                    FastZip goodPatch = new FastZip();
                    goodPatch.ExtractZip(filename, saveDirectory, fileFilter);
                    
                    StatusPatched.InnerHtml = "File uploaded!";
                }
                catch (Exception ex)
                {
                    StatusPatched.InnerHtml = ex.Message;
                }
            }
        }
    }
}