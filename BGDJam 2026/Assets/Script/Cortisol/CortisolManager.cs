using UnityEngine;

public class CortisolManager : MonoBehaviour
{
    public static CortisolManager instance;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    [SerializeField] private int cortisol;
    [SerializeField] private int bonusCortisol = 1;
    [SerializeField] private CortisolUI cortisolUI;

    private void Start()
    {
        cortisolUI = GetComponent<CortisolUI>();
    }
    public void AddCortisol()
    {
        cortisol += bonusCortisol;
        cortisolUI.UpdateUI();
    }
    public void BonusCortisol(int x)
    {
        bonusCortisol += x;
    }

    public int CheckCortisol()
    {
        return cortisol;
    }
    public void MinesCortisol(int count)
    {
        cortisol -= count;
        cortisolUI.UpdateUI();
    }
}
