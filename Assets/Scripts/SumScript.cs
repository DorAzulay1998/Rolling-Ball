using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumScript : MonoBehaviour
{
    public GameObject sumScreen;
    private void Awake()
    {
        sumScreen.SetActive(false);
    }

    void Start()
    {

    }

    void Update()
    {
        if(TextScript.instance.finishLine == true)
        {
            sumScreen.SetActive(true);
            TextScript.instance.StarsSum();
        }
    }
}
