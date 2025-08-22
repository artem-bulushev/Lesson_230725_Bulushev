using UnityEngine;

namespace Code
{
    public class MedicineChest : MonoBehaviour
    {
        void OnCollisionEnter(Collision otherObj)
        {
            if (otherObj.gameObject.name == "Player 2")
            {
                Destroy(gameObject);
                Debug.LogError("Аптечка +1");
            }
        }
    }
}