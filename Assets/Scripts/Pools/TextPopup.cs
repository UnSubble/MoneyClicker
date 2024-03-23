using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPopup : PoolObject
{
    [SerializeField]
    private float _destroyTime;
    private TextMesh _textMesh;

    public override void Initialize()
    {
        transform.position = transform.parent.position;
        transform.rotation = Quaternion.identity;
        _textMesh = GetComponentInChildren<TextMesh>();
        gameObject.SetActive(false);
    }

    public override void Perform()
    {
        IsReady = false;
        gameObject.SetActive(true);
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
        
    }
}
