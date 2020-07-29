using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour {

	public static Dialogue dialogue;

    //general text triggr that i Wish would work
       
    public void PopUpTextTrigger()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
}
