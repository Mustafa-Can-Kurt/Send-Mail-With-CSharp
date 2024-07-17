using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SendMail
{
    public partial class HomePage : Form
    {
        private Connection Connection;

        public HomePage()
        {
            InitializeComponent();
            Connection = new Connection();
        }
        #region  printing words into textboxes
        private void HomePage_Load(object sender, EventArgs e)
        {
            //In this code block, the words that should be written in the texboxes when the form is opened are written.
            TextSender.Text = "Sender";
            TextPassword.Text = "Password";
            TextBuyer.Text = "Buyer";
            TextTittle.Text = "Title";
            RichTextBody.Text = "Message";
        }
        #endregion

        #region textbox word deletion
        private void TextSender_MouseDown(object sender, MouseEventArgs e)
        {
            //This code block is for deleting the words written in textboxes when clicked with the mouse.
            TextSender.Text = "";
        }

        private void TextPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextPassword.Text = "";
        }

        private void TextBuyer_MouseDown(object sender, MouseEventArgs e)
        {
            TextBuyer.Text = "";
        }

        private void TextTittle_MouseDown(object sender, MouseEventArgs e)
        {
            TextTittle.Text = "";
        }

        private void RichTextBody_MouseDown(object sender, MouseEventArgs e)
        {
            RichTextBody.Text = "";
        }
        #endregion

        #region page redirect
        private void BtnMailScreen_Click(object sender, EventArgs e)
        {
           // Instructions are made in this code block. You will be directed to the email viewing screen.
            Interface.SelectedIndex = 1;
        }
        private void BtnSendScreen_Click(object sender, EventArgs e)
        {
           // Instructions are made in this code block. You will be directed to the email sending and viewing screen.
            Interface.SelectedIndex = 0;
        }
        #endregion

        #region exit the application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //This code block is written to terminate the application on button click event.
            Application.Exit();
        }
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region start timers
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //In this code block, it is specified which timer will be used in which situation of the panels with retractable feature.
            if (PanelMenu.Height == 240)
            {
                TimerPanelClose.Start();
            }
            else
            {
                
                TimerPanelOpen.Start();
            }
        }
        private void BtnMenu2_Click(object sender, EventArgs e)
        {

            if (PanelMenu2.Height == 240)
            {
                TimerPanelClose.Start();
            }
            else
            {

                TimerPanelOpen.Start();
            }
        }
        #endregion

        #region panel operations
        private void TimerPanelClose_Tick(object sender, EventArgs e)
        {
            //This code block allows the panel to close when the panel height is 240
            PanelMenu.Height = PanelMenu.Height - 10;
            if (PanelMenu.Height == 80)
            {
                TimerPanelClose.Stop();
            }

            PanelMenu2.Height = PanelMenu2.Height - 10;
            if (PanelMenu2.Height == 80)
            {
                TimerPanelClose.Stop();
            }
        }
       
        private void TimerPanelOpen_Tick(object sender, EventArgs e)
        {
            //This code block allows the panel to be opened when the panel height is 80
            PanelMenu.Height = PanelMenu.Height + 10;
            if (PanelMenu.Height == 240)
            {
                TimerPanelOpen.Stop();
            }
            PanelMenu2.Height = PanelMenu2.Height + 10;
            if (PanelMenu2.Height == 240)
            {
                TimerPanelOpen.Stop();
            }
        }
        #endregion

        #region e-mail sending processes
        private void BtnSend_Click(object sender, EventArgs e)
        {
            //Sending e-mail is done in this code block.
            Connection.Connect();

            string senderMail = TextSender.Text;  //Getting data from TextBox
            string password = TextPassword.Text;
            string buyerMail = TextBuyer.Text;
            string message = RichTextBody.Text;

            Connection.InsertMailInfo(senderMail, password, buyerMail, message);

            Connection.Close();

            MailMessage Message2 = new MailMessage();
            SmtpClient Client = new SmtpClient();//SMTP protocol is used to send emails.
            Client.Credentials = new System.Net.NetworkCredential(senderMail,password);
            Client.Port = 587;
            Client.Host = "smtp.live.com";//It is the address of the SMTP server used for Microsoft's services such as Outlook.com, Hotmail, and Live.com.
            //Sets the address of the SMTP (Simple Mail Transfer Protocol) server to be used by an email client.
            Client.EnableSsl = true;
            /*
              Specifies that the email client will connect to the SMTP server using a secure SSL/TLS (Secure Sockets Layer/Transport Layer Security) connection.
              This ensures data is encrypted during email sending and protects the confidentiality and integrity of the information sent.
             */
            Message2.To.Add(buyerMail);//It is used to identify recipients of an e-mail message. This code adds a new recipient to the To collection of the MailMessage object used to send email.
            Message2.From = new MailAddress(senderMail);//Determines who sent the e-mail message.
            Message2.Subject = TextTittle.Text;
            Message2.Body = message;
            Client.Send(Message2);
            //It enables the sending of e-mail messages by the SmtpClient class.
            //This code sends the MailMessage object, Message2, to the specified SMTP server.




        }
        #endregion

        #region deleting data from datagridwiev
        private void BtnMailDelete_Click(object sender, EventArgs e)
        {
            Connection.DeleteSelectedRow(dataGridView1);//To call the delete function defined in the databaseInfo class
        }
        #endregion

        #region Listing data from datagridwiev
        private void BtnShow_Click(object sender, EventArgs e)
        {
            Connection.Connect();
            //To call the SQL connection opening function defined in the databaseInfo class

            DataTable mailInfoTable = Connection.GetMailInfo();//To call the select query function defined in the DataBase Info class
            dataGridView1.DataSource = mailInfoTable;//To add information to dataGridView1

            Connection.Close();
            //To call the SQL connection closing function defined in the databaseInfo class
        }
        #endregion
    }
}
