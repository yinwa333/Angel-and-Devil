using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	
	//public void TriggerDialogue ()
	//{
	//	FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	//}
	//this was here before its just a reference

	//general text triggr that i Wish would work
	public void PopUpTextTrigger()
	{
		{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		}
	}
}
