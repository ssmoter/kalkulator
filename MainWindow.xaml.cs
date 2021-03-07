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
                        functions.sum( functions.getStrW());
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
                }
            }
            Score.Content = functions.getW();
        }

        #region wyborDzialania

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "sum";
            functions.Data("+");
            Action.Content = functions.strData;

        }
        private void Difference_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Difference";
            functions.Data("-");
            Action.Content = functions.strData;

        }
        private void Multiple_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Multiple";
            functions.Data("*");
            Action.Content = functions.strData;

        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            caseSwitch = "Division";
            functions.Data("/");
            Action.Content = functions.strData;

        }
        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            functions.setW();
            functions.Percent(true);
            functions.Data("%");
            Action.Content = functions.strData;

        }
        #endregion

        #region wyborLiczb

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("0");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("1");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("2");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("3");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("4");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("5");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("6");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("7");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("8");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW("9");
            Score.Content = functions.getStrW();
            Action.Content = functions.strData;
        }
        #endregion

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
        private void Point_Click(object sender, RoutedEventArgs e)
        {
            functions.setStrW(",");
            Score.Content = functions.getStrW();
        }
        #endregion

        #region Delete
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            functions.clearStrW();
            Score.Content = 0;
        }

        private void DeleteOne_Click(object sender, RoutedEventArgs e)
        {
            if (functions.strW != null)
            {
                Score.Content = functions.delStrWPlus();
                Action.Content = functions.getW();
            }
        }
        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            functions.clearStrW();
            functions.setClearW(0);
            Score.Content = 0;
            Action.Content = 0;
            functions.strData = null;

        }
        #endregion
    }
}
