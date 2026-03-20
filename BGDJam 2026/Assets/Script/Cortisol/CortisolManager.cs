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

    public void AddCortisol(int count)
    {
        cortisol += count;
    }

    public int CheckCortisol()
    {
        return cortisol;
    }
    public void MinesCortisol(int count)
    {
        cortisol -= count;
    }
}
