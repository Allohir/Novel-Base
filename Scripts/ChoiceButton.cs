using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ChoiceButton : MonoBehaviour
{
    public string option;
    public DialogueVisualizer box;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetText(string newText)
    {
        this.GetComponentInChildren<TMP_Text>().text = newText;
    }

    public void SetOption(string newOption)
    {
        this.option = newOption;
    }

    public void ParseOption()
    {
        string command = option.Split(',')[0];
        string commandModifier = option.Split(',')[1];
        box.playerTalking = false;
        if (command == "line")
        {
            box.lineNum = int.Parse(commandModifier);
            box.ShowDialogue();
        }
        else if (command == "scene")
        {
            SceneManager.LoadScene("Scene" + commandModifier);
        }
        else if (command == "nextDay")
        {
            PlayerData playerData = GameObject.Find("PlayerData").GetComponent<PlayerData>();
            playerData.changeDay();
            SceneManager.LoadScene("Scene1");
        }
    }
}
