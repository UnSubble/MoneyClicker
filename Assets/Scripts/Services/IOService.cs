using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOService : MonoBehaviour
{
    [SerializeField]
    private string _fileName;
    private FileHandler _handler;

    public static IOService Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        _handler = new FileHandler(Application.persistentDataPath, _fileName);
    }

    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }
}
