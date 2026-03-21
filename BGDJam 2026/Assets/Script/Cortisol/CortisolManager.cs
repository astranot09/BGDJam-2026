using UnityEngine;
using UnityEngine.Playables;
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
    public int maxCortisol = 10000;
    [SerializeField] private int bonusCortisol = 1;
    [SerializeField] private CortisolUI cortisolUI;
    public PlayableDirector director;
    private void Start()
    {
        cortisolUI = GetComponent<CortisolUI>();
    }
    public void AddCortisol()
    {
        cortisol += bonusCortisol;
        cortisolUI.UpdateUI();
        if (cortisol >= maxCortisol)
        {
            PlayEnding();
        }
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


    private void PlayEnding()
    {
        director.Play();
    }
}
