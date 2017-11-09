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
using System.Net;

namespace Email_sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox3.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("you need to provide an gmail account");
                    return;
                }
                button1.Enabled = false;
                //setting up general email structure
                MailMessage message = new MailMessage();
                message.From = new MailAddress(textBox3.Text);
                message.Subject = textBox2.Text;
                message.Body = textBox5.Text;

                //accessing all the emails
                foreach (string email in textBox1.Text.Split(';'))
                {
                    message.To.Add(email);
                }

                //configuring client, Gmail
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(textBox3.Text, textBox4.Text);

                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(message);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! sending message, please check your credentials", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { button1.Enabled = true; }

        }
    }
}
