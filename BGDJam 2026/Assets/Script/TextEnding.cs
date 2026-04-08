using UnityEngine;
using TMPro;
public class TextEnding : MonoBehaviour
{
    public TMP_Text x;
    void Start()
    {
        x.text = "Terima kasih sudah menyiksa dirimu " + GameManager.instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
