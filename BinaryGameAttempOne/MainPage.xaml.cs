using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BinaryGameAttempOne
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int score = 0;
        private int[] userBitValue;
        private string consoleBit = null, userBit = null;
        private double randomDecimal;

        public MainPage()
        {
            this.InitializeComponent();
            setTogglesDisabled();
        }
        private void checkBits()
        {
            bool status = false;
            userBit = userBinaryRep(userBitValue);
            if (userBit.Equals(consoleBit))
            {
                status = true;
            }
            else
            {
                status = false;
            }

            debug.Text = userBit +" "+ status + " " + consoleBit;

            if (status)
            {
                setScore();
                setRandomDecimal();
                setToggleUnchecked();
                
            }
        }
        private string userBinaryRep(int[] a)
        {
            string s="";
            for (int i = (a.Length - 1) ; i >= 0; i--)
                s += a[i];
            return s;
        }
        private void initializeArrays()
        {
            for (int i = 0; i < userBitValue.Length; i++)
            {
                userBitValue[i] = 0;
            }

        }
        private void setScore()
        {
            score += (int)(randomDecimal * .05);
                //score = (int)((randomDecimal * .05) * 2);

            UserScore.Text = ""+score;
        }
        private void setRandomDecimal()
        {
            DecimalDisplay.Text = ""+getRandomDecimal();
        }
        private void setTogglesEnabled()
        {
            bitZero.IsEnabled = true;
            bitOne.IsEnabled = true;
            bitTwo.IsEnabled = true;
            bitThree.IsEnabled = true;
            bitFour.IsEnabled = true;
            bitFive.IsEnabled = true;
            bitSix.IsEnabled = true;
            bitSeven.IsEnabled = true;
        }
        private void setTogglesDisabled()
        {
            bitZero.IsEnabled = false;
            bitOne.IsEnabled = false;
            bitTwo.IsEnabled = false;
            bitThree.IsEnabled = false;
            bitFour.IsEnabled = false;
            bitFive.IsEnabled = false;
            bitSix.IsEnabled = false;
            bitSeven.IsEnabled = false;
        }
        private void setToggleUnchecked()
        {
            bitZero.IsChecked = false;
            bitOne.IsChecked = false;
            bitTwo.IsChecked = false;
            bitThree.IsChecked = false;
            bitFour.IsChecked = false;
            bitFive.IsChecked = false;
            bitSix.IsChecked = false;
            bitSeven.IsChecked = false;
        }
        private void setToggleChecked()
        {
            bitZero.IsChecked = true;
            bitOne.IsChecked = true;
            bitTwo.IsChecked = true;
            bitThree.IsChecked = true;
            bitFour.IsChecked = true;
            bitFive.IsChecked = true;
            bitSix.IsChecked = true;
            bitSeven.IsChecked = true;
        }
        private int getRandomDecimal()
        {
            Random r = new Random();
            consoleBit = "";
            randomDecimal = r.NextDouble() * 254 + 1;
            if (randomDecimal > 64 && randomDecimal < 128)
                consoleBit += "0";
            else if ((randomDecimal < 64) && (randomDecimal > 32))
                consoleBit += "00";
            else if ((randomDecimal > 16) && (randomDecimal < 32))
                consoleBit += "000";
            else if ((randomDecimal < 16) && (randomDecimal > 8))
                consoleBit += "0000";
            else if ((randomDecimal > 4) && (randomDecimal < 8))
                consoleBit += "00000";
            else if ((randomDecimal < 4) && (randomDecimal >2))
                consoleBit += "000000";
            else if ((randomDecimal == 1))
                consoleBit += "0000000";

            var binaryDec = Convert.ToString((int)randomDecimal, 2);
            consoleBit += binaryDec;
            return (int)randomDecimal;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.Visibility = Visibility.Collapsed;
            userBitValue = new int[8];
            initializeArrays();
            setTogglesEnabled();
            setToggleChecked();
            setToggleUnchecked();
            setRandomDecimal();

        }
        //Unchecked Events for all bits, Needs value computations
        private void bitZero_Unchecked(object sender, RoutedEventArgs e)
        {
            bitZero.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitZero.Content = "0";
            userBitValue[0] = 0;
            checkBits();
        }

        private void bitOne_Unchecked(object sender, RoutedEventArgs e)
        {
            bitOne.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitOne.Content = "0";
            userBitValue[1] = 0;
            checkBits();
        }

        private void bitTwo_Unchecked(object sender, RoutedEventArgs e)
        {
            bitTwo.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitTwo.Content = "0";
            userBitValue[2] = 0;
            checkBits();
        }

        private void bitThree_Unchecked(object sender, RoutedEventArgs e)
        {
            bitThree.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitThree.Content = "0";
            userBitValue[3] = 0;
            checkBits();
        }

        private void bitFour_Unchecked(object sender, RoutedEventArgs e)
        {
            bitFour.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitFour.Content = "0";
            userBitValue[4] = 0;
            checkBits();
        }

        private void bitFive_Unchecked(object sender, RoutedEventArgs e)
        {
            bitFive.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitFive.Content = "0";
            userBitValue[5] = 0;
            checkBits();
        }

        private void bitSix_Unchecked(object sender, RoutedEventArgs e)
        {
            bitSix.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitSix.Content = "0";
            userBitValue[6] = 0;
            checkBits();
        }

        private void bitSeven_Unchecked(object sender, RoutedEventArgs e)
        {
            bitSeven.Background = new SolidColorBrush(Windows.UI.Colors.White);
            bitSeven.Content = "0";
            userBitValue[7] = 0;
            checkBits();
        }
        //Checked events for bits, needs computational values
        private void bitZero_Checked(object sender, RoutedEventArgs e)
        {
            bitZero.Content = "1";
            userBitValue[0] = 1;
            checkBits();
        }

        private void bitOne_Checked(object sender, RoutedEventArgs e)
        {
            bitOne.Content = "1";
            userBitValue[1] = 1;
            checkBits();
        }

        private void bitTwo_Checked(object sender, RoutedEventArgs e)
        {
            bitTwo.Content = "1";
            userBitValue[2] = 1;
            checkBits();
        }

        private void bitThree_Checked(object sender, RoutedEventArgs e)
        {
            bitThree.Content = "1";
            userBitValue[3] = 1;
            checkBits();
        }

        private void bitFour_Checked(object sender, RoutedEventArgs e)
        {
            bitFour.Content = "1";
            userBitValue[4] = 1;
            checkBits();
        }

        private void bitFive_Checked(object sender, RoutedEventArgs e)
        {
            bitFive.Content = "1";
            userBitValue[5] = 1;
            checkBits();
        }

        private void bitSix_Checked(object sender, RoutedEventArgs e)
        {
            bitSix.Content = "1";
            userBitValue[6] = 1;
            checkBits();
        }

        private void bitSeven_Checked(object sender, RoutedEventArgs e)
        {
            bitSeven.Content = "1";
            userBitValue[7] = 1;
            checkBits();
        }
        //End of Content
    }
}
/**
 * When time is implemented, time will play a huge roll in scoring
 * When a user solves a problem in less that 5 seconds they get double points
 * When they solve 5 problems in less than 20 seconds the score multiplier goes up
 * To be continued...
 * 
 * 
 * 
 * When time runs out tell user whether they accumulated bytes megabyte giga and what not
 * user score is calculated by level of number ex 2^(highest power of number solved)
 * multiplied by 2 if solved within 5 seconds
 * **/
