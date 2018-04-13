using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startScene : MonoBehaviour {
    public Button Btn_startGame;
    public Button Btn_exitGame;
    // Use this for initialization
    void Start () {
        Btn_startGame.onClick.AddListener(playGame);
        Btn_exitGame.onClick.AddListener(exitGame);
    
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void playGame() {
        Application.LoadLevel("Start");

    }
    public void exitGame() {
        Application.Quit();
    }
}
