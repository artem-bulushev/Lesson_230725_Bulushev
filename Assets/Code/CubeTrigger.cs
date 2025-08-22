using UnityEngine;

namespace Code
{
    public class CubeTrigger: MonoBehaviour
    {
        [SerializeField] private float _power;
        [SerializeField] private Rigidbody _rigidbody;

        private void FixedUpdate()
        {
            if(Input.GetMouseButtonDown(0))
            {
                _rigidbody.AddForce(Vector3.up * _power, ForceMode.Impulse);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bullet"))
            {
                Destroy(other.gameObject);
            }
            Debug.LogError("trigger " + other.gameObject.name);
        }

        private void OnCollisionEnter(Collision other)
        {
            Debug.LogError("collider " + other.gameObject.name);
        }
    }
}