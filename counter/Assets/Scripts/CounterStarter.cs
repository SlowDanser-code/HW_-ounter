using UnityEngine;

public class CounterStarter : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _inputHandler.MouseClicked += _counter.Toggle;
    }

    private void OnDisable()
    {
        _inputHandler.MouseClicked -= _counter.Toggle;
    }
}