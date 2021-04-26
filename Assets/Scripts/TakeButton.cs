using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeButton : MonoBehaviour
{
    private int n_chews;
    private bool listening;
    private GameController gameControllerObject;
    public float thirstynessFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (listening){
            if (Input.GetKeyDown (KeyCode.Space)) {
                n_chews += 1;
                //chewing increases thistyness
                gameControllerObject.AddThirstyness(1);
            if (n_chews > 1)
                Debug.Log("Pressed " + n_chews + " times.");
            else
                Debug.Log("Pressed once.");
            }
        }
    }
    IEnumerator OnMouseDown(){
        Debug.Log("out");
        if (gameControllerObject.isBusy()==false){
            Debug.Log("in");
            gameControllerObject.busyTrue();
            // Send Eating Message
            // Start take sausage animation
            gameControllerObject.SetEating(true);
            // on animation finish
            yield return new WaitForSeconds(1);
            // Start chewing animation
            gameControllerObject.SetChewing(true);
            // Listen to # keystrokes during 1 second
            n_chews=0;
            listening = true;
            yield return new WaitForSeconds(1);
            listening=false;

            // extend chewing animation for X seconds
            // chewing animation time depends on thirstyness
            Debug.Log("Still chewing. Thisrt level: " + gameControllerObject.GetThirstyness());
            gameControllerObject.SetSaying("naym... nyam...");
            float chewTime = 0.5f+gameControllerObject.GetThirstyness()*thirstynessFactor/100f;
            yield return new WaitForSeconds(gameControllerObject.RetrieveBoundedValue(chewTime*gameControllerObject.GetNChews()-1f,0.5f,10f));
            Debug.Log("Finished Chewing!!");
            gameControllerObject.SetSaying("...");
            // Stop chewing animation 
            gameControllerObject.SetNChews(n_chews);
            gameControllerObject.SetChewing(false);
            gameControllerObject.busyFalse();
        }else{
            gameControllerObject.SetSaying("I'm ... nyam ... busy...");
        }

    }

}
