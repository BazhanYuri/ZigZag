using System.Collections;
using UnityEngine;



namespace ZigZag
{
    public class Screen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;




        public virtual void ShowScreen(float time)
        {
            StartCoroutine(Showing(time));
        }
        public virtual void HideScreen(float time)
        {
            StartCoroutine(Hidding(time));
        }
        private IEnumerator Showing(float time)
        {
            yield return new WaitForSeconds(time);
            _canvasGroup.alpha = 1;
            _canvasGroup.interactable = true;
            _canvasGroup.blocksRaycasts = true;
        }
        private IEnumerator Hidding(float time)
        {
            yield return new WaitForSeconds(time);
            _canvasGroup.alpha = 0;
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;
        }
        
    }

}
