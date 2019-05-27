using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum LevelPhase { first, second, third }
    public static LevelPhase levelPhase = LevelPhase.first;
    public GameObject levelPhaseMessage;
    public static GameObject levelPhaseMessageStatic;
    private static Transform canvas;

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
