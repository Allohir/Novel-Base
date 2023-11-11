using System.Collections;
using UnityEngine;
using TMPro;

public class TextTypingEffect : MonoBehaviour
{
    [SerializeField]
    private float typingSpeed = 0.03f;
    public string fullText;
    public string currentText = "";

    void Start()
    {
        StartShowingText(this.GetComponent<TMP_Text>().text);
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            GetComponent<TMP_Text>().text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }
        GetComponent<TMP_Text>().text = fullText;
    }

    public void StartShowingText(string newText)
    {
        fullText = newText;
        GetComponent<TMP_Text>().text = "";
        StartCoroutine(ShowText());
    }
}