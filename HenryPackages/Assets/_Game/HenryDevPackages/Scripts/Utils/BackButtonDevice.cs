using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackButtonDevice : MonoBehaviour
{
    public UnityEvent OnBack;
#if UNITY_ANDROID
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnBack?.Invoke();
        }  
    }
#endif
}
