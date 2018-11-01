using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialController : MonoBehaviour 
{

	//TODO get handles to GameObjects for stimuli
	//boolean to indicate when button1 is pressed
	public float repeatTime;
	public GameObject cue1; // cue1 is the visual cue that will be stimulus to press
	public GameObject response1; //response1 is the box indicating if the response was correct or not
	public Color colorCorrect = Color.green;
	public Color colorWrong = Color.red;

	private bool button1down;
	//nextOn will be used to hold when the cue will next be displayed
	private float nextOn = 0.0f;
	private bool cueActive; //to hold the state of the cue
	private Renderer responseRenderer;
	// Use this for initialization
	void Start () 
	{
		button1down = false;
		cueActive = false;
		cue1.SetActive(false);
		responseRenderer = response1.GetComponent<Renderer> ();

	}
	

	// Update is called once per frame (from documentation Input only reset on update so code is here for now)
	void Update () 
	{
		
		//check if it is time to turn the cue on
		if (Time.time > nextOn)
		{
			// reset the nextOn 
			//nextOn = Time.time + repeatTime;

			if (cue1.activeSelf)
			{
				//cue1.SetActive(false);
				//cueActive = false;
			}
			else
			{
				cue1.SetActive(true);
				cueActive = true;
			}	
					
				
			
		}
		
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
            response1.SetActive(true);
            //change material colour to green if it was active and red if it wasnt
            if (cueActive)
            {
                responseRenderer.material.SetColor("_Color", colorCorrect);
				cue1.SetActive(false);
				cueActive = false;
				nextOn = Time.time + repeatTime;
            }
            else
            {
                responseRenderer.material.SetColor("_Color", colorWrong);
            }
        }
        else
        {
            response1.SetActive(false);
        }





    }
}
