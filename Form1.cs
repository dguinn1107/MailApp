using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MailApp.Models;

namespace MailApp
{
    public partial class Form1 : Form
    {
        private List<Student> selectedStudents;

        public Form1(List<Student> students)
        {
            InitializeComponent();
            selectedStudents = students;

            // Populate the email address textbox with selected students' emails
            toTxtBox.Text = string.Join(", ", selectedStudents.Select(s => s.EmailAddress));
        }

        // Send Email method
        private void sendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var mail = new MailMessage
                {
                    From = new MailAddress("daigeona.guinn@faulkner.edu"),
                    Subject = subjectTxtBox.Text,
                    Body = bodyTxtBox.Text
                };

                foreach (var student in selectedStudents)
                {
                    mail.To.Add(student.EmailAddress);
                }

                if (!string.IsNullOrWhiteSpace(ccTxtBox.Text))
                {
                    mail.CC.Add(ccTxtBox.Text);
                }

                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential("", "hskh xwvb rzmw jssj");
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mail);
                }

                MessageBox.Show("Email sent successfully!");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("SMTP Error: " + smtpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Send SMS method
        private void sendSMSButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var student in selectedStudents)
                {
                    if (!string.IsNullOrWhiteSpace(student.CellPhoneNumber) && !string.IsNullOrWhiteSpace(student.CellPhoneCarrier))
                    {
                        var carrier = student.CellPhoneCarrier.ToLower();
                        var gateway = GetSmsGatewayForCarrier(carrier);

                        if (!string.IsNullOrEmpty(gateway))
                        {
                            var mail = new MailMessage
                            {
                                From = new MailAddress("daigeona.guinn@faulkner.edu"),
                                Subject = "",
                                Body = bodyTxtBox.Text
                            };

                            mail.To.Add(new MailAddress(student.CellPhoneNumber.Trim() + gateway,"User"));
                            //mail.Subject = "Test";
                            //mail.Sender = new MailAddress("daigeona.guinn@faulkner.edu");
                            //mail.ReplyTo = new MailAddress("daigeona.guinn@faulkner.edu");


                            using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtpClient.Credentials = new NetworkCredential("thebby7@gmail.com", "hskh xwvb rzmw jssj"); //"qxan hicp stax tuty"
                                smtpClient.EnableSsl = true;


                                smtpClient.Send(mail);
                            }
                        }
                    }
                }

                MessageBox.Show("SMS sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending SMS: " + ex.Message);
            }
        }

        private string GetSmsGatewayForCarrier(string carrier)
        {
            switch (carrier)
            {
                case "at&t":
                    return "@txt.att.net";
                case "verizon":
                    return "@vzwpix.com";
                case "tmobile":
                    return "@tmomail.net";
                case "sprint":
                    return "@messaging.sprintpcs.com";
                default:
                    MessageBox.Show("Unsupported carrier.");
                    return string.Empty;
            }
        }
    }
}
