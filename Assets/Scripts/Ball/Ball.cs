using System;
using UnityEngine;



namespace ZigZag
{
    public class Ball : MonoBehaviour
    {

        public static Action<Crystal> CrystalPickedUp;


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.TryGetComponent(out Crystal crystal))
            {
                TookCrystal(crystal);
                crystal.gameObject.SetActive(false);
            }
        }


        private void TookCrystal(Crystal crystal)
        {
            CrystalPickedUp?.Invoke(crystal);
        }
        
    }
}

