using UnityEngine;
using UnityEngine.EventSystems;

public class HoverEffect : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public Animator hoverAnimator;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverAnimator != null)
        {
            hoverAnimator.SetBool("IsHovered", true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (hoverAnimator != null)
        {
            hoverAnimator.SetBool("IsHovered", false);
        }
    }
}
