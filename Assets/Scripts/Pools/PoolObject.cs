using System;
using UnityEngine;

public abstract class PoolObject : MonoBehaviour
{
    public bool IsReady { get; protected set; }

    private void Awake()
    {
        IsReady = true;
    }

    public abstract void Initialize();

    public abstract void Perform();

    public abstract void Perform(System.Object obj);
}
