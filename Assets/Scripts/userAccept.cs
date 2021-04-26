using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userAccept : MonoBehaviour
{
    public Button unameButt;
    public InputField uname;

    private GameObject thisObject;
    private GameController gameControllerObject;
    // Start is called before the first frame update
    void Start()
    {
        gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();
        thisObject = GameObject.FindWithTag("uname");
        unameButt.onClick.AddListener(startGame);
    }

    void startGame()
    {
        gameControllerObject.SetUname(uname.text);
        gameControllerObject.StartGame();
        GameObject.Destroy(thisObject);
        //foreach (Transform child in thisObject.transform) {
        //    GameObject.Destroy(child.gameObject);
        //}
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
