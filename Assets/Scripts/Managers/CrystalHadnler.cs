using System;
using UnityEngine;


namespace ZigZag
{
    public class CrystalHadnler : MonoBehaviour
    {
        [SerializeField] private CrystalTookText _textEffectPrefab;
        [SerializeField] private GamePlayScreen _gamePlayScreen;

        public static Action<int> CrystalCountUpdated;

        public int CrystalCount { get; private set; }

        private void OnEnable()
        {
            Ball.CrystalPickedUp += AddOneCrystal;
            GameManager.LevelCompleted += CheckHighScore;
        }
        private void OnDisable()
        {
            Ball.CrystalPickedUp -= AddOneCrystal;
            GameManager.LevelCompleted -= CheckHighScore;
        }

        private void AddOneCrystal(Crystal crystal)
        {
            SoundManager.Instance.DiamondTookSound();
            CrystalCount++;
            CrystalCountUpdated?.Invoke(CrystalCount);
            ShowVisualEffect(crystal.transform.position);
        }
        private void ShowVisualEffect(Vector3 crystalPos)
        {
            CrystalTookText tpm = Instantiate(_textEffectPrefab);
            tpm.transform.parent = _gamePlayScreen.transform;
            tpm.GetComponent<RectTransform>().position = Camera.main.WorldToScreenPoint(crystalPos);
        }
        private void CheckHighScore()
        {
            if (CrystalCount > PlayerPrefs.GetInt(PrefsKeys.BestScoreKey, 0))
            {
                PlayerPrefs.SetInt(PrefsKeys.BestScoreKey, CrystalCount);
            }
        }
    }

}
