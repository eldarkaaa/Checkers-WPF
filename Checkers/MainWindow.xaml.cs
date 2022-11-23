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

namespace Checkers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool player1_move = true, player2_move=false, player1_must_attack = false, player2_must_attack = false;
        int FieldRow, FieldColumn, WhiteRow, WhiteColumn, BlackRow, BlackColumn;
        Button white = new Button();
        Button black = new Button();
        Button field = new Button();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Field_Click(object sender, EventArgs e)
        {
            field = (Button)sender;
            FieldRow = Grid.GetRow(field);
            FieldColumn = Grid.GetColumn(field);
            if (player1_move)
            {
                if (FieldColumn - WhiteColumn <= 1 && WhiteColumn - FieldColumn <= 1 && WhiteRow - FieldRow == 1) // white piece move
                {
                    Grid.SetColumn(white, FieldColumn);
                    Grid.SetRow(white, FieldRow);
                    player1_move = false;
                    player2_move = true;
                    white = null;
                }
            }
            else if (player2_move)
            {
                if (FieldColumn - BlackColumn <=1 && BlackColumn - FieldColumn <=1 && FieldRow - BlackRow == 1)  // black piece move
                {
                    Grid.SetColumn(black, FieldColumn);
                    Grid.SetRow(black, FieldRow);
                    player1_move = true;
                    player2_move = false;
                    black = null;
                }
            }
        }

        public void White_Click(object sender, EventArgs e)
        {
            if (player1_move)
            {
                white = (Button)sender;
                WhiteRow = Grid.GetRow(white);
                WhiteColumn = Grid.GetColumn(white);

            }
        }

        public void Black_Click(object sender, EventArgs e)
        {
            if (player2_move)
            {
                black = (Button)sender;
                BlackRow = Grid.GetRow(black);
                BlackColumn = Grid.GetColumn(black);
            }
        }
    }
}
