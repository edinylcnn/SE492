using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomManager : MonoBehaviour
{
    public bool isEnableCl;

    public bool isEnableH;
    public GameObject h;
    public GameObject cl;
    public GameObject hcl;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnableCl && isEnableH)
        {
            h.SetActive(false);
            cl.SetActive(false);
            hcl.SetActive(true);
        }
        else
        {
            h.SetActive(true);
            cl.SetActive(true);
            hcl.SetActive(false);
        }
    }

    public void Counter()
    {
        Debug.Log(gameObject.name);
    }

    public void ClAtomEnable()
    {
        isEnableCl = true;
    }

    public void ClAtomDisable()
    {
        isEnableCl = false;
    }

    public void HAtomEnable()
    {
        isEnableH = true;
    }

    public void HAtomDisable()
    {
        isEnableH = false;
    }
}