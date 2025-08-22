using UnityEngine;

namespace Code
{
    public class PlayerTransform : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void FixedUpdate()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
    }
}
