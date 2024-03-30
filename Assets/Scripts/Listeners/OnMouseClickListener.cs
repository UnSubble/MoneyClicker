using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClickListener : MonoBehaviour
{
    private TextPopup _textPopup;
    private bool _isCollide,_isbill,_isclick;

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

        if(Input.GetMouseButtonDown(0) && _isbill)
        {
            AbstractBill bill = GameManager.Instance.AbstractBill;
            Event _event = new BillEvent(bill);
            GameManager.Instance.EventHandler.Enqueue(_event);
        }

        if (Input.GetMouseButtonDown(0) && _isclick)
        {
            ButtonManager button=GameManager.Instance.ButtonManager;
            Event _event = new ButtonEvent(button);
            GameManager.Instance.EventHandler.Enqueue(_event);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ClickableMoney"))
        {
            _isCollide = true;
        }
        if (collision.CompareTag("Bill"))
        {
            _isbill = true;
        }
        if (collision.CompareTag("Button"))
        {
            _isclick=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ClickableMoney"))
        {
            _isCollide = false;
        }
        if (collision.CompareTag("Bill"))
        {
            _isbill = false;
        }
        if (collision.CompareTag("Button"))
        {
            _isclick = false;
        }

    }
}
