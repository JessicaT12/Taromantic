
using UnityEngine;
using UnityEngine.UI;

public class VNPresentationController : MonoBehaviour
{
    [Header("Background")]
    [SerializeField] private Image backgroundImage;

    [Header("Character Portraits")]
    [SerializeField] private Image leftPortrait;
    [SerializeField] private Image centerPortrait;
    [SerializeField] private Image rightPortrait;

    public void SetBackground(Sprite background)
    {
        backgroundImage.sprite = background;
    }

    public void SetPortrait(Sprite portrait, int position)
    {
        Image target = position switch
        {
            0 => leftPortrait,
            1 => centerPortrait,
            2 => rightPortrait,
            _ => null
        };

        if (target == null)
            return;

        target.sprite = portrait;
        target.enabled = portrait != null;
        target.gameObject.SetActive(portrait != null);
    }


    public void ClearPortraits()
    {
        if (leftPortrait != null)
            leftPortrait.gameObject.SetActive(false);

        if (centerPortrait != null)
            centerPortrait.gameObject.SetActive(false);

        if (rightPortrait != null)
            rightPortrait.gameObject.SetActive(false);
    }

}
