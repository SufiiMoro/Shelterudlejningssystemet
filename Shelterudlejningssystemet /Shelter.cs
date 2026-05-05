namespace Shelterudlejningssystemet;

public class Shelter
{
    private int _shelterId;
    private string _navn = "";
    private int _lokation;
    private int _kapacitet;

    // Properties
    public int ShelterId
    {
        get => _shelterId;
        set => _shelterId = value;
    }

    public string Navn
    {
        get => _navn;
        set => _navn = value;
    }

    public int Lokation
    {
        get => _lokation;
        set => _lokation = value;
    }

    public int Kapacitet
    {
        get => _kapacitet;
        set => _kapacitet = value;
    }
}