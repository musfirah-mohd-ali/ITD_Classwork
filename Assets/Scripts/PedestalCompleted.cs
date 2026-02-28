using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class pedestalCompleted : MonoBehaviour
{
    public GameObject completionUI; 
    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;

    void Start()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
        socket.selectEntered.AddListener(ShowFinalUI);
    }

    private void ShowFinalUI(SelectEnterEventArgs args)
    {
        if (completionUI != null)
        {
            completionUI.SetActive(true);
            Debug.Log("Success! Activity Complete.");
        }
    }

    public void GoBackToCA3()
    {
        SceneManager.LoadScene("BasicSceneCA3"); 
    }
}