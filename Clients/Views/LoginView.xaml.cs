using System.Windows;
using System.Windows.Controls;

namespace Clients.Views;

public partial class LoginView : Window
{
	public LoginView()
	{
		InitializeComponent();
		DataContext=this;
	}

	private void TBoxTextChanged(TextBox tbObj, Label placeholderLabel)
	{
		if (tbObj.Text != "")
			placeholderLabel.Visibility = Visibility.Hidden;
		else
			placeholderLabel.Visibility = Visibility.Visible;
	}
	private void TBoxTextChanged1(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb1, txtPlaceholder1); }
	private void TBoxTextChanged2(Object sender, TextChangedEventArgs e) { TBoxTextChanged(tb2, txtPlaceholder2); }
}
