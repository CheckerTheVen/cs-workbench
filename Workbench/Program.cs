using System.Collections;

public class Coin
{
    public int Value = -1;

    public Coin(int value = 0)
    {
        this.Value = value;
    }
}

public class Coins : IEnumerator, IEnumerable
{
    public Coins()
    {
        
    }

	public object Current { get { throw new NotImplementedException(); } }

	public IEnumerator GetEnumerator()
	{
		throw new NotImplementedException();
	}

	public bool MoveNext()
	{
		throw new NotImplementedException();
	}

	public void Reset()
	{
        throw new NotImplementedException();
	}
}

public class Program
{
    public static void Main()
    {
        Coin a = new Coin();
        Coin b = new Coin(64);

        Console.WriteLine(a + "\n\n" + b);
    }
}