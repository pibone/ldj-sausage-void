using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageUpdater : MonoBehaviour
{
    public Image Man;
    private GameController gameControllerObject;
    private int step=0;
    public Sprite WAITING, SAUSAGE1, SAUSAGE2, CHEW1, CHEW2, DRINK1, DRINK2;
    private float timer=0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Man = GameObject.FindWithTag("realMan").GetComponent<Image>();
        gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();
        /*Sprite WAITING =  Resources.Load <Sprite>("Swallowing");
        Sprite SAUSAGE1 =  Resources.Load <Sprite>("Eating1");
        Sprite SAUSAGE2 =  Resources.Load <Sprite>("Eating2");
        Sprite CHEW1 =  Resources.Load <Sprite>("Chewing1");
        Sprite CHEW2 =  Resources.Load <Sprite>("Chewing2");
        Sprite DRINK1 =  Resources.Load <Sprite>("Drinking1");
        Sprite DRINK2 =  Resources.Load <Sprite>("Drinking2");*/
    }

    // Update is called once per frame
    void Update()
    {
        if (gameControllerObject.isEating())
        {
            timer += Time.deltaTime;
                if (timer<0.5f){
                    Man.sprite=SAUSAGE1;
                }else if(timer < 1){
                    Man.sprite=SAUSAGE2;    
                }else{
                timer = 0.0f;
                gameControllerObject.SetEating(false);
                }
        }else if (gameControllerObject.isChewing()){
                timer += Time.deltaTime;
                    if (timer<0.5){
                        Man.sprite=CHEW1;
                    }else if(timer < 1){
                        Man.sprite=CHEW2;    
                    }else{
                    timer = 0.0f;
                    }
        }else if (gameControllerObject.isDrinking()){
                timer += Time.deltaTime;
                    if (timer<0.5){
                        Man.sprite=DRINK1;
                    }else if(timer < 1){
                        Man.sprite=DRINK2;    
                    }else{
                    timer = 0.0f;
                    gameControllerObject.SetDrinking(false);
                    Man.sprite=WAITING;
                    }
        }else if (gameControllerObject.isSwallowing()){
                timer += Time.deltaTime;
                    if (timer<0.5){
                        Man.sprite=WAITING;
                    }else if(timer < 1){
                        Man.sprite=SAUSAGE1;    
                    }else{
                    timer = 0.0f;
                    gameControllerObject.SetSwallowing(false);
                    }
        }

    }
}
