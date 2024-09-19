using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 2f; // Time in seconds before the effect is destroyed

    void Start()
    {
        Destroy(gameObject, lifetime); // Destroy this game object after the specified time
    }
}
