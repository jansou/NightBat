using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public GUIStyle customButton;
	public GUIStyle customBox;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		// バックグラウンド ボックスを作成します。
		GUI.Box(new Rect(10,10,Screen.width-10,Screen.height-10), "Choose Stage",customBox);

		float width = Screen.width * 0.3f;
		float height = Screen.height * 0.1f;
		
		// 1 つ目のボタンを作成します。 押すと、Application.Loadlevel (1) が実行されます。
		if(GUI.Button(rectCenter(Screen.width/2,Screen.height/2,width,height), "Level 1",customButton)) {
			Application.LoadLevel("main");
		}
		
		// 2 つ目のボタンを作成します。
		if(GUI.Button(rectCenter(Screen.width/2,Screen.height/2+Screen.height*0.15f,width,height), "Level 2",customButton)) {
			Application.LoadLevel(2);
		}

		// 2 つ目のボタンを作成します。
		if(GUI.Button(rectCenter(Screen.width/2,Screen.height/2+Screen.height*0.30f,width,height), "Level 3",customButton)) {
			Application.LoadLevel(3);
		}
	}
	Rect rectCenter(float x,float y,float w,float h){
		return new Rect(x-w/2,y-h/2,w,h);
	}
}
