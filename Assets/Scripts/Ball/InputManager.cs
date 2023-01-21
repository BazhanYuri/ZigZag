using System;
using UnityEngine;



namespace ZigZag
{
    public class InputManager : MonoBehaviour
    {
        public static Action Tap;




        private void Update()
        {
            CheckTouches();
        }
        private void CheckTouches()
        {
            if (Input.touchCount <= 0)
            {
                return;
            }
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Tap.Invoke();
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    break;
                case TouchPhase.Canceled:
                    break;
                default:
                    break;
            }
        }
    }
}

