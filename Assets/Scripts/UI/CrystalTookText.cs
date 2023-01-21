using UnityEngine;
using DG.Tweening;




namespace ZigZag
{
    public class CrystalTookText : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;



        private void OnEnable()
        {
            PlayAnimation();
        }


        private void PlayAnimation()
        {
            _rectTransform.DOAnchorPosY(_rectTransform.anchoredPosition.y + 10, 0.6f).OnComplete(() => Destroy(gameObject));
        }
    }

}
