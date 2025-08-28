using UnityEngine;

namespace Code
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float _spawnCooldown;
        private float _spawnTimer;

        private void Start()
        {
            ResetCooldown();
        }

        private void Update()
        {
            if (_spawnTimer > 0)
            {
                _spawnTimer -= Time.deltaTime;
            }
            else
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
                ResetCooldown();
            }
        }

        private void ResetCooldown()
        {
            _spawnTimer = _spawnCooldown;
        }
    }
}