using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialController : MonoBehaviour 
{

	//TODO get handles to GameObjects for stimuli
	//boolean to indicate when button1 is pressed
	public GameObject cue1;
	private bool button1down;
	// Use this for initialization
	void Start () 
	{
		button1down = false;
		cue1.SetActive(false);
	}
	

	// Update is called once per frame (from documentation Input only reset on update so code is here for now)
	void Update () 
	{
		//check if button went down during this frame
		if (Input.GetButtonDown("Button1"))
		{
			Debug.Log("1 down");
			button1down = true;
			
		}

		if (Input.GetButtonUp("Button1"))
		{
			Debug.Log("1 up");
			button1down = false;
			
		}

		//now turn cue on if button pressed
		if (button1down)
		{
			cue1.SetActive(true);
		}
			else
		{
			cue1.SetActive(false);
		}


		

		
	}
}
