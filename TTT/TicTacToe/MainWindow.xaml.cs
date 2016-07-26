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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Add a 2D char array (or string) to hold the data.  
        // Make the clicks from Grid fill a spot in the array then translate
        // it to the grid by drawing it.
        private char[ , ] _board;

        public MainWindow()
        {
            InitializeComponent();
            _board = new char[3,3];
        }

        private void LblTest_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                Label lbl = (Label) sender;

                int row = (int) lbl.GetValue(Grid.RowProperty);
                int column = (int) lbl.GetValue(Grid.ColumnProperty);

                string message = string.Format("{0}, {1}", row, column);
                MessageBox.Show(message);
            }
        }
    }
}
