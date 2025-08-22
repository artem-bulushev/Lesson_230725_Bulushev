using UnityEngine;

namespace Code
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody _rigidbody;
        private float _horizontal;
        private float forward;

        private void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");
        }

        private void FixedUpdate()
        {
            //Vector3 newPos = transform.position + Vector3.forward * _speed * _horizontal;
            //_rigidbody.Move(newPos, Quaternion.identity);

            _rigidbody.velocity = Vector3.forward * 1 * _speed;
        }
    }
}