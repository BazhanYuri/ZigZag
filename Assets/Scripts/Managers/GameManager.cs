using System;
using UnityEngine;




namespace ZigZag
{
    public class GameManager : MonoBehaviour
    {
        public static Action GamePlayStarted;
        public static Action LevelCompleted;


        public static GameManager Instance;

        public bool IsLevelCompleted { get; private set; }



        private void OnEnable()
        {
            LevelCompleted += LevelComplete;
        }
        private void OnDisable()
        {
            LevelCompleted -= LevelComplete;
        }


        private void Start()
        {
            Instance = this;
        }

        private void LevelComplete()
        {
            IsLevelCompleted = true;
        }


    }
}

