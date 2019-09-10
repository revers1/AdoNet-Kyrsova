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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowStudent.xaml
    /// </summary>
    public partial class WindowStudent : Window
    {
        List<ForStudent> listtests = new List<ForStudent>();
        List<ForStudent> checkontrues = new List<ForStudent>();
        private int counter = 3;
        public int currenttest = -1;
        public int mark = 0;
        public WindowStudent()
        {
            InitializeComponent();
            buttonleft.Content = "<-";
            buttonright.Content = "->";

            //using (Contextik context=new Contextik())
            //{
            //    foreach (var item in context.DbQuestions)
            //    {
            //        listtests[0].Question = item.Quastion;
                  
            //    }
            //    //foreach (var item in context.DbAnswers)
            //    //{
            //    //    listtests[0].Answer1 = item.Answer;
            //    //}
            //    //this.DataContext = listtests[0];
            //}

        }

        private void Buttonright_Click(object sender, RoutedEventArgs e)
        {

            if (currenttest == -1)
            {
                this.DataContext = listtests.FirstOrDefault();
                currenttest = 0;

            }
            else if (currenttest == 0)
            {
                this.DataContext = listtests.LastOrDefault();
                currenttest = listtests.Count - 1;

            }
            else
            {
                this.DataContext = listtests[currenttest-- - 1];
            }
        }

        private void buttonleft_Click(object sender, RoutedEventArgs e)
        {

            if (currenttest == -1 || currenttest == listtests.Count - 1)
            {
                this.DataContext = listtests.FirstOrDefault();
                currenttest = 0;
            }
            else
            {
                this.DataContext = listtests[++currenttest];
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Buttonfinish_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listtests.Count; i++)
            {
                //вылетает
                if (listtests[i].IsCorrect1 == true && checkontrues[i].IsCorrect1 == true)
                {
                    mark += 5;
                }
                if (listtests[i].IsCorrect2 == true && checkontrues[i].IsCorrect2 == true)
                {
                    mark += 5;
                }
                if (listtests[i].IsCorrect3 == true && checkontrues[i].IsCorrect3 == true)
                {
                    mark += 5;
                }
                if (listtests[i].IsCorrect4 == true && checkontrues[i].IsCorrect4 == true)
                {
                    mark += 5;
                }
                if (listtests[i].IsCorrect5 == true && checkontrues[i].IsCorrect5 == true)
                {
                    mark += 5;
                }

            }
        }

            private void buttonexit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
