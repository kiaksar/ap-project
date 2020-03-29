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

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int noteHeightChangedCnt = 0;
        int equationHeightChangedCnt = 0;
        public MainWindow()
        {
            InitializeComponent();
            MainWin.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            TabCtrl.SelectedItem = InfoTab;
        }
        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            CityOneCH.IsChecked = false;
            CityTwoCH.IsChecked = false;
            CityThreeCH.IsChecked = false;
            SaveButton.IsEnabled = false;
            ResetButton.IsEnabled = false;
        }
        private void CityOneCH_Checked(object sender, RoutedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
            ChooseOneCH.IsEnabled = true;
        }
        private void CityOneCH_Unchecked(object sender, RoutedEventArgs e)
        {
            ChooseOneCH.IsChecked = false;
            ChooseOneCH.IsEnabled = false;
        }
        private void ChooseOneCH_Checked(object sender, RoutedEventArgs e)
        {
            CityOneCombo.IsEnabled = true;
        }
        private void ChooseOneCH_Unchecked(object sender, RoutedEventArgs e)
        {
            CityOneCombo.Text = "";
            CityOneCombo.IsEnabled = false;
        }
        private void CityTwoCH_Checked(object sender, RoutedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
            ChooseTwoCH.IsEnabled = true;
        }
        private void CityTwoCH_Unchecked(object sender, RoutedEventArgs e)
        {
            ChooseTwoCH.IsChecked = false;
            ChooseTwoCH.IsEnabled = false;
        }
        private void ChooseTwoCH_Checked(object sender, RoutedEventArgs e)
        {
            CityTwoCombo.IsEnabled = true;
        }
        private void ChooseTwoCH_Unchecked(object sender, RoutedEventArgs e)
        {
            CityOneCombo.Text = "";
            CityTwoCombo.IsEnabled = false;
        }
        private void CityThreeCH_Checked(object sender, RoutedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
            ChooseThreeCH.IsEnabled = true;
        }
        private void CityThreeCH_Unchecked(object sender, RoutedEventArgs e)
        {
            ChooseThreeCH.IsChecked = false;
            ChooseThreeCH.IsEnabled = false;
        }
        private void ChooseThreeCH_Checked(object sender, RoutedEventArgs e)
        {
            CityThreeCombo.IsEnabled = true;
        }
        private void ChooseThreeCH_Unchecked(object sender, RoutedEventArgs e)
        {
            CityOneCombo.Text = "";
            CityThreeCombo.IsEnabled = false;
        }
        private void NoteBox_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (equationHeightChangedCnt == 0)
            {
                MainWin.Height += 30;
                MainWin.Top -= 15;
                noteHeightChangedCnt++;
            }
            else if (equationHeightChangedCnt == 1)
            {
                MainWin.Height += 30;
                MainWin.Top -= 15;
                noteHeightChangedCnt++;
            }
            else
            {
                equationHeightChangedCnt--;
            }
        }
        private void EquationBox_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (noteHeightChangedCnt == 0)
            {
                MainWin.Height += 30;
                MainWin.Top -= 15;
                equationHeightChangedCnt++;
            }
            else if (noteHeightChangedCnt == 1)
            {
                MainWin.Height += 30;
                MainWin.Top -= 15;
                equationHeightChangedCnt++;
            }
            else
            {
                noteHeightChangedCnt--;
            }
        }
        private void NoteBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
        }

        private void FNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
        }

        private void LNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
        }

        private void AgeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
        }

        private void EquationBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveButton.IsEnabled = true;
            ResetButton.IsEnabled = true;
        }

    }
}