using System;
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
using System.IO;

namespace WPF_Grund_2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();			
		}

		private void SaveButton_Click(object sender, RoutedEventArgs e)
		{
			FileInfo fi = new FileInfo(@"myText.txt");
			if (File.Exists(@"myText.txt"))
			{
				FileStream fs = fi.Open(FileMode.Append, FileAccess.Write, FileShare.Read);
				StreamWriter sw = new StreamWriter(fs);
				sw.WriteLine(textBoxSave.Text);
				sw.Close();
				fs.Close();
				textBoxSave.Text = "";
			}
			else
			{
				FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
				StreamWriter sw = new StreamWriter(fs);
				sw.WriteLine(textBoxSave.Text);
				sw.Close();
				fs.Close();
				textBoxSave.Text = "";
			}
		}

		private void LoadButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				FileInfo fi = new FileInfo(@"myText.txt");
				FileStream fs = fi.OpenRead();
				StreamReader sr = new StreamReader(fs);
				textBoxDisplay.Text = sr.ReadToEnd();
				sr.Close();
				fs.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Filen hittades inte!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			
		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(textBoxSave.Text != String.Empty)
			{
				SaveButton.IsEnabled = true;
			}
			if(textBoxSave.Text == String.Empty)
			{
				SaveButton.IsEnabled = false;
			}

		}

		private void EraseFile_Click(object sender, RoutedEventArgs e)
		{
			if(File.Exists(@"myText.txt"))
			{
				if(MessageBox.Show("Är du säker på att du vill radera all text?", "Varning!",
								 MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
				{
					File.WriteAllText(@"myText.txt", String.Empty);
					MessageBox.Show("Filinnehåll raderat");
					textBoxDisplay.Text = String.Empty;
				}
				else
				{
					MessageBox.Show("Inget raderat!");
				}
			}
			else
			{
				MessageBox.Show("Inget att radera...");
			}
		}
	}
}
