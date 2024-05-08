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
using System.Windows.Shapes;

namespace Clients.Views
{
	/// <summary>
	/// Interaction logic for RegisterView.xaml
	/// </summary>
	public partial class RegisterView : Window
	{
		public RegisterView()
		{
			InitializeComponent();
		}

		private void TBoxTextChanged(TextBox tbObj, Label placeholderLabel)
		{
			if (tbObj.Text != "")
				placeholderLabel.Visibility = Visibility.Hidden;
			else
				placeholderLabel.Visibility = Visibility.Visible;
		}
		private void TextBox_TextChanged1(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb1, l1); }
		private void TextBox_TextChanged2(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb2, l2); }
		private void TextBox_TextChanged3(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb3, l3); }
		private void TextBox_TextChanged4(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb4, l4); }
		private void TextBox_TextChanged5(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb5, l5); }
		private void TextBox_TextChanged6(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb6, l6); }
		private void TextBox_TextChanged7(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb7, l7); }
		private void TextBox_TextChanged8(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb8, l8); }
		private void TextBox_TextChanged9(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb9, l9); }
	}
}
