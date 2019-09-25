using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu1 : MonoBehaviour {

	// Use this for initialization
	public void Play()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex -2);
	}


}
