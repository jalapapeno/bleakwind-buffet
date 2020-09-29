/*
* Author: Logan Peppers
* Class name: MenuButtons.xaml.cs
* Purpose: Holds the Menu Buttons interface that also includes the order.
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
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class MenuButtons : UserControl
    {
        public MenuButtons()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void AddBHBToOrder(object sender, RoutedEventArgs e)
        {
            string item = bhbButton.Content.ToString();
            orderContents.Items.Add(item);
            var bhb = new BHBCustom();
            containerBorder.Child = bhb;

        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddDDToOrder(object sender, RoutedEventArgs e)
        {
            string item = ddButton.Content.ToString();
            orderContents.Items.Add(item);
            var dd = new DDCustom();
            containerBorder.Child = dd;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddGOOToOrder(object sender, RoutedEventArgs e)
        {
            string item = gooButton.Content.ToString();
            orderContents.Items.Add(item);
            var goo = new GOOCustom();
            containerBorder.Child = goo;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddPPToOrder(object sender, RoutedEventArgs e)
        {
            string item = ppButton.Content.ToString();
            orderContents.Items.Add(item);
            var pp = new PPCustom();
            containerBorder.Child = pp;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSHSToOrder(object sender, RoutedEventArgs e)
        {
            string item = shsButton.Content.ToString();
            orderContents.Items.Add(item);
            var shs = new SHS();
            containerBorder.Child = shs;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTTToOrder(object sender, RoutedEventArgs e)
        {
            string item = ttButton.Content.ToString();
            orderContents.Items.Add(item);
            var tt = new TTTCustom();
            containerBorder.Child = tt;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTTBToOrder(object sender, RoutedEventArgs e)
        {
            string item = ttbButton.Content.ToString();
            orderContents.Items.Add(item);
            var ttb = new TTBCustom();
            containerBorder.Child = ttb;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddDWFToOrder(object sender, RoutedEventArgs e)
        {
            string item = dwfButton.Content.ToString();
            orderContents.Items.Add(item);
            var dwf = new SizeCustom();
            containerBorder.Child = dwf;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddFMToOrder(object sender, RoutedEventArgs e)
        {
            string item = fmButton.Content.ToString();
            orderContents.Items.Add(item);
            var fm = new SizeCustom();
            containerBorder.Child = fm;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddMOGToOrder(object sender, RoutedEventArgs e)
        {
            string item = mogButton.Content.ToString();
            orderContents.Items.Add(item);
            var mog = new SizeCustom();
            containerBorder.Child = mog;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddVSToOrder(object sender, RoutedEventArgs e)
        {
            string item = vsButton.Content.ToString();
            orderContents.Items.Add(item);
            var vs = new SizeCustom();
            containerBorder.Child = vs;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddAAJToOrder(object sender, RoutedEventArgs e)
        {
            string item = aajButton.Content.ToString();
            orderContents.Items.Add(item);
            var aaj = new MM_AAJCustom();
            containerBorder.Child = aaj;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddCCToOrder(object sender, RoutedEventArgs e)
        {
            string item = ccButton.Content.ToString();
            orderContents.Items.Add(item);
            var cc = new CCCustom();
            containerBorder.Child = cc;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddMMToOrder(object sender, RoutedEventArgs e)
        {
            string item = mmButton.Content.ToString();
            orderContents.Items.Add(item);
            var mm = new MM_AAJCustom();
            containerBorder.Child = mm;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddSSToOrder(object sender, RoutedEventArgs e)
        {
            string item = ssButton.Content.ToString();
            orderContents.Items.Add(item);
            var ss = new SSCustom();
            containerBorder.Child = ss;
        }
        /// <summary>
        /// Adds the item to the order and pulls up the customization window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddWWToOrder(object sender, RoutedEventArgs e)
        {
            string item = wwButton.Content.ToString();
            orderContents.Items.Add(item);
            var ww = new WWCustom();
            containerBorder.Child = ww;

        }

    }
}
