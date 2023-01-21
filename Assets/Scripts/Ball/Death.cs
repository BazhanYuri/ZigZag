using System;
using UnityEngine;



namespace ZigZag
{
    public class Death : MonoBehaviour
    {
        [SerializeField] private Transform _root;
        [SerializeField] private float _minZLimit;

        private bool _isDeath = false;
        
        private void Update()
        {
            CheckIsDead();
        }
        private void CheckIsDead()
        {
            if (_root.position.y < _minZLimit)
            {
                Lose();
            }
        }
        private void Lose()
        {
            if (_isDeath == true)
            {
                return;
            }
            _isDeath = true;
            SoundManager.Instance.PlayFailSound();
            GameManager.LevelCompleted?.Invoke();
        }
    }
}

