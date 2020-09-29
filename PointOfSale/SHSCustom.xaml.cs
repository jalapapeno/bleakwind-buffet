/*
* Author: Logan Peppers
* Class name: SHSCustom.xaml.cs
* Purpose: Holds the Smokehouse Skeleton custom menu.
*/
using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SHS.xaml
    /// </summary>
    public partial class SHS : UserControl
    {
        public SHS()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hides the menu when you press done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Done(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

        }
    }
}
