using System.Collections.Generic;
using UnityEngine;




namespace ZigZag
{
    public class CrystalPool : MonoBehaviour
    {
        [SerializeField] private int _maxCount;
        [SerializeField] private Crystal _crystalPrefab;


        private List<Crystal> _crystals;

        public int MaxCount { get => _maxCount; }

        public Crystal GetPooledObject()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                if (!_crystals[i].gameObject.activeInHierarchy)
                {
                    _crystals[i].gameObject.SetActive(true);
                    return _crystals[i];
                }
            }
            return null;
        }
        void Awake()
        {
            InitializePool();
        }



        private void InitializePool()
        {
            _crystals = new List<Crystal>();
            Crystal tmp;
            for (int i = 0; i < _maxCount; i++)
            {
                tmp = Instantiate(_crystalPrefab);
                tmp.gameObject.SetActive(false);
                _crystals.Add(tmp);
            }
        }
    }
}

