using System;
using System.Collections;
using UnityEngine;
using DG.Tweening;



namespace ZigZag
{
    public class Block : MonoBehaviour
    {
        [SerializeField] private float _timeToFall;


        public static Action BlockFalled;


        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Ball ball))
            {
                StartCoroutine(FallBlock());
            }
        }
        private IEnumerator FallBlock()
        {
            yield return new WaitForSeconds(_timeToFall);
            if (GameManager.Instance.IsLevelCompleted == false)
            {
                transform.DOMoveY(-10, 5f).OnComplete(() => gameObject.SetActive(false));
                BlockFalled?.Invoke();
            }
        }
    }

}
