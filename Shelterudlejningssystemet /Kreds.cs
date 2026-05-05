namespace Shelterudlejningssystemet;

public class Kreds
{
    private int _kredsId;
    private string _navn = "";
    private int _antal;

    public int KredsId
    {
        get => _kredsId;
        set => _kredsId = value;
    }

    public string Navn
    {
        get => _navn;
        set => _navn = value;
    }

    public int Antal
    {
        get => _antal;
        set => _antal = value;
    }
}