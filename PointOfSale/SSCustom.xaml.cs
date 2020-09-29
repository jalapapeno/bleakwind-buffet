/*
* Author: Logan Peppers
* Class name: SSCustom.xaml.cs
* Purpose: Holds the Sailor Soda custom menu.
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
    /// Interaction logic for SSCustom.xaml
    /// </summary>
    public partial class SSCustom : UserControl
    {
        public SSCustom()
        {
            InitializeComponent();
        }
        void Done(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

        }
    }
}
