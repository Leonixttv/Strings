namespace Corbelli.Leonardo._3i.MauiStrings;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    int Lenght(string TextIn)
    {
        char[] caratteri = TextIn.ToCharArray();
        int retVal = 0;

        foreach (char c in caratteri)
            retVal++;

        return retVal;
    }

    string Maiuscolo(string stringain)
    {
        char[] txtCharArray = stringain.ToCharArray();

        for (int i = 0; i < Lenght(stringain); i++)
            if ((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z'))
            {
                int charInt = (int)txtCharArray[i] & 0x5f;
                txtCharArray[i] = (char)charInt;
            }

        return new string(txtCharArray);
    }

    string Minuscolo(string stringain)
    {
        char[] txtCharArray = stringain.ToCharArray();

        for (int i = 0; i < Lenght(stringain); i++)
            if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z'))
            {
                int cInt = (int)txtCharArray[i] | 0x20;
                txtCharArray[i] = (char)cInt;

            }

        return new string(txtCharArray);
    }

    bool Sololettere(string stringain)
    {
        char[] txtCharArray = stringain.ToCharArray();

        for (int i = 0; i < Lenght(stringain); i++)
            if (!((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z') ||
               (txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z')))
                return false;

        return true;

    }

    bool Alfanumerici(string stringain)
    {
        char[] txtCharArray = stringain.ToCharArray();

        for (int i = 0; i < Lenght(stringain); i++)
            if (!((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z') ||
               (txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z') ||
               (txtCharArray[i] >= '1') && (txtCharArray[i] <= '9')))

                return false;

        return true;
    }

    string Incontrario(string stringain)
    {
        char[] txtCharArray = stringain.ToCharArray();
        char[] txtCharArrayReverse = new char[Lenght(stringain)];


        for (int i = 0; i < Lenght(stringain); i++)
        {
            txtCharArrayReverse[i] = (char)txtCharArray[Lenght(stringain) - i - 1];
        }

        return new string(txtCharArrayReverse);
    }

    string quantelettere(string stringin)
    {
        return stringin; 
    }

    private void stringabtn(object sender, EventArgs e)
	{
        stringaout.Text =
           $"Maiuscolo: {Maiuscolo(stringain.Text)} \n" +
           $"Minuscolo: {Minuscolo(stringain.Text)} \n" +
           $"solo lettere: {Sololettere(stringain.Text)} \n" +
           $"alfa numerico: {Alfanumerici(stringain.Text)} \n" +
           $"all'incontrario: {Incontrario(stringain.Text)} \n" +
           $"quante parole ci sono: {quantelettere(stringain.Text)} \n";

    }

}

