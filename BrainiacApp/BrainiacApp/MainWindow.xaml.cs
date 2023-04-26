﻿using System;
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

namespace BrainiacApp
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        private Home Home;
        private Test Test;
        private AboutBrainiac AboutBrainiac;
        private AboutSkills AboutSkills;
        private HelpCenter HelpCenter;
        public MainWindow()
        {
            InitializeComponent();
            this.FontFamily = new FontFamily("Alata");
            Home = new Home(this);
            Test = new Test();
            AboutBrainiac = new AboutBrainiac();
            AboutSkills = new AboutSkills();
            HelpCenter = new HelpCenter();
            MainFrame.NavigationService.Navigate(Home);
        }

        public void CheckTest()
        {
            test.IsChecked = true;
        }

        public void CheckInfo()
        {
            aboutSkills.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var checkedButton = sender as RadioButton;
            if (checkedButton!=null && checkedButton.Name=="home")
            {
                MainFrame.NavigationService.Navigate(Home);
            }
            else if(checkedButton!=null && checkedButton.Name=="test")
            {
                MainFrame.NavigationService.Navigate(Test);
            }
            else if (checkedButton != null && checkedButton.Name == "aboutBrainiac")
            {
                MainFrame.NavigationService.Navigate(AboutBrainiac);
            }
            else if (checkedButton != null && checkedButton.Name == "aboutSkills")
            {
                MainFrame.NavigationService.Navigate(AboutSkills);
            }
            else if (checkedButton != null && checkedButton.Name == "helpCenter")
            {
                MainFrame.NavigationService.Navigate(HelpCenter);
            }
        }
    }
}
