using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeButton : MonoBehaviour
{
    private float n_chews;
    private bool listening;
    private GameController gameControllerObject;
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

            // on animation finish
            // Start chewing animation

            // Listen to # keystrokes during 1 second
            n_chews=0;
            listening = true;
            yield return new WaitForSeconds(1);
            listening=false;
            // extend chewing animation for X seconds

            // Stop chewing animation 
            gameControllerObject.busyFalse();
        }

    }

}
