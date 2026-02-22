using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 

public class LoginHandler : MonoBehaviour
{
    public TMP_InputField passwordInput; 
    public string correctPassword = "12345"; 
    public GameObject errorMessage; 

    public void OnLoginButtonPressed()
    {
        Debug.Log("Button pressed!"); 
        if (passwordInput.text == correctPassword)
        {
            Debug.Log("Password correct! Loading scene...");
            SceneManager.LoadScene("SampleScene"); 
        }
        else
        {
            Debug.Log("Password incorrect. Showing error message.");
            errorMessage.SetActive(true);
        }
    }

    public void CloseErrorPanel()
    {
        Debug.Log("Closing error panel.");
        errorMessage.SetActive(false);
    }
}