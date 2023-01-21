using UnityEngine;
using UnityEngine.UI;



namespace ZigZag
{
    public class ShopScreen : Screen
    {
        [SerializeField] private Button _openButton;
        [SerializeField] private Button _closeButton;






        private void OnEnable()
        {
            _openButton.onClick.AddListener(ShowScreen);
            _closeButton.onClick.AddListener(HideScreen);
        }
        private void OnDisable()
        {
            _openButton.onClick.RemoveListener(ShowScreen);
            _closeButton.onClick.RemoveListener(HideScreen);
        }
        private void ShowScreen()
        {
            base.ShowScreen(0);
        }
        private void HideScreen()
        {
            base.HideScreen(0);
        }
    }

}
