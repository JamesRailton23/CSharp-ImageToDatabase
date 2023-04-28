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
protected void PhoneMessage()
        {
            // code source - https://www.twilio.com/docs/sms

            // this is code used in Unit-6 D2 implementation of improvements


            
            var database = new HelpdeskEntities(); // creates a new instance of the database
            int userID = (int)Session["UserID"]; // gets the users ID from the session
            var userAccount = database.UserAccounts.FirstOrDefault(dbRecord => dbRecord.UserID == userID); // gets the users account from the database
            var userPhoneNumber = userAccount.PhoneNumber; // gets the users phone number from the database
            var userFirstName = userAccount.FirstName; // gets the users first name from the database
            string accountSID = ""; // 
            string authToken = "";

            TwilioClient.Init(accountSID, authToken); // initialises the twilio client
            var TextMessage = new CreateMessageOptions(new PhoneNumber("+44" + userPhoneNumber)); // creates a new message
             TextMessage.From = new PhoneNumber("+16206088321"); // sets the from number
             TextMessage.Body = $"Hi {userFirstName}!, Your ticket has been created and is now under investigation, Please Login to the system to view the ticket"; // sets the message body
             var sendMessage = MessageResource.Create(TextMessage); // sends the message
             Console.WriteLine(sendMessage.Body); // prints the message to the console



        }
        }
    }
}
