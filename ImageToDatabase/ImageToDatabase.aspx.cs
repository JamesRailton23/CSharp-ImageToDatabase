using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace ImageToDatabase
{
    public partial class ImageToDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_file_upload_Click(object sender, EventArgs e)
        {
            file_upload();
        }

        protected void file_upload()
        {
            // Source -  https://stackoverflow.com/questions/3853767/maximum-request-length-exceeded

            usersEntities db = new usersEntities();
            if (img_file_upload.HasFile)
            {
                using (var fs = img_file_upload.PostedFile.InputStream)
                {
                    using (var br = new BinaryReader(fs))
                    {
                        var useraccount = new user_profile();
                        
                        
                        
                        byte[] newImage = br.ReadBytes((Int32)fs.Length);
                        useraccount.screenshot = newImage;

                        var dbuser = db.user_profile;

                        dbuser.Add(useraccount);
                        db.SaveChanges();



                    }
                }
            }
        }

        protected void btn_display_image_Click(object sender, EventArgs e)
        {

        }
    }
}