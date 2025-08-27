using UnityEngine;

namespace Code
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        public bool _time;
        private float _timer;

        private void Update()
        {
            if (_time == true)
            {
                _timer += Time.deltaTime;

                if (_timer >= 5f)
                {
                    _timer = 0;
                    Instantiate(prefab, transform.position, Quaternion.identity);
                }
            }
            else
            {
                _timer += Time.deltaTime;

                if (_timer >= 7f)
                {
                    _timer = 0;
                    Instantiate(prefab, transform.position, Quaternion.identity);
                }
            }
        }
    }
}