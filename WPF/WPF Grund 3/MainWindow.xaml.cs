﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Grund_3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<string> list = new List<string>();
		public MainWindow()
		{
			InitializeComponent();			
			emailTextBox.Text = "Type in your email...";
		}

		private void verifyButton_Click(object sender, RoutedEventArgs e)
		{
			HideInValidMessageAndBorder();
			HideValidMessageAndBorder();
			Regex reg = new Regex(@"^[a-zA-Z]\w*@\w+\.[a-zA-Z]{2,}$");

			if (reg.IsMatch(emailTextBox.Text))
			{
				ShowValidMessageAndBorder();
			}
			else
			{
				ShowInValidMessageAndBorder();
			}

			if(listBoxTries.Items.Count < 5)
			{
				listBoxTries.Items.Insert(0, emailTextBox.Text);
			}
			else
			{
				listBoxTries.Items.RemoveAt(listBoxTries.Items.Count - 1);
				listBoxTries.Items.Insert(0, emailTextBox.Text);
			}


			
		}

		private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			
		}

		private void emailTextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			
		}

		private void ShowValidMessageAndBorder()
		{
			validBorder.Visibility = Visibility.Visible;
			validEmailLabel.Visibility = Visibility.Visible;
		}
		private void ShowInValidMessageAndBorder()
		{
			InValidBorder.Visibility = Visibility.Visible;
			InValidEmailLabel.Visibility = Visibility.Visible;
		}
		private void HideValidMessageAndBorder()
		{
			validBorder.Visibility = Visibility.Hidden;
			validEmailLabel.Visibility = Visibility.Hidden;
		}
		private void HideInValidMessageAndBorder()
		{
			InValidBorder.Visibility = Visibility.Hidden;
			InValidEmailLabel.Visibility = Visibility.Hidden;
		}

		private void emailTextBox_GotMouseCapture(object sender, MouseEventArgs e)
		{
			emailTextBox.Text = String.Empty;
		}

		private void listBoxTries_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			
		}
	}
}
