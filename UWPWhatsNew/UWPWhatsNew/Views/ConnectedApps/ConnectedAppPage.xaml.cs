﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPWhatsNew.Views.ConnectedApps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConnectedAppPage : Page
    {

        #region ViewModel

        /// <summary>
        /// ViewModel Dependency Property
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(ConnectedAppViewModel), typeof(ConnectedAppPage),
                new PropertyMetadata((ConnectedAppViewModel)null));

        /// <summary>
        /// Gets or sets the ViewModel property. This dependency property 
        /// indicates ....
        /// </summary>
        public ConnectedAppViewModel ViewModel
        {
            get { return (ConnectedAppViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        #endregion
        

        public ConnectedAppPage()
        {
            this.InitializeComponent();
            ViewModel = DataContext as ConnectedAppViewModel;
        }

        private void OnLaunchUriClicked(object sender, RoutedEventArgs e)
        {
            ViewModel.LaunchUriAsync();
        }

        private void OnLaunchUriRAZClicked(object sender, RoutedEventArgs e)
        {
            ViewModel.ResetLaunchUri();
        }
    }
}