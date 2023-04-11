using System.Net.NetworkInformation;

public class Car
{
    private string _model ;
    private int _topSpeed;
    private double _engine;
    private double _km;
    private int _hp;

  public string Model
    {
        get { return _model; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 10)
            {
                Console.WriteLine("The model cannot be empty and can have a maximum length of 10.");
            }
            else
            {
                _model = value;
            }
        }
    }

    public int TopSpeed
    {
        get { return _topSpeed; }
        set
        {
            if (value < 10 || value > 1000)
            {
                Console.WriteLine("TopSpeed can be a minimum of 10 and a maximum of 1000.");
            }
            else
            {
                _topSpeed = value;
            }
        }
    }

    public double Engine
    {
        get { return _engine; }
        set
        {
            if (value < 0.3 || value > 10)
            {
                Console.WriteLine("Engine can be minimum 0.3 and maximum 10.");
            }
            else
            {
                _engine = value;
            }
        }
    }

    public double Km
    {
        get { return _km; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Km can be minimum 0.");
            }
            else
            {
                _km = value;
            }
        }
    }

    public int Hp
    {
        get { return _hp; }
        set
        {
            if (value < 50 || value > 1000)
            {
                Console.WriteLine("Hp can be minimum 50 and maximum 1000.");
            }
            else
            {
                _hp = value;
            }
        }
    }
}