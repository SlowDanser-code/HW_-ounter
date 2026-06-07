using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _counter.ValueChanged += ShowValue;
    }

    private void OnDisable()
    {
        _counter.ValueChanged -= ShowValue;
    }

    private void Start()
    {
        _text.text = "0";
    }

    private void ShowValue(int value)
    {
        _text.text = value.ToString();
    }
}