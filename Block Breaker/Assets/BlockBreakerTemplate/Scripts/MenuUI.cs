using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour 
{
	public int level;
	public GameObject LevelCanvas;
	public GameObject MainCanvas;


	//Called when the play button is pressed
	public void PlayButton ()
	{
		LevelCanvas.SetActive(true);
		MainCanvas.SetActive(false);
	}

	//Called when the quit button is pressed
	public void QuitButton ()
	{
		Application.Quit();			//Quits the game
	}

	public void LevelLoad( int level) 
	{
		SceneManager.LoadScene(level);   //Loads the 'Game' scene to begin the game
	}
}
