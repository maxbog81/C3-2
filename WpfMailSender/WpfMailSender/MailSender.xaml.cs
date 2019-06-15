using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmailSendService;

namespace WpfMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MailSender : Window
    {
        public MailSender()
        {
            InitializeComponent();
            cbSenderSelect.ItemsSource = VariablesClass.Senders;
            cbSenderSelect.DisplayMemberPath = "Key";
            cbSenderSelect.SelectedValuePath = "Value";
            DBclass db = new DBclass();
            dgEmails.ItemsSource = db.Emails;
            cbSmtpSelect.ItemsSource = VariablesClass.SmtpServers;
            cbSmtpSelect.DisplayMemberPath = "Key";
            cbSmtpSelect.SelectedValuePath = "Value";
        }

        private void MiClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //private void BtnClock_Click(object sender, RoutedEventArgs e)
        //{
        //    tabControl.SelectedItem = TabPlanner;

        //}

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            SchedulerClass sc = new SchedulerClass();
            TimeSpan tsSendTime = sc.GetSendTime(tbTimePicker.Text);
            if (tsSendTime == new TimeSpan())
            {
                MessageBox.Show("Некорректный формат даты");
                return;
            }
            DateTime dtSendDateTime = (cldSchedulDateTimes.SelectedDate ?? DateTime.Today).Add(tsSendTime);
            if (dtSendDateTime < DateTime.Now)
            {
                MessageBox.Show("Дата и время отправки писем не могут быть раньше, чем настоящее время");
                return;
            }
            EmailSendServiceClass emailSender = new EmailSendServiceClass(cbSenderSelect.Text, cbSenderSelect.SelectedValue.ToString(), cbSmtpSelect.Text, (int)cbSmtpSelect.SelectedValue, new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text.Trim());
            sc.SendEmails(dtSendDateTime, emailSender, (IQueryable<Email>)dgEmails.ItemsSource);

        }

        private void BtnSendAtOnce_Click(object sender, RoutedEventArgs e)
        {
            string strLogin = cbSenderSelect.Text;
            string strPassword =Convert.ToString(cbSenderSelect.SelectedValue);
            string strSmtp = cbSmtpSelect.Text;
            int iSmtpPort = Convert.ToInt32(cbSmtpSelect.SelectedValue);
            string RTB = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text.Trim();
            if (string.IsNullOrEmpty(RTB))
            {
                MessageBox.Show("Письмо не заполнено");
                tabControl.SelectedIndex = 2;
                return;
            }

            if (string.IsNullOrEmpty(strLogin))
            {
                MessageBox.Show("Выберите отправителя");
                return;
            }
            if (string.IsNullOrEmpty(strPassword))
            {
                MessageBox.Show("Укажите пароль отправителя");
                return;
            }

            EmailSendServiceClass emailSender = new EmailSendServiceClass(strLogin, strPassword, strSmtp, iSmtpPort, RTB);
            emailSender.SendMails((IQueryable<Email>)dgEmails.ItemsSource);

            SendEndWindow sew = new SendEndWindow();
            sew.ShowDialog();
        }

        private void TabSwitcherControl_btnNextClick(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

    }
}
