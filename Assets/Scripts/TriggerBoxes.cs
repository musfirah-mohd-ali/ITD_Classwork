using UnityEngine;

public class TriggerBoxes : MonoBehaviour
{
    [Header("Spawning")]
    public GameObject nextBoxPrefab;
    public Transform boxSpawnLocation;

    [Header("Teleportation Setup")]
    public GameObject teleporterPrefab;
    public Transform teleporterSpawnLocation;
    public GameObject congratsCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (nextBoxPrefab != null && boxSpawnLocation != null)
            {
                Instantiate(nextBoxPrefab, boxSpawnLocation.position, boxSpawnLocation.rotation);
            }
            if (teleporterPrefab != null && teleporterSpawnLocation != null)
            {
                Instantiate(teleporterPrefab, teleporterSpawnLocation.position, teleporterSpawnLocation.rotation);
            }
            if (congratsCanvas != null) congratsCanvas.SetActive(true);
            Destroy(gameObject);
        }
    }
}