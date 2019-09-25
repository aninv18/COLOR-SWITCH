
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public float jump = 10f;
	public Rigidbody2D rb;
	public string curcolor;
	public SpriteRenderer sr;
	public Color cCyan;
	public Color cYellow;
	public Color cPink;
	public Color cPurple;

	 
	void Start()
	{
		
		randomcolor ();
	}


	// Update is called once per frame
	void Update () {
		if ( Input.GetMouseButtonDown (0)) {

			rb.velocity = Vector2.up * jump;
		
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Changer") {
			randomcolor ();
			Destroy (col.gameObject);	
			return;
		}
		if (col.tag == "boundary") {	
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
			Debug.Log (SceneManager.GetActiveScene ().buildIndex+1);
			return;
		}

		 if (col.tag != curcolor) {
			
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}	
	}

	void randomcolor()
	{
		int index = Random.Range (0, 4);
		switch (index) {
		case 0: 
			curcolor = "Cyan";
			sr.color = cCyan; 
			break;
		case 1: 
			curcolor = "Yellow";
			sr.color = cYellow; 
			break;
		case 2: 
			curcolor = "Pink";
			sr.color = cPink; 
			break;
		case 3: 
			curcolor = "Purple";
			sr.color = cPurple; 
			break;
		}
	}




}
