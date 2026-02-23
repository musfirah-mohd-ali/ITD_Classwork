using UnityEngine;
using UnityEngine.SceneManagement; // Necessary to load scenes

public class TeleportSequence : MonoBehaviour
{
    [Header("Sequence Settings")]
    public bool isFinalStep = false;
    public GameObject nextTeleportPrefab;
    public Transform nextSpawnLocation;

    [Header("UI Reference")]
    public GameObject congratsCanvasPrefab; 
    public Transform spawnPoint;           
    private GameObject instantiatedUI;
    public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isFinalStep)
            {
                if (instantiatedUI == null && congratsCanvasPrefab != null && spawnPoint != null)
                {
                    instantiatedUI = Instantiate(congratsCanvasPrefab, spawnPoint.position, spawnPoint.rotation);
                    var yesButton = instantiatedUI.GetComponentInChildren<UnityEngine.UI.Button>();
                    if (yesButton != null)
                    {
                        yesButton.onClick.AddListener(() => LoadNextScene("BasicScene CA5"));
                    }
                }
            }
            else
            {
                if (nextTeleportPrefab != null && nextSpawnLocation != null)
                {
                    Instantiate(nextTeleportPrefab, nextSpawnLocation.position, nextSpawnLocation.rotation);
                    Destroy(gameObject);
                }
            }
        }
    }
}