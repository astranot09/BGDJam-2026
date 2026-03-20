using UnityEngine;
using DG.Tweening;

public class CortisolPopUp : MonoBehaviour
{
    [SerializeField] private float moveUpAmount = 50f;
    [SerializeField] private float duration = 1f;
    [SerializeField] private float fadeInDuration = 0.3f;
    [SerializeField] private float fadeOutDuration = 0.5f;
    [SerializeField] private float delayBeforeFadeOut = 0.5f;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        // Pastikan mulai dari transparan
        canvasGroup.alpha = 0;

        // Sequence DOTween
        Sequence seq = DOTween.Sequence();

        // Fade in + naik ke atas barengan
        seq.Append(canvasGroup.DOFade(1, fadeInDuration));
        seq.Join(rectTransform.DOAnchorPosY(rectTransform.anchoredPosition.y + moveUpAmount, duration));

        // Delay
        seq.AppendInterval(delayBeforeFadeOut);

        // Fade out
        seq.Append(canvasGroup.DOFade(0, fadeOutDuration));

        // Destroy setelah selesai
        seq.OnComplete(() => Destroy(gameObject));
    }
}
