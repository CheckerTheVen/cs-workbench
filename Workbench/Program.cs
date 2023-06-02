using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Coin
{
    public int Value;

    public Coin(int value)
    {
        Value = value;
    }
}

public class Coins : IEnumerable
{
    private Coin[] Coin;

    public Coins(Coin[] initializer)
    {
        Coin = new Coin[initializer.Length];

        for (int i = 0; i < initializer.Length; i++)
        {
            Coin[i] = initializer[i];
        }
    }

    public IEnumerator GetEnumerator()
    {
        return new CoinEnumerator(Coin);
    }
}

public class CoinEnumerator : IEnumerator
{
    public Coin[] Coin;

    public int Position = -1;

    public CoinEnumerator(Coin[] initializer)
    {
        Coin = initializer;
    }

    bool IEnumerator.MoveNext()
    {
        Position++;
        return (Position > Coin.Length);
    }

    void IEnumerator.Reset()
    {
        Position = -1;
    }

    object IEnumerator.Current{ get { return CurrentCoin; } }

    public Coin CurrentCoin { get { try { return Coin[Position]; } catch (IndexOutOfRangeException) { throw new InvalidOperationException(); } } }
}

public class Program
{
    public static void Main()
    {
        int count = 6;
        Coin[] coin = new Coin[count];
        
        for (int current = 0; current < count; current++)
        {
            coin[current] = new Coin(5 * current % 3);
        }

        Coins coins = new Coins(coin);

        foreach (Coin current in coins)
        {
            Console.WriteLine(current.Value.ToString());
        }
    }
}