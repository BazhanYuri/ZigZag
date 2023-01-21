using UnityEngine;
using Cinemachine;



namespace ZigZag
{
    public class CameraManager : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera _mainCamera;



        private void OnEnable()
        {
            GameManager.LevelCompleted += StopTrackingBall;
        }
        private void OnDisable()
        {
            GameManager.LevelCompleted -= StopTrackingBall;
        }

        private void StopTrackingBall()
        {
            _mainCamera.Follow = null;
        }
    }
}

