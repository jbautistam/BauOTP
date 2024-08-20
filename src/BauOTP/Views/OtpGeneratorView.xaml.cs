using System.Windows;

using Bau.Libraries.BauOTP.ViewModels.Generators;

namespace Bau.Libraries.BauOTP.Views;

/// <summary>
///		Ventana de <see cref="GeneratorViewModel"/>
/// </summary>
public partial class OtpGeneratorView : Window
{
	public OtpGeneratorView(GeneratorViewModel viewModel)
	{
		InitializeComponent();
		DataContext = ViewModel = viewModel;
		viewModel.Close += (sender, result) =>
										{
											DialogResult = result.IsAccepted;
											Close();
										};
	}

	/// <summary>
	///		Copia un código en el portapapeles
	/// </summary>
	private void CopyToClipboard(string code)
	{
		Clipboard.SetText(code);
	}


	/// <summary>
	///		ViewModel
	/// </summary>
	public GeneratorViewModel ViewModel { get; }

	private void cmdCopyHotp_Click(object sender, RoutedEventArgs e)
	{
		CopyToClipboard(ViewModel.HotpCode);
    }

	private void cmdCopyTotp_Click(object sender, RoutedEventArgs e)
	{
		CopyToClipboard(ViewModel.TotpCode);
    }
}
