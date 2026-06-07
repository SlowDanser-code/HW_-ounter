using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delay = 0.5f;

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
            yield return new WaitForSeconds(_delay);

            _value++;
            ValueChanged?.Invoke(_value);
        }
    }
}