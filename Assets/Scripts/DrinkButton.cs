using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkButton : MonoBehaviour
{
    private GameController gameControllerObject;

    // Start is called before the first frame update
    void Start()
    {
                gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnMouseDown(){
        Debug.Log("out");
        if (gameControllerObject.isBusy()==false){
            Debug.Log("in");
            gameControllerObject.busyTrue();
            // Reset thirst
            gameControllerObject.ResetThirstyness();
            gameControllerObject.SetSaying("so refreshing!");
            // Start drinking animation
            gameControllerObject.SetDrinking(true);
            // on animation finish
            yield return new WaitForSeconds(1);
            gameControllerObject.busyFalse();
        }else{
            gameControllerObject.SetSaying("I'm ... nyam ... busy...");
        }

    }
}
