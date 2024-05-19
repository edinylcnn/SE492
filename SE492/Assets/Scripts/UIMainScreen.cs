using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Extentions;
using UnityEngine;

public class UIMainScreen : MonoSingleton<UIMainScreen>
{
    public List<GameObject> mainButtons;

    private void Start()
    {
        StartCoroutine(StartButtons());
    }

    IEnumerator StartButtons()
    {
        foreach (var b in mainButtons)
        {
            b.transform.localScale = Vector3.zero;
        }

        foreach (var b in mainButtons)
        {
            b.transform.DOScale(1, 0.7f);
            yield return new WaitForSeconds(0.3f);
        }

        StopCoroutine(StartButtons());
    }
}