using System.Collections;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TMP_Text counterText;

    private int counter = 0;
    private bool isCounting = false;
    private Coroutine counterCoroutine;

    void Start()
    {
        counterText.text = counter.ToString();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isCounting)
            {
                isCounting = true;
                counterCoroutine = StartCoroutine(Count());
            }
            else
            {
                isCounting = false;
                StopCoroutine(counterCoroutine);
            }
        }
    }

    IEnumerator Count()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            counter++;
            counterText.text = counter.ToString();
        }
    }
}