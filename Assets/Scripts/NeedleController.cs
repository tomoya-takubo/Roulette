using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
{
    public string result;

    private void OnTriggerStay2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "kyou":
                result = "凶";
                Debug.Log("凶");
                break;
            case "tyukichi":
                result = "中吉";
                Debug.Log("中吉");
                break;
            case "suekichi":
                result = "末吉";
                Debug.Log("末吉");
                break;
            case "syoukichi":
                result = "小吉";
                Debug.Log("小吉");
                break;
            case "daikyou":
                result = "大凶";
                Debug.Log("大凶");
                break;
            case "daikichi":
                result = "大吉";
                Debug.Log("大吉");
                break;
        }

        /***
        if(collision.tag == "kyou")
        {
            Debug.Log("凶です。");
        }
        ***/
    }
}
