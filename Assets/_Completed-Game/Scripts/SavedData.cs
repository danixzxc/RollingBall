using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SavedData<T, R, U> : BaseExample<R>
        where T : U
{
    public T Position;
    public SavedData(R id) : base(id)
    {
        IdPlayer = id;
    }
}

public class BaseExample<T>
{
    public T IdPlayer = default;

    public BaseExample(T id)
    {
        IdPlayer = id;
    }
}
