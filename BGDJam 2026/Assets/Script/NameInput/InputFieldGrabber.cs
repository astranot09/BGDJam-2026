using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InputFieldGrabber : MonoBehaviour
{
    [SerializeField] private string inputText;

    public void GrabFromInputField(string input)
    {
        inputText = input;
    }

    public void Submit()
    {
        GameManager.instance.playerName = inputText;
        SceneManager.LoadScene("SampleScene");
    }
}
