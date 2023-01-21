using UnityEngine;
using UnityEngine.UI;



namespace ZigZag
{
    public class MainScreen : Screen
    {
        [SerializeField] private Button _startGameTap;



        private void OnEnable()
        {
            _startGameTap.onClick.AddListener(StartGame);
        }
        private void OnDisable()
        {
            _startGameTap.onClick.RemoveListener(StartGame);
        }
        private void StartGame()
        {
            GameManager.GamePlayStarted?.Invoke();
            gameObject.SetActive(false);
        }
    }
}

