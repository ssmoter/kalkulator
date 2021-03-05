using System.Windows;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        MathematicalFunctions functions = new MathematicalFunctions();
        string caseSwitch;
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            if (functions.strW != null)
            {
                switch (caseSwitch)
                {
                    case "sum":
                        functions.sum(functions.getStrW());
                        functions.clearStrW();
                        break;
                    case "Difference":
                        functions.difference(functions.getStrW());
                        functions.clearStrW();

                        break;
                    case "Multiple":
                        functions.Multiple(functions.getStrW());
                        functions.clearStrW();

                        break;
                    case "Division":
                        functions.Division(functions.getStrW());
                        functions.clearStrW();

                        break;
                    case "Percent":
                        functions.percent(functions.getStrW());
                        functions.clearStrW();

                        break;
                }
            }
            Score.Content = functions.getW();
        }

        #region wyborDzialania

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "sum";
        }
        private void Difference_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Difference";
        }
        private void Multiple_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Multiple";
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Division";
        }
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Percent";
        }
        #endregion

        #region wyborLiczb

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("0");
            Score.Content = functions.getStrW();
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("1");
            Score.Content = functions.getStrW();
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("2");
            Score.Content = functions.getStrW();
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("3");
            Score.Content = functions.getStrW();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("4");
            Score.Content = functions.getStrW();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("5");
            Score.Content = functions.getStrW();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("6");
            Score.Content = functions.getStrW();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("7");
            Score.Content = functions.getStrW();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("8");
            Score.Content = functions.getStrW();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("9");
            Score.Content = functions.getStrW();
        }
        #endregion

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            functions.clearStrW();
            functions.setClearW(0);
            Score.Content = 0;
            Action.Content = 0;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW(",");
            Score.Content = functions.getStrW();
        }

        #region InneOpcje
        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            functions.setClearW(functions.Sqrt(functions.getW()));
            Score.Content = functions.getW();
            functions.clearStrW();
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            functions.setClearW(functions.Square(functions.getW()));
            Score.Content = functions.getW();
            functions.clearStrW();
        }

        private void Revers_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            functions.setClearW(functions.Revers(functions.getW()));
            Score.Content = functions.getW();
            functions.clearStrW();
        }

        private void Negate_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            functions.setClearW(functions.Negate(functions.getW()));
            Score.Content = functions.getW();
            functions.clearStrW();
        }
        #endregion

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            functions.clearStrW();
            Score.Content = 0;
            Action.Content = 0;
        }

        private void DeleteOne_Click(object sender, RoutedEventArgs e)
        {
            Score.Content = functions.delStrW();
            Action.Content = functions.getW();
        }
    }
}
