using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	protected Animator animator;
	private float directionX = 0.0f;
	private float directionY = 0.0f;
	private float startXpos = 0.125f;
	private float startYpos = 0.0f;

	private bool isDead = false;
	private bool isGameOver = false;

	// Use this for initialization
	void Start () 
	{
		//animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!isDead)
		{
			float h = Input.GetAxisRaw("Horizontal");
			directionX = 0.0f;
			directionY = 0.0f;
			if(Input.GetKeyDown(KeyCode.Space))
			{
				directionY += 0.15f;
			}

			if(h > 0.0f)
			{
				directionX += 0.01f;
			}
			else if(h < 0.0f)
			{
				directionX -= 0.01f;
			}
		
			directionY -= 0.005f;

			transform.Translate(new Vector3(directionX,directionY,0f));
		}
		else
		{
			isGameOver = true;
			directionX = 0.0f;
			directionY = 0.0f;
		}
		//Debug.Log("up");

		//isDead = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		isDead = true;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		//Debug.Log("on");

		if(other.gameObject.tag == "Shadow")
		{
			isDead = false;
		}
	}

	public bool IsDead()
	{
		//Debug.Log(isGameOver);


		return isGameOver;
	}

	public void Reset()
	{
		directionX = 0.0f;
		directionY = 0.0f;
		transform.localPosition = new Vector3(startXpos,startYpos,0.0f);
		isGameOver = false;
		isDead = false;
	}
}
