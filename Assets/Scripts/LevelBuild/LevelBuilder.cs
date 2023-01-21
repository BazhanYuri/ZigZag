using UnityEngine;


namespace ZigZag
{
    public class LevelBuilder : MonoBehaviour
    {
        [SerializeField, Range(0, 100)] private int _percentageOfCrystals;

        [SerializeField] private BlocksPool _blocksPool;
        [SerializeField] private CrystalPool _crystalPool;


        private int _currentXPos = 0;
        private int _currentZPos = 0;



        private void OnEnable()
        {
            Block.BlockFalled += NextStep;
        }
        private void OnDisable()
        {
            Block.BlockFalled -= NextStep;
        }

        private void Start()
        {
            BuildStartTrack();
        }
        private void BuildStartTrack()
        {
            for (int i = 0; i < _blocksPool.MaxCount / 2; i++)
            {
                NextStep();
            }
        }
        private void NextStep()
        {
            _blocksPool.GetPooledObject().transform.position = new Vector3(_currentXPos, 0, _currentZPos);

            bool isX = Random.Range(0, 2) == 1;

            if (isX == true)
            {
                _currentXPos++;
            }
            else
            {
                _currentZPos++;
            }

            TrySpawnCrystal();
        }
        private bool TrySpawnCrystal()
        {
            if (Random.RandomRange(0, 100) <= _percentageOfCrystals)
            {
                SpawnCrystal();
                return true;
            }
            return false;
        }
        private void SpawnCrystal()
        {
            _crystalPool.GetPooledObject().transform.position = new Vector3(_currentXPos + Random.RandomRange(-0.4f, 0.4f), 1, _currentZPos  + Random.RandomRange(-0.4f, 0.4f));
        }
    }
}

