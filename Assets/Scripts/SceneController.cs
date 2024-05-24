using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Add this to access UI components

public class SceneController : MonoBehaviour
{
    public string sceneName;
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
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        transitionAnim.SetTrigger("Start");
        m_isLoading = false;

        Debug.Log("End Load");
    }
}
