namespace Ejercicio3c4030349;

public partial class Promedio : ContentPage
{
	public Promedio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(C1.Text)&&!string.IsNullOrEmpty(C2.Text) && !string.IsNullOrEmpty(C3.Text) && !string.IsNullOrEmpty(C4.Text) && !string.IsNullOrEmpty(C5.Text))
		{
			int Resultado, n1, n2, n3, n4, n5;
			n1 = Convert.ToInt32(C1.Text);
			n2 = Convert.ToInt32(C2.Text);
			n3 = Convert.ToInt32(C3.Text);
			n4 = Convert.ToInt32(C4.Text);
			n5 = Convert.ToInt32(C5.Text);
			Resultado = (n1 + n2 + n3 + n4 + n5)/5;
			Result.Text = Resultado.ToString();
		}
		else
		{
			DisplayAlert("Error", "Introduce todas las calificaciones", "ok");
		}
    }
}