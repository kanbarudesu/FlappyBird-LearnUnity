using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class WaitForSecond : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnComplete;
    public void Wait(float seconds)
    {
        StartCoroutine(IeWaitForSecond(seconds));
    }
    private IEnumerator IeWaitForSecond(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        if (OnComplete != null)
        {
            OnComplete.Invoke();
        }
    }
}
