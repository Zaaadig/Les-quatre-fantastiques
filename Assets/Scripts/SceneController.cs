using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Add this to access UI components

public class SceneController : MonoBehaviour
{
    public string sceneName;
    [SerializeField] Animator transitionAnim;

    // Method to be called on button click
    public void OnButtonClick()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
        transitionAnim.SetTrigger("Start");
    }
}
