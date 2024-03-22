using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } 

    public Formatter Formatter { get; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Formatter f = new BasicFormatter();

        string num = "234456";
        NumberFormat n = f.Format(ref num, NumberFormat.NATURAL);
        Debug.Log(num);
        Debug.Log(n);
    }

    void Update()
    {
        
    }

    public MoneyManager GetMoneyManager()
    {
        return null;
    }

    public Clicker GetClicker()
    { 
        return null; 
    }
}
