using UnityEngine;
using TMPro;
using System.Collections.Generic;
using DG.Tweening;

public class ClickerScript : MonoBehaviour
{
    [SerializeField] private List<string> texts = new List<string>();
    [SerializeField] private GameObject textPrefab;
    [SerializeField] private Transform pivot;

    public Event cortisolClicking;


    public void teksSpawn()
    {
        var x = texts.Count;
        int index = Random.Range(0, x);
        GameObject obj = Instantiate(textPrefab, pivot.position, Quaternion.identity, pivot);

        TMP_Text txt = obj.GetComponent<TMP_Text>();
        if (txt != null)
        {
            txt.text = texts[index];
        }
    }



    public void Clicking()
    {
        CortisolManager.instance.AddCortisol(1);
    }
}
