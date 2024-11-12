using UnityEngine;
using UnityEngine.UI;

public class OpenURLButton : MonoBehaviour
{
    // Expose this variable to store the URL in the Inspector
    [SerializeField] private string url;

    // Function to open the URL
    public void OpenURL()
    {
        // If the URL is empty, set it to Google’s homepage by default
        if (string.IsNullOrEmpty(url))
        {
            Debug.LogWarning("URL is empty. Opening Google as the default.");
            url = "https://www.google.com";
        }

        Application.OpenURL(url);
    }
}
