using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    [SerializeField] private string[] _message;
    [SerializeField] private Text _messageText;

    public void StartDivination()
    {
        _messageText.text = null;
        StartCoroutine(GeneratorMessage());
    }

    IEnumerator GeneratorMessage()
    {
        yield return new WaitForSeconds(1);
        _messageText.text = _message[Random.Range(0, _message.Length)];
    }
}
