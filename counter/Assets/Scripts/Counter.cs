using System.Collections;
using UnityEngine;
using System;

public class Counter : MonoBehaviour
{
    private int _value;
    private Coroutine _countingCoroutine;

    public event Action<int> ValueChanged;

    public void Toggle()
    {
        if (_countingCoroutine == null)
        {
            _countingCoroutine = StartCoroutine(Increase());
        }
        else
        {
            StopCoroutine(_countingCoroutine);
            _countingCoroutine = null;
        }
    }

    private IEnumerator Increase()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            _value++;
            ValueChanged?.Invoke(_value);
        }
    }
}