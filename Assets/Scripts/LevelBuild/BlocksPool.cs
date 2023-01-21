using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace ZigZag
{
    public class BlocksPool : MonoBehaviour
    {
        [SerializeField] private int _maxCount;
        [SerializeField] private Block _blockPrefab;


        private List<Block> _blocks;

        public int MaxCount { get => _maxCount;}

        public Block GetPooledObject()
        {
            for (int i = 0; i < _maxCount; i++)
            {
                if (!_blocks[i].gameObject.activeInHierarchy)
                {
                    _blocks[i].gameObject.SetActive(true);
                    return _blocks[i];
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
            _blocks = new List<Block>();
            Block tmp;
            for (int i = 0; i < _maxCount; i++)
            {
                tmp = Instantiate(_blockPrefab);
                tmp.gameObject.SetActive(false);
                _blocks.Add(tmp);
            }
        }
    }

}
