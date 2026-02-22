using UnityEngine;

public class TriggerBoxes : MonoBehaviour
{
    [Header("Sequence Settings")]
    public GameObject nextBoxPrefab;
    public Transform spawnLocation;

    [Header("Final Step Settings")]
    public GameObject[] teleportersToEnable;
    public GameObject congratsCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger box reached: " + gameObject.name);
            if (nextBoxPrefab != null && spawnLocation != null)
            {
                Instantiate(nextBoxPrefab, spawnLocation.position, spawnLocation.rotation);
            }
            if (nextBoxPrefab == null)
            {
                Debug.Log("Tutorial complete! Enabling teleporters and UI.");
                foreach (GameObject tele in teleportersToEnable)
                {
                    if (tele != null) tele.SetActive(true);
                }
                if (congratsCanvas != null)
                {
                    congratsCanvas.SetActive(true);
                }
            }
            Destroy(gameObject);
        }
    }
}