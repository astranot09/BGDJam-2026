using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/ItemSO")]
public class ItemSO : ScriptableObject
{
    public string nameItem;
    public string descriptionItem;
    public Sprite iconItem;
    public int costCortisol;
    public int bonusCortisol;
    public GameObject spawnGameObject;
}
