using UnityEngine;

namespace Code
{
    public class MedicineChest : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerPhysics player))
            {
                Destroy(gameObject);
                Debug.LogError("������� +1");
            }
        }
    }
}