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
using System.Threading;
using System.Globalization;

namespace BrainiacApp
{
    /// <summary>
    /// Test5.xaml etkileşim mantığı
    /// </summary>
    public partial class Test5 : Page
    {
        private Test mainTest;
        public Test5(Test main)
        {
            InitializeComponent();
            mainTest = main;
            this.FontFamily = new FontFamily("Alata");
            setLanguage("en-Us");
        }
        public void setLanguage(String lang)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
        }
    }
}
