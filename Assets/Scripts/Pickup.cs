using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject effect; // Bu alan Inspector’da görünür

    private void OnTriggerEnter(Collider other)
    {
        // Pickup’ý yok et
        Destroy(gameObject);
    }
}