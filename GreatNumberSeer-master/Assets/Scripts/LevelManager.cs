using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class LevelManager : MonoBehaviour {
//THis method load a specific scene
    public void LoadLevel(string levelName) {
        SceneManager.LoadScene(levelName);
    }

    // Quit the application
    public void EndGame() {
        Application.Quit();
    }

}
