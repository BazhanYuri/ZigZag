using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace ZigZag
{
    public class CompletedScreen : Screen
    {
        [SerializeField] private TextMeshProUGUI _currentScore;
        [SerializeField] private TextMeshProUGUI _bestScore;

        [SerializeField] private Button _retryButton;

        [SerializeField] private CrystalHadnler _crystalHadnler;





        private void OnEnable()
        {
            GameManager.LevelCompleted += ShowCompletedScreen;
            _retryButton.onClick.AddListener(RestartLevel);
        }
        private void OnDisable()
        {
            GameManager.LevelCompleted -= ShowCompletedScreen;
            _retryButton.onClick.RemoveListener(RestartLevel);
        }
        private void ShowCompletedScreen()
        {
            UpdateUI();
            ShowScreen(1);
        }
        private void UpdateUI()
        {
            _currentScore.text = _crystalHadnler.CrystalCount.ToString();
            _bestScore.text = PlayerPrefs.GetInt(PrefsKeys.BestScoreKey).ToString();
        }
        private void RestartLevel()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}

