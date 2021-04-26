using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardButton : MonoBehaviour
{
    public Button butt;
    private LevelController levelControllerObject;

    // Start is called before the first frame update
    void Start()
    {
        butt.onClick.AddListener(newGame);
        levelControllerObject = GameObject.FindWithTag("levelControllerObject").GetComponent<LevelController>();

    }

    void newGame(){
        levelControllerObject.LoadLeaderboard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
