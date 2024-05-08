using System.Windows;
using System.Windows.Controls;

namespace Clients.Views;

public partial class OrderView : Window
{
	public OrderView()
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
	private void TextBox_TextChanged1(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb1,l1); }
	private void TextBox_TextChanged2(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb2, l2); }
	private void TextBox_TextChanged3(object sender, TextChangedEventArgs e) { TBoxTextChanged(tb3, l3); }
	private void TextBox_TextChanged4(object sender, TextChangedEventArgs e) { TBoxTextChanged(tb4, l4); }
	private void TextBox_TextChanged5(object sender, TextChangedEventArgs e) { TBoxTextChanged(tb5, l5); }
	private void TextBox_TextChanged6(object sender, TextChangedEventArgs e) { TBoxTextChanged(tb6, l6); }
	private void TextBox_TextChanged8(object sender, TextChangedEventArgs e) { TBoxTextChanged(tb8, l8); }
	private void TextBox_TextChanged7(object sender, TextChangedEventArgs e) { TBoxTextChanged(tb7, l7); }
}
