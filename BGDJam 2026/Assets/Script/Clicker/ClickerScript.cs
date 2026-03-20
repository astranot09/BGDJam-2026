using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using DG.Tweening;
using System;
using Unity.Cinemachine;
using System.Collections;
public class ClickerScript : MonoBehaviour
{
    [SerializeField] private List<string> texts = new List<string>();
    [SerializeField] private GameObject textPrefab;
    [SerializeField] private Transform pivot;
    [SerializeField] private CinemachineImpulseSource cinemachineImpulseSource;
    [SerializeField] private Button clickerButton;
    [SerializeField] private float delayClick;

    public static Action cortisolClicking;



    private void OnEnable()
    {
        cortisolClicking += teksSpawn;
        cortisolClicking += AddCortisol;
        cortisolClicking += ScreenShake;
        cortisolClicking += delayClicker;

    }
    private void OnDisable()
    {
        cortisolClicking -= teksSpawn;
        cortisolClicking -= AddCortisol;
        cortisolClicking -= ScreenShake;
        cortisolClicking -= delayClicker;
    }

    private void Start()
    {
        cinemachineImpulseSource = GetComponent<CinemachineImpulseSource>();
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
    public void ScreenShake()
    {
        cinemachineImpulseSource.GenerateImpulse();
    }

    public void AddCortisol()
    {
        CortisolManager.instance.AddCortisol();
    }

    public void Clicking()
    {
        cortisolClicking.Invoke();
    }

    public void delayClicker()
    {
        StartCoroutine(Cooldown());
    }
    private IEnumerator Cooldown()
    {
        clickerButton.interactable = false;
        yield return new WaitForSeconds(delayClick);
        clickerButton.interactable = true;
    }

}
