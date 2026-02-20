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
        // 1. Check if the button click registers
        Debug.Log("Button pressed!"); 

        // 2. Check the input comparison
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
}