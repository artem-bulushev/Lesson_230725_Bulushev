using UnityEngine;

namespace Code
{
    public class Spawner2 : MonoBehaviour
    {
        [SerializeField] private GameObject pf;
        private float _time;

        private void Update()
        {
            _time += Time.deltaTime;

            if (_time >= 7f)
            {
                _time = 0;
                Instantiate(pf, transform.position, Quaternion.identity);
            }
        }
    }
}