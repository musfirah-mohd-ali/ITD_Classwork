using UnityEngine;

public class TeleportSequence : MonoBehaviour
{
    [Header("Sequence Settings")]
    public bool isFinalStep = false;
    public GameObject nextTeleportPrefab;
    public Transform nextSpawnLocation;

    [Header("UI Reference")]
    public GameObject congratsCanvasPrefab; // Drag your new Canvas Prefab here
    private GameObject instantiatedUI;      // Used to track the UI once spawned

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isFinalStep)
            {
                Debug.Log("Final step: Spawning UI...");

                // Check if we already spawned it so we don't spawn 100 copies
                if (instantiatedUI == null && congratsCanvasPrefab != null)
                {
                    instantiatedUI = Instantiate(congratsCanvasPrefab);
                    
                    // If set to "Screen Space - Overlay", it will appear flat on the screen
                    Debug.Log("UI spawned successfully!");
                }
            }
            else
            {
                Debug.Log("Spawning next area.");
                // Spawning Logic:
                if (nextTeleportPrefab != null && nextSpawnLocation != null)
                {
                    Instantiate(nextTeleportPrefab, nextSpawnLocation.position, nextSpawnLocation.rotation);
                    Destroy(gameObject);
                }
            }
        }
    }
}