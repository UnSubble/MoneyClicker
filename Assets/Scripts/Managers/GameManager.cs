using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Clicker _clicker;
    [SerializeField]
    private int _textPopupPoolCount;
    [SerializeField]
    private TextPopup _textPopupPrefab;
    [SerializeField]
    private GameObject _textPopupParent;
    [SerializeField]
    private Pool _pool;
    [SerializeField]
    private EventHandler _eventHandler;

    public int TextPopupPoolCount {  get; private set; }

    public static GameManager Instance { get; private set; } 

    public Clicker Clicker { get; private set; }

    public MoneyManager MoneyManager { get; private set; }

    public Formatter Formatter { get; private set; }

    public Pool Pool { get; private set; }

    public EventHandler EventHandler { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Clicker = _clicker;
        TextPopupPoolCount = _textPopupPoolCount;
        Pool = _pool;
        EventHandler = _eventHandler;
        Formatter = new BasicFormatter();
        MoneyManager = new MoneyManagerImpl(Formatter);

        _pool.CreateNTimes(_textPopupPrefab, _textPopupParent.transform, _textPopupPoolCount);
    }

    void Update()
    {
        
    }
}
