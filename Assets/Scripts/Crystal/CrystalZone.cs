using System.Collections;
using UnityEngine;



namespace ZigZag
{
    public class CrystalZone : MonoBehaviour
    {
        [SerializeField] private Transform _root;
        [SerializeField] private Rigidbody _rigidbody;




        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Ball ball))
            {
                HideCrystal();
            }
        }
        private void HideCrystal()
        {
            StartCoroutine(Hidding());
        }

        private IEnumerator Hidding()
        {
            yield return new WaitForSeconds(5);
            _root.gameObject.SetActive(false);
        }
    }
}
