using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum LevelPhase { first, second, third }
    public static LevelPhase levelPhase = LevelPhase.first;
    public GameObject levelPhaseMessage;
    public static GameObject levelPhaseMessageStatic;
    private static Transform canvas;

    public GameObject gameOverScreen;

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

    public void restart() {
        SceneManager.LoadScene(1);
    }

    public void quit() { Application.Quit(); }

    public static void NextPhase() {
        levelPhase++;
        GameObject message = Instantiate(levelPhaseMessageStatic, canvas, false);
        message.GetComponent<GamePhaseMessage>().SendMessage("Phase: " + levelPhase);
    }

    // Start is called before the first frame update
    void Start()
    {
        levelPhaseMessageStatic = levelPhaseMessage;
        canvas = GameObject.FindGameObjectWithTag("Canvas").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
