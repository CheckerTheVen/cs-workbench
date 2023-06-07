using System.Collections;
using System.Net.Http.Headers;

public class Coin
{
    public int Value = -1;

    public Coin(int value = 0)
    {
        if (value < 0)
        {
            throw new ArgumentException("\"value\" must not be smaller than zero.");
        }

        this.Value = value;
    }
}

public class Coins : IEnumerator, IEnumerable
{

    private Coin[] _Coins;

    public Coins(Coin single)
    {
        _Coins = new Coin[1];
        _Coins[0] = single;
    }

    public Coins(params Coin[] collection)
    {
        _Coins = collection;
    }

    public void Insert(Coin single)
    {
        _Coins.Append(single);
    }

    public void Insert(params Coin[] collection)
    {
        foreach (Coin single in collection)
        {
            Insert(single);
        }
    }

    private int _Position = -1;

	public object Current { get { return _Coins[_Position]; } }

	public IEnumerator GetEnumerator()
	{
		return this;
	}

	public bool MoveNext()
	{
		_Position++;
        return (_Position < _Coins.Length);
	}

	public void Reset()
	{
        _Position = -1;
	}
}

public class StoneLevels : IDictionary, IDictionaryEnumerator
{
    public enum StoneLevel
    {
        Frequent, Uncommon, Rare, Unique
    }

    private DictionaryEntry[] _Items;

    private int _Position = -1;

    public StoneLevels(params DictionaryEntry[] collection)
    {
        _Items = new DictionaryEntry[Count];
        for (int i = 0; i < Count && i < collection.Length; i++)
        {
            _Items[i] = collection[i];
        }
    }

    public object? this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool IsFixedSize { get { return true; } }

    public bool IsReadOnly { get { return true; } }

    public int Count { get { return 6; } }

    public bool IsSynchronized { get { return false; } }

    public object SyncRoot { get { throw new NotImplementedException(); } }

    public ICollection Keys
    {
        get
        {
            object[] keys = new object[_Items.Length - 1];

            for (int current = 0; _Items.GetEnumerator().MoveNext(); current++)
            {
                keys[current] = _Items[current].Key;
            }

            return keys;
        }
    }

    public ICollection Values
    {
        get
        {
            object[] values = new object[_Items.Length - 1];

            for (int current = 0; _Items.GetEnumerator().MoveNext(); current++)
            {
                values[current] = _Items[current].Value;
            }

            return values;
        }
    }

    public DictionaryEntry Entry { get { return _Items[_Position]; } }

    public object Key { get { return _Items[_Position].Key; } }

    public object? Value { get { return _Items[_Position].Value; } }

    public object Current { get { return _Items[_Position]; } }

    public void Add(object key, object? value)
    {
        // TODO Check for correct types.

        _Items.Append(new DictionaryEntry(key, value));
    }

    public void Clear()
    {
        return;
    }

    public bool Contains(object key)
    {
        foreach (DictionaryEntry element in _Items)
        {
            if (element.Key.Equals(Key))
            {
                return true;
            }
        }

        return false;
    }

    public void CopyTo(Array array, int index)
    {
        return;
    }

    public IDictionaryEnumerator GetEnumerator()
    {
        return this;
    }

    public void Remove(object key)
    {
        return;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        _Position++;
        return (_Position < _Items.Length);
    }

    public void Reset()
    {
        _Position = -1;
    }
}

public class Program
{
    public static void Main()
    {
        Coin a = new Coin();
        Coin b = new Coin(64);

        Coin[] arr = { a, b };

        Coins coins = new Coins(arr);

        Console.WriteLine(a + "\n\n" + b);
    }
}