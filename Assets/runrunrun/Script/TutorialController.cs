using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class TutorialController:MonoBehaviour
{
    private bool canClick;

    void Update()
    {
        // if(Input.GetMouseButtonDown(0) && canClick)
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && canClick)
        {
            canClick = false;
            GetComponent<Animator>().SetTrigger("finish");       
        }
#if DEBUG_VERSION
        if (Input.GetKeyDown(KeyCode.A) && canClick)
        {
            canClick = false;
            GetComponent<Animator>().SetTrigger("finish");      
        }
#endif
    }

    void CanClick()
    {
        canClick = true;
    }

    void Deactive()
    {
        StartCoroutine(DeactiveByTime());
    }

    IEnumerator DeactiveByTime()
    {
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
    }
}

