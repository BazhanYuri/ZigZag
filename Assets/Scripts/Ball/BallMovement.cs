using UnityEngine;



namespace ZigZag
{
    public class BallMovement : MonoBehaviour
    {
        [SerializeField] private BallAutomoving _ballAutomoving;
        [SerializeField] private Transform _root;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _speed;



        private Vector3 _moveDirection = Vector3.right;
        private bool _isMovingX = true;

        private bool _isStopped = true;


        private void OnEnable()
        {
            InputManager.Tap += ChangeDirectionOfMoving;
            GameManager.GamePlayStarted += StartMove;
            GameManager.LevelCompleted += StopMove;
        }
        private void OnDisable()
        {
            InputManager.Tap -= ChangeDirectionOfMoving;
            GameManager.GamePlayStarted -= StartMove;
            GameManager.LevelCompleted -= StopMove;
        }




        private void StopMove()
        {
            _isStopped = true;
        }
        private void StartMove()
        {
            _isStopped = false;
        }


        private void FixedUpdate()
        {
            Move();
        }

        private void ChangeDirectionOfMoving()
        {
            if (_isStopped == true)
            {
                return;
            }
            if (_ballAutomoving.IsTurned == true)
            {
                return;
            }

            _isMovingX = !_isMovingX;

            if (_isMovingX == true)
            {
                _moveDirection = Vector3.right;
            }
            else
            {
                _moveDirection = Vector3.forward;
            }
        }
        private void MoveRight()
        {

        }
        private void MoveLeft()
        {

        }
        private void Move()
        {
            if (_isStopped == true)
            {
                return;
            }

            _root.Translate(_moveDirection * _speed * Time.deltaTime);
        }
    }

}
