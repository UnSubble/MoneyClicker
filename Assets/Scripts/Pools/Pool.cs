using System;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    private Dictionary<Type, LinkedList<PoolObject>> _poolObjectsByType = new Dictionary<Type, LinkedList<PoolObject>>();
        
    public PoolObject Create(PoolObject poolObject, Transform parent)
    {
        GameObject newObj = Instantiate(poolObject.gameObject, parent);
        PoolObject newPoolObj = newObj.GetComponent<PoolObject>();
        newPoolObj.Initialize();
        if (!_poolObjectsByType.ContainsKey(newPoolObj.GetType()))
        {
            LinkedList<PoolObject> poolObjects = new LinkedList<PoolObject>();
            _poolObjectsByType.Add(poolObject.GetType(), poolObjects);
        }
        _poolObjectsByType[poolObject.GetType()].AddLast(newPoolObj);
        return newPoolObj;
    }

    public void CreateNTimes(PoolObject poolObject, Transform parent, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Create(poolObject, parent);
        }
    }

    public PoolObject poll(Type type)
    {
        LinkedList<PoolObject> targetPoolObject = _poolObjectsByType[type];
        PoolObject obj = targetPoolObject.First.Value;
        if (!obj.IsReady)
        {
            throw new InvalidOperationException("PoolObject is not ready!");
        }
        targetPoolObject.RemoveFirst();
        targetPoolObject.AddLast(obj);
        return obj;
    } 

    public void Perform(Type type)
    {
        PoolObject obj = poll(type);
        obj.Perform();
        
    }

    public void Perform(Type type, System.Object obj)
    {
        PoolObject target = poll(type);
        target.Perform(obj);
    }

    public void PerformNTimes(Type type, int times)
    {
        for(int i = 0;i < times; i++)
        {
            Perform(type);
        }
    }
}
