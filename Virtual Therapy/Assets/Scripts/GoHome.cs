using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void TransitionToMenu()
    {

        Debug.Log("Changing scene to fence!");
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
