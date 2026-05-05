namespace Shelterudlejningssystemet;

public class Booking
{
    private int _bookingId;
    private DateTime _startDato;
    private DateTime _slutDato;
    private int _antalMennesker;

    public int BookingId
    {
        get => _bookingId;
        set => _bookingId = value;
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

    public int AntalMennesker
    {
        get => _antalMennesker;
        set => _antalMennesker = value;
    }
}