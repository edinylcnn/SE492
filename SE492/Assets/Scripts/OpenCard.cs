using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OpenCard : MonoBehaviour
{
    public GameObject child;
    public float lastScale;

    public void Open()
    {
        child.SetActive(true);
        child.transform.localScale = Vector3.zero;
        child.transform.DOScale(lastScale, 1.2f);
    }
    
}
