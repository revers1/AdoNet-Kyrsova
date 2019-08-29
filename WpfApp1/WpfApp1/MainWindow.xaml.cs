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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 1;
        public int currenttest = -1;

        public MainWindow()
        {
            InitializeComponent();
            Button_Left.Content = "<-";
            Button_Right.Content = "->";



        }

        private void Button_Right_Click(object sender, RoutedEventArgs e)
        {
            //using (Contextik context = new Contextik())
            //{

            //    if (currenttest == -1)
            //    {
            //        this.DataContext = listtests.FirstOrDefault();
            //        currenttest = 0;

            //    }
            //    else if (currenttest == 0)
            //    {
            //        this.DataContext = listtests.LastOrDefault();
            //        currenttest = listtests.Count - 1;

            //    }
            //    else
            //    {
            //        this.DataContext = listtests[currenttest-- - 1];
            //    }
            //}
        }

        private void Button_Left_Click(object sender, RoutedEventArgs e)
        {
            //if (currenttest == -1 || currenttest == listtests.Count - 1)
            //{
            //    this.DataContext = listtests.FirstOrDefault();
            //    currenttest = 0;
            //}
            //else
            //{
            //    this.DataContext = listtests[++currenttest];
            //}
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            /*Button Add*/

            //string namecheck = "Checkbox" + counter.ToString();
            //string nametextbox = "textboxAnswer" + counter.ToString();
            if (/*namecheck == "Checkbox3" && nametextbox == "textboxAnswer3"&&*/counter == 1 && !textboxAnswer3.IsVisible)
            {
                Checkbox3.Visibility = Visibility.Visible;
                textboxAnswer3.Visibility = Visibility.Visible;
                counter++;


            }
            else if (/*namecheck == " Checkbox4" && nametextbox == "textboxAnswer4"&&*/counter == 2 && !textboxAnswer4.IsVisible)
            {
                Checkbox4.Visibility = Visibility.Visible;
                textboxAnswer4.Visibility = Visibility.Visible;
                counter++;
            }
            else if (/*namecheck == " Checkbox5" && nametextbox == "textboxAnswer5"&&*/ counter == 3 && !textboxAnswer5.IsVisible)
            {
                Checkbox5.Visibility = Visibility.Visible;
                textboxAnswer5.Visibility = Visibility.Visible;

                counter = 1;
            }


        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            counter = 1;
            textboxAnswer1.Text = "";
            textboxAnswer2.Text = "";
            textboxAnswer3.Text = "";
            textboxAnswer4.Text = "";
            textboxQuestion.Text = "";
            textboxAnswer5.Text = "";



            Checkbox1.IsChecked = false;
            Checkbox2.IsChecked = false;
            Checkbox3.IsChecked = false;
            Checkbox4.IsChecked = false;
            Checkbox5.IsChecked = false;


            /**/

            textboxAnswer3.Visibility = Visibility.Hidden;
            Checkbox3.Visibility = Visibility.Hidden;


            textboxAnswer4.Visibility = Visibility.Hidden;
            Checkbox4.Visibility = Visibility.Hidden;


            textboxAnswer5.Visibility = Visibility.Hidden;
            Checkbox5.Visibility = Visibility.Hidden;

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            using (Contextik context = new Contextik())
            /**/
            {
                Questions questionss = new Questions();
                Answers answerss = new Answers();
                Answers answerss2 = new Answers();
                questionss.Quastion = textboxQuestion.Text;
                answerss.Answer = textboxAnswer1.Text;
                answerss.Id_Question = questionss.Id;
                answerss2.Answer= textboxAnswer2.Text;
                answerss2.Id_Question = questionss.Id;

                if (Checkbox1.IsChecked == true)
                {
                   answerss.IsCorrect = true;
                }
                //if (Check2.IsChecked == true)
                //{
                //    test.Checksecond = true;
                //}
                //if (Check3.IsChecked == true)
                //{
                //    test.Checkthird = true;
                //}
                //if (Check4.IsChecked == true)
                //{
                //    test.Checkfourth = true;
                //}
                //if (Check5.IsChecked == true)
                //{
                //    test.Checkfifth = true;
                //}

                ///**/

                //if (Textbox3.IsVisible == true)
                //{
                //    test.Thirdask = Textbox3.Text;
                //}
                //if (Textbox4.IsVisible == true)
                //{
                //    test.Fourthask = Textbox4.Text;
                //}
                //if (Textbox5.IsVisible == true)
                //{
                //    test.Fifthask = Textbox5.Text;
                //}

                //listtests.Add(test);

                /**/
            }
        }
    }
}
