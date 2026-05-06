namespace Shelterudlejningssystemet;

public class Besoegslog
{
    private int _logId;
    private DateTime _startDato;
    private DateTime _slutDato;
    private string _tekst = "";

    public int LogId
    {
        get => _logId;
        set => _logId = value;
    }

    public DateTime StartDato
    {
        get => _startDato;
        set => _startDato = value;
    }

    public DateTime SlutDato
    {
        get => _slutDato;
        set => _slutDato = value;
    }

    public string Tekst
    {
        get => _tekst;
        set => _tekst =  value;
    }

   
}