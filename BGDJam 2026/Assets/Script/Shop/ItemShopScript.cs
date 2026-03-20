using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemShopScript : MonoBehaviour
{
    [SerializeField] private ItemSO itemSO;
    [SerializeField] private Image itemImage;
    [SerializeField] private TMP_Text itemName;
    [SerializeField] private TMP_Text itemDescription;
    [SerializeField] private Button BuyButton;
    [SerializeField] private Transform spawner;

    private void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        itemImage.sprite = itemSO.iconItem;
        itemName.text = itemSO.name;
        itemDescription.text = itemSO.descriptionItem;
    }

    public void Submit()
    {
        Debug.Log("Hola");
        if(CortisolManager.instance.CheckCortisol() < itemSO.costCortisol)
            return;
        CortisolManager.instance.MinesCortisol(itemSO.costCortisol);
        CortisolManager.instance.BonusCortisol(itemSO.bonusCortisol);
        SoundManager.instance.PlayAudio(itemSO.soundType);
        Debug.Log("PPP");
        Instantiate(itemSO.spawnGameObject, spawner);
        BuyButton.interactable = false;
    }
}
