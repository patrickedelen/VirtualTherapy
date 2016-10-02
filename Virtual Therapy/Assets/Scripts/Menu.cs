using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TransitionToFence()
    {

        Debug.Log("Changing scene to fence!");
        SceneManager.LoadScene("Fence");
    }
    public void TransitionToApples()
    {

        Debug.Log("Changing scene to apples!");
        SceneManager.LoadScene("trees");
    }
    public void TransitionToCards()
    {

        Debug.Log("Changing scene to cards!");
        SceneManager.LoadScene("cards");
    }
    public void TransitionToCandles()
    {

        Debug.Log("Changing scene to candles!");
        SceneManager.LoadScene("Candles");
    }
}
