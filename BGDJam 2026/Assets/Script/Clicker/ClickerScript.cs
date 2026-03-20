using UnityEngine;
using TMPro;
using System.Collections.Generic;
using DG.Tweening;
using System;
//using Cinemachine;
public class ClickerScript : MonoBehaviour
{
    [SerializeField] private List<string> texts = new List<string>();
    [SerializeField] private GameObject textPrefab;
    [SerializeField] private Transform pivot;
    //[SerializeField] private Cine


    public static Action cortisolClicking;



    private void OnEnable()
    {
        cortisolClicking += teksSpawn;
        cortisolClicking += AddCortisol;

    }
    private void OnDisable()
    {
        cortisolClicking -= teksSpawn;
        cortisolClicking -= AddCortisol;

    }
    public void teksSpawn()
    {
        var x = texts.Count;
        int index = UnityEngine.Random.Range(0, x);
        GameObject obj = Instantiate(textPrefab, pivot.position, Quaternion.identity, pivot);

        TMP_Text txt = obj.GetComponent<TMP_Text>();
        if (txt != null)
        {
            txt.text = texts[index];
        }
    }

    public void AddCortisol()
    {
        CortisolManager.instance.AddCortisol();
    }

    public void Clicking()
    {
        cortisolClicking.Invoke();
    }
}
