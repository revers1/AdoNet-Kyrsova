using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowLoginPanel.xaml
    /// </summary>
    public partial class WindowLoginPanel : Window
    {


        public WindowLoginPanel()
        {
            InitializeComponent();



        }

        private void textboxlogin1_GotFocus(object sender, RoutedEventArgs e)
        {

            if (textboxlogin1.Text == "Логін")
            {
                textboxlogin1.Text = "";
            }
        }

        private void textboxpassword1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textboxpassword1.Text == "Пароль")
            {
                textboxpassword1.Text = "";
            }
        }

        private void textboxlogin1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textboxlogin1.Text == "")
            {
                textboxlogin1.Text = "Логін";
            }
        }

        private void textboxpassword1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textboxpassword1.Text == "")
            {
                textboxpassword1.Text = "Пароль";
            }

        }

        private void buttonenter_Click(object sender, RoutedEventArgs e)
        {
            using (Contextik context = new Contextik())
            {



                List<MemberSchool> mb = context.DbMemberSchool.ToList();
                mb.AddRange(context.DbMemberSchool);
                foreach (var el in mb)
                {

                    if (el.Log == textboxlogin1.Text && textboxlogin1.Text == "Student")
                    {
                        if (el.Pass == textboxpassword1.Text && textboxpassword1.Text == "student1")
                        {
                            /*window student*/
                            WindowStudent Wns = new WindowStudent();
                            Wns.ShowDialog();
                            this.Close();
                            break;
                        }

                    }
                    if (el.Log == textboxlogin1.Text && textboxlogin1.Text == "Teacher")
                    {
                        if (el.Pass == textboxpassword1.Text && textboxpassword1.Text == "teacher1")
                        {
                            this.Close();


                            MainWindow Mw = new MainWindow();
                            Mw.Visibility = Visibility.Visible;
                            break;
                        }

                    }




                }
            }
        }


    }
}
