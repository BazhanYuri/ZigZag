using UnityEngine;
using TMPro;




namespace ZigZag
{
    public class GamePlayScreen : Screen
    {
        [SerializeField] private TextMeshProUGUI _crystalsCount;



        private void OnEnable()
        {
            CrystalHadnler.CrystalCountUpdated += UpdateCrystalCount;
        }
        private void OnDisable()
        {
            CrystalHadnler.CrystalCountUpdated -= UpdateCrystalCount;
        }

        private void UpdateCrystalCount(int count)
        {
            _crystalsCount.text = count.ToString(); 
        }
        
    }
}

