using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;

	public Animator animator;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}
	//attempting icon thing below

	public SpriteRenderer iconRenderer;
    void Update()
    {
		PositionIcon();
    }
	void PositionIcon()
    {
		if (iconRenderer.sprite !=null)
        {
			var p = new Vector3(-3, 0, 0);
			iconRenderer.transform.localPosition = p;
        }

    }

	public void SetIcon(Sprite icon)
    {
		if (icon == null)
			iconRenderer.enabled = false;
        else
        {
			iconRenderer.sprite = icon;
			iconRenderer.enabled = true;
        }
    }
	//end for that
    public void StartDialogue (Dialogue dialogue)
	{
		//animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
		Debug.Log ("I'm yelling" + dialogue.name);
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
	}

}
