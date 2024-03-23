using System.Collections;
using UnityEngine;

public class TextPopup : PoolObject
{
    [SerializeField]
    private float _destroyTime;
    [SerializeField]
    private Vector3 toGo;
    private TextMesh _textMesh;
    private Color _color;

    public override void Initialize()
    {
        transform.localPosition = Vector3.zero;
        transform.rotation = Quaternion.identity;
        _textMesh = GetComponentInChildren<TextMesh>();
        gameObject.SetActive(false);
        _color = _textMesh.color;
    }

    public override void Perform()
    {
        IsReady = false;
        gameObject.SetActive(true);
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _textMesh.color = _color;
        StartCoroutine(DestroySelf());
    }

    public override void Perform(object obj)
    {
        Perform();
        _textMesh.text = obj.ToString();
    }

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(_destroyTime);
        IsReady = true;
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsReady)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, toGo, Time.deltaTime);
            _textMesh.color = new Color(_textMesh.color.r, _textMesh.color.g, _textMesh.color.b, _textMesh.color.a - 0.002f);
        }
    }
}
