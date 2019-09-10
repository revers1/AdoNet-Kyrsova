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
   
        private int c = 1;
        private bool trueansw;
            WindowLoginPanel windowlogin = new WindowLoginPanel();
        /**/

        public MainWindow()
        {
            InitializeComponent();
           

            this.Visibility = Visibility.Hidden;

            if (!this.IsVisible)
            {

            windowlogin.Show();
            }
  

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
            //listtests.Add(new Answers());

            /*Button Add*/

            string namecheck = "Checkbox" + counter.ToString();
            string nametextbox = "textboxAnswer" + counter.ToString();
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
        textboxQuestion.Text = "Введіть питання";
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
                Answers answerss1 = new Answers();
                Answers answerss2 = new Answers();
                Answers answerss3 = new Answers();
                Answers answerss4 = new Answers();
                Answers answerss5 = new Answers();

                questionss.Quastion = textboxQuestion.Text;

                answerss1.Answer = textboxAnswer1.Text;
                answerss1.Id_Question = questionss.Id;

                answerss2.Answer = textboxAnswer2.Text;
                answerss2.Id_Question = questionss.Id;

                answerss3.Answer = textboxAnswer3.Text;
                answerss3.Id_Question = questionss.Id;

                answerss4.Answer = textboxAnswer4.Text;
                answerss4.Id_Question = questionss.Id;

                answerss5.Answer = textboxAnswer5.Text;
                answerss5.Id_Question = questionss.Id;


                if (Checkbox1.IsChecked == true)
                {
                    answerss1.IsCorrect = true;
                }
                else answerss1.IsCorrect = false;
                if (Checkbox2.IsChecked == true)
                {
                    answerss2.IsCorrect = true;
                }
                else answerss2.IsCorrect = false;
                if (Checkbox3.IsChecked == true)
                {
                    answerss3.IsCorrect = true;
                }
                else answerss3.IsCorrect = false;
                if (Checkbox4.IsChecked == true)
                {
                    answerss4.IsCorrect = true;
                }
                else answerss4.IsCorrect = false;
                if (Checkbox5.IsChecked == true)
                {
                    answerss5.IsCorrect = true;
                }
                else answerss5.IsCorrect = false;
                //List<Answers> Ans = new List<Answers>() { };
                //Ans.Add(answerss1);
                //Ans.Add(answerss2);
                //Ans.Add(answerss3);
                //Ans.Add(answerss4);
                //Ans.Add(answerss5);
                if (textboxQuestion.Text != "")
                {
                    context.DbQuestions.Add(questionss);
                }
                if (textboxAnswer1.Text != "")
                {
                    context.DbAnswers.Add(answerss1);
                }
                if (textboxAnswer2.Text != "")
                {
                    context.DbAnswers.Add(answerss2);
                }
                if (textboxAnswer3.Text != "")
                {
                    context.DbAnswers.Add(answerss3);
                }
                if (textboxAnswer4.Text != "")
                {
                    context.DbAnswers.Add(answerss4);
                }
                if (textboxAnswer5.Text != "")
                {
                    context.DbAnswers.Add(answerss5);
                }

                if (textboxAnswer1.Text != "" && textboxAnswer2.Text != "" && textboxQuestion.Text != "")
                {
                    if (Checkbox1.IsChecked == true || Checkbox2.IsChecked == true || Checkbox3.IsChecked == true || Checkbox4.IsChecked == true || Checkbox5.IsChecked == true)
                    {

                        context.SaveChanges();
                        MessageBox.Show("Збережено");
                        trueansw = true;
                    }
                    else
                    { MessageBox.Show("Не вибрана жодна правильна відповідь"); trueansw = false; }
                }
                else
                    MessageBox.Show("Заповніть всі поля");


                /*визиваєм очистку*/
                if (trueansw==true)
                {
                Button_Clear_Click(null, null);

                }
            }
    }

        private void textboxQuestion_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textboxQuestion.Text=="Введіть питання")
            {
                textboxQuestion.Text = "";
            }
        }

        private void buttonexit_Click(object sender, RoutedEventArgs e)
        {

            this.Close(); 
        }
    }
}
