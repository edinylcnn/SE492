using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Vuforia;

public class UIStartAR : MonoBehaviour
{
    public GameObject welcome;
    public GameObject scan;
    public GameObject scanChild;

    public bool isFirstScan = true;

    public GameObject firstScanPopUp;

    public GameObject backToMainCursor;
    //public GameObject 


    public
        void Start()
    {
        var seq = DOTween.Sequence();
        seq.AppendInterval(0.7f);
        seq.Append(welcome.transform.DOLocalMoveY(668, 1.5f));
        seq.AppendInterval(0.5f);
        seq.AppendCallback(() => { });
        seq.AppendCallback(() =>
            scanChild.transform.DOLocalMoveY(-150, 1.5f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo));
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OpenScan()
    {
        scan.gameObject.SetActive(true);
        scan.transform.localScale = Vector3.zero;
        scan.transform.DOScale(1, 0.8f);
    }

    public void CloseScan()
    {
        scan.transform.localScale = Vector3.one;
        scan.transform.DOScale(0, 0.8f).OnComplete(() => scan.gameObject.SetActive(false));
        FirstScan();
    }

    public void FirstScan()
    {
        if (isFirstScan)
        {
            isFirstScan = false;
            firstScanPopUp.SetActive(true);
            firstScanPopUp.transform.localScale = Vector3.zero;
            firstScanPopUp.transform.DOScale(1, 0.8f);

            Invoke("BackToMain", 1);
        }
    }

    public void BackToMain()
    {
        backToMainCursor.SetActive(true);
        backToMainCursor.transform.DOScale(1.2f, 1).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}