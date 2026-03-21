using UnityEngine;
using TMPro;

public class CortisolUI : MonoBehaviour
{
    [SerializeField] private TMP_Text cortisolText;

    private void Start()
    {
        UpdateUI();
    }
    public void UpdateUI()
    {
        cortisolText.text = CortisolManager.instance.CheckCortisol().ToString()+" / "+ CortisolManager.instance.maxCortisol.ToString();
    }
}
