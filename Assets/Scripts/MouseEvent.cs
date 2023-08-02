using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEvent : MonoBehaviour, IDragHandler, IPointerUpHandler
{
    private IPointerUpHandler _pointerUpHandlerImplementation;
    [SerializeField]private Spawn _spawn;
    public GameObject ReadyMadeCoffee;
    public GameObject Trash;
    [SerializeField] private Check _check;
    public Transform pos;
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;

    }

    
    public void OnPointerUp(PointerEventData eventData)
    {  
        if ((transform.position - ReadyMadeCoffee.transform.position).magnitude < 150 )
        { 
            _check.coffies.Add(gameObject);
            transform.position = ReadyMadeCoffee.transform.position;
               gameObject.SetActive(false);
               gameObject.transform.position = pos.position;
               _spawn.Spawner();
            
        }
        if ((transform.position - Trash.transform.position).magnitude < 150 )
        {

            transform.position = Trash.transform.position;
            gameObject.SetActive(false);
            gameObject.transform.position = pos.position;
            _spawn.Spawner();
            
        }
    }
}

