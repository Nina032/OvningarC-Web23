using System.Text;
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
        #region Private Members
        /// <summary>
        /// Håller befintliga results som finns i rutan under en aktiv spel
        /// </summary>
        private MarkType[] mResult;
        /// <summary>
        /// player1 eller player 2
        /// </summary>
        private bool mPlayer1Turn;
        /// <summary>
        /// Spelet är avslutad
        /// </summary>
        private bool mGameEnded;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            //Skapa ett tom array för "free" rutan
            mResult = new MarkType[9];
            for (var i = 0; i< mResult.Length; i++)
            {
                mResult[i] = MarkType.Free;
            }

            //Player 1 ska starta spelet
            mPlayer1Turn = true;

            Container.Children.Cast<Button>().ToList().ForEach(button =>
            { 
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            
            });

            //Spelet är inte avslutad
            mGameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Start ny spel om spelet är avslutad
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            var button = (Button)sender;

            //Hitta knapp position i array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            //Inga ändringar i cells som innehåller data
            if (mResult[index] != MarkType.Free)
                return;

            //Ändra värde för cell baserad på spelaren
            mResult[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;

            //Ändra button text för resultat
            button.Content = mPlayer1Turn ? "X" : "O";

            //Ändra O till röd
            if (!mPlayer1Turn)
                button.Foreground = Brushes.Red;

            //Växla mellan spelare
            mPlayer1Turn ^= true;

            //Kontrollera vinnaren

        }
    }
}