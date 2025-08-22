using UnityEngine;

namespace Code
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        private float _timer;

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= 5f)
            {
                _timer = 0;
                Instantiate(prefab, transform.position, Quaternion.identity);
            }
        }
    }
}