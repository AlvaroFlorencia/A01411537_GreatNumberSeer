using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seer : MonoBehaviour {
    private int min;  // Variabkes
    private int max;
    private int guess;
    private LevelManager levelManager;
	public Text attemptsLabel;  //Number of attempts

    public int attempts;
    public Text guessLabel;
	public Text boy1Label; //For a battery of  the machine

	// initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>(); //Find level manager resorurce
        StartGame(); 
        ShowGuess();
	}
	


    void StartGame(){
        min = 1;
        max = 1001;  //Minimun and maximum of the number to find
        NextGuess();
    }

    void NextGuess(){
        guess = Random.Range(min, max); //Random number
		attempts--; //Attempts are reduced
    }

    void ShowGuess(){
		attemptsLabel.text = "ATTEMPTS: " + attempts;  //SHOW THE ATTEMPTS 
		if (attempts >= 0) {
			guessLabel.text = "IS YOUR NUMBER " + guess + "?";   // Show a different number dependent on the input of the user

		}
		else
		{
			levelManager.LoadLevel("win"); //The scene when the machine don't find the number
		}
			
		if (attempts ==4) {
			//Battery
			boy1Label.text = (@" 
██████████████] 85%");
			}

					
				
		if (attempts == 3) {
			boy1Label.text = (@"
█████████████] 70%
              ");
		}

			else if (attempts ==2) {
			boy1Label.text=(@"
██████████] 50%
                ");
			}
			else if (attempts == 1) {
			boy1Label.text=(@"
███████] 20%
                ");
			}
			else if (attempts == 0) {
			boy1Label.text=(@"
███] 10%
                ");
			}

		else if (attempts < 0) {
			boy1Label.text=(@"
] 0%
                ");
		}

			
        
    }

    public void GuessHiger(){  //if the number is bigger
        min = guess + 1;
        NextGuess();
        ShowGuess();
    }

	public void GuessLower(){ //if the number is smaller
        max = guess;
        NextGuess();
        ShowGuess();
    }

	public void CorrectGuess(){ 
        levelManager.LoadLevel("Lose");  //The scene when you lose
    }


}
