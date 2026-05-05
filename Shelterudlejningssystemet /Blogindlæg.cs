namespace Shelterudlejningssystemet;

public class Blogindlæg
{
    private int _indlægId;
    private string _title = "";
    private string _tekst = "";
    private DateTime _dato;

    public int IndlægId
    {
        get => _indlægId;
        set => _indlægId = value;
    }

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public string Tekst
    {
        get => _tekst;
        set => _tekst = value;
    }

    public DateTime Dato
    {
        get => _dato;
        set => _dato = value;
    }
}