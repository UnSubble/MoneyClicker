using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClickListener : MonoBehaviour
{
    private TextPopup _textPopup;
    private bool _isCollide;

    private void Start()
    {
        _isCollide = false;
        _textPopup = new TextPopup();
    }

    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && _isCollide)
        {
            Clicker clicker = GameManager.Instance.Clicker;
            Event event_ = new MoneyClickedEvent(_textPopup.GetType(), clicker.GetCapacity().ToString(), clicker.GetFormat());
            GameManager.Instance.EventHandler.Enqueue(event_);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ClickableMoney"))
        {
            _isCollide = true;
        }
    }
}
