using System.Globalization;
using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();

        dtpck_inicio.Date = DateTime.Today;
        dtpck_termino.Date = DateTime.Today;
    }

    private async void Button_Clicked(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
                throw new Exception("Informe o nome do evento.");

            if (string.IsNullOrWhiteSpace(txt_local.Text))
                throw new Exception("Informe o local do evento.");

            if (!int.TryParse(txt_participantes.Text, out int participantes) || participantes <= 0)
                throw new Exception("Informe um número de participantes válido (maior que zero).");

            string custoTexto = (txt_custo.Text ?? "").Replace(',', '.');

            if (!double.TryParse(custoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out double custo) || custo < 0)
                throw new Exception("Informe um custo por participante válido.");

            DateTime dataInicio = dtpck_inicio.Date ?? DateTime.Today;
            DateTime dataTermino = dtpck_termino.Date ?? DateTime.Today;

            if (dataTermino < dataInicio)
                throw new Exception("A data de término não pode ser anterior à data de início.");

            Evento ev = new Evento
            {
                Nome = txt_nome.Text.Trim(),
                DataInicio = dataInicio,
                DataTermino = dataTermino,
                NumeroParticipantes = participantes,
                Local = txt_local.Text.Trim(),
                CustoPorParticipante = custo
            };

            await Navigation.PushAsync(new ResumoEvento
            {
                BindingContext = ev
            });
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }
}
