using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Add this to access UI components

public class SceneController : MonoBehaviour
{
    // Scene index to load
    public int sceneIndex;
    [SerializeField] Animator transitionAnim;

    private bool m_isLoading = false;

    // Method to be called on button click
    public void OnButtonClick()
    {
        if (m_isLoading) return;
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        m_isLoading = true;
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);

        // Check if the build index is within the range of available scenes
        if (sceneIndex >= 0 && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        }
        else
        {
            Debug.LogError("Invalid scene index! Please provide a valid index.");
        }

        transitionAnim.SetTrigger("Start");
        m_isLoading = false;

        Debug.Log("End Load");
    }
}
