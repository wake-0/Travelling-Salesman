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

namespace TravellingSalesman.Views
{
    /// <summary>
    /// Interaktionslogik für PointsListView.xaml
    /// </summary>
    public partial class PointsListView : UserControl
    {
        public PointsListView()
        {
            InitializeComponent();

            xPos.PreviewTextInput += NumberPreviewTextInput;
            yPos.PreviewTextInput += NumberPreviewTextInput;
        }

        private void NumberPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // TODO: Check does already contain the point

            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
