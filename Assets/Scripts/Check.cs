using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class Check : MonoBehaviour, IPointerClickHandler
{ 
    public List<GameObject> massiv1 = new List<GameObject>();
    public List<GameObject> coffies = new List<GameObject>();
    private int point = 0;
    public TextMeshProUGUI pointText;
    public GameObject[] coffee = new GameObject[5];

    public void OnPointerClick(PointerEventData eventData)
    {
        if (coffies.Count != 4 )
        {
            print("!=4");
            point--;
            coffies.Clear();
        }
        else
        {
            bool equal = massiv1.SequenceEqual(coffies);
            if (equal == false)
            {
                print("false");
                point--;
                coffies.Clear();
            }
            else
            {
                print("true");
                point++;
                coffies.Clear();
            }
           
        }
    }

    
    private void Update()
    {
        if (coffies.Count == 0)
        {
            coffee[1].SetActive(false);
            coffee[2].SetActive(false);
            coffee[3].SetActive(false);
            coffee[4].SetActive(false);
        }
        if (coffies.Count == 1)
        {
            coffee[1].SetActive(true);
            coffee[2].SetActive(false);
            coffee[3].SetActive(false);
            coffee[4].SetActive(false);
        }
        if (coffies.Count == 2)
        {
            coffee[2].SetActive(true);
            coffee[3].SetActive(false);
            coffee[1].SetActive(false);
            coffee[4].SetActive(false);
           
        }
        if (coffies.Count == 3)
        {
            coffee[3].SetActive(true);
            coffee[4].SetActive(false);
            coffee[2].SetActive(false);
            coffee[1].SetActive(false);
        }
        if (coffies.Count == 4)
        {
            coffee[4].SetActive(true);
            coffee[3].SetActive(false);
            coffee[2].SetActive(false);
            coffee[1].SetActive(false);
        }
        pointText.text = "Score: " + point;
    }
}
