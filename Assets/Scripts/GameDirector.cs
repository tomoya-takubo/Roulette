using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI部品を使うために必要

public class GameDirector : MonoBehaviour
{
    private GameObject needle;
    private GameObject result;

    // Start is called before the first frame update
    void Start()
    {
        needle = GameObject.Find("needle");
        result = GameObject.Find("result");
    }

    // Update is called once per frame
    void Update()
    {
        //this.result.GetComponent<Text>().text = this.needle.
    
    }
}
