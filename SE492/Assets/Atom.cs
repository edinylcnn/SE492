using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Atom : MonoBehaviour
{
    private bool isopened;

    [SerializeField] private GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!isopened)
        {
            isopened = !isopened;
            plane.transform.DOScale(1, 1);
        }
        else
        {
            isopened = !isopened;
            plane.transform.DOScale(0, 1);  

        }
    }
}
