using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public GameObject player;
    public GameObject buttonAnim;
    public GameObject dialoguePanel;
    public Text dialogueText;
    [Header("Dialogue")]
    public string[] dialogue;
    private int index;
    public string[] secondTime;
    public string[] hasItemDialogue;
    public string[] hasItemLieDialogue;
    public string[] LeaveDialogue;

    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            buttonAnim.gameObject.SetActive(false);
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if (dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
    }


    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {

        contButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
            StartCoroutine(endDialogue());
        }
    }

    IEnumerator endDialogue()
    {
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<PlayerMovement>().enabled = true;
        buttonAnim.gameObject.SetActive(true);
        buttonAnim.GetComponent<Animator>().Play("AnimButton");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            buttonAnim.gameObject.SetActive(true);
            buttonAnim.GetComponent<Animator>().Play("AnimButton");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            buttonAnim.gameObject.SetActive(false);
            zeroText();
        }
    }
}
