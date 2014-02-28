﻿#region

using System.Windows;
using System.Windows.Controls;
using anmar.SharpMimeTools;

#endregion

namespace Rnwood.Smtp4dev.MessageInspector
{
    /// <summary>
    /// Interaction logic for EmailInspectorWindow.xaml
    /// </summary>
    public partial class InspectorWindow : Window
    {
        public InspectorWindow(SharpMimeMessage message)
        {
            InitializeComponent();
            Message = new MessageViewModel(message);
        }

        public MessageViewModel Message
        {
            get { return DataContext as MessageViewModel; }

            private set
            {
                DataContext = value;
                treeView.DataContext = new[] {Message};
                SelectedPart = Message;
            }
        }

        public MessageViewModel SelectedPart
        {
            get { return treeView.SelectedItem as MessageViewModel; }

            set { value.IsSelected = true; }
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (treeView.SelectedItem != null)
            {
                partDetailsGrid.IsEnabled = true;
            }
            else
            {
                partDetailsGrid.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SelectedPart.View();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SelectedPart.Save();
        }

        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached("Html",
            typeof (string), typeof (InspectorWindow), new FrameworkPropertyMetadata(OnHtmlChanged));

        [AttachedPropertyBrowsableForType(typeof(WebBrowser))]
        public static string GetHtml(WebBrowser d)
        {
            return (string)d.GetValue(HtmlProperty);
        }

        public static void SetHtml(WebBrowser d, string value)
        {
            d.SetValue(HtmlProperty, value);
        }

        static void OnHtmlChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var wb = d as WebBrowser;
            if (wb != null)
                wb.NavigateToString(e.NewValue as string);
        }
    }
}