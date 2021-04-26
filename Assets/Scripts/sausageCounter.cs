using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sausageCounter : MonoBehaviour
{
        public Text score, timeText;
        private GameController gameControllerObject;
        private LevelController levelControllerObject;
        private float timer=0.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();
        levelControllerObject = GameObject.FindWithTag("levelControllerObject").GetComponent<LevelController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
         int seconds = (int) (timer % 60);
         timeText.text = seconds.ToString();
        score.text=gameControllerObject.GetSausages().ToString();
        if (seconds >= 30){
           levelControllerObject.LoadEnding();
        }
    }
}
