using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public PlayerController player;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI()
	{


		if(player.IsDead())
		{
			//Debug.Log(player.IsDead());

			GUI.Box (new Rect(10,10,100,90),"Retry?");
			
			//1
			if(GUI.Button(new Rect(20,40,80,20), "Yes")) 
			{
				player.Reset();
			}
			
			//2 StageSelect
			if(GUI.Button(new Rect(20,70,80,20), "No")) 
			{
				Application.LoadLevel(2);
			}
		}

	}
}
