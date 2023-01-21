using UnityEngine;
using UnityEngine.UI;




namespace ZigZag
{
    public class BallAutomoving : MonoBehaviour
    {
        [SerializeField] private Button _tumbler;
        [SerializeField] private BallMovement _ballMovement;


        public bool IsTurned { get; private set; }



        private void OnEnable()
        {
            _tumbler.onClick.AddListener(Turn);
        }
        private void OnDisable()
        {
            _tumbler.onClick.RemoveListener(Turn);
        }


        private void Turn()
        {
            IsTurned = !IsTurned;
        }



        private void Update()
        {
            if (IsTurned == true)
            {
                AutodetectWay();
            }
        }
        private void AutodetectWay()
        {

        }
    }

}
