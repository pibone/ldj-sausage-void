using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sausageCounter : MonoBehaviour
{
        public Text textBox;
        private GameController gameControllerObject;

    // Start is called before the first frame update
    void Start()
    {
        gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text=gameControllerObject.GetSausages().ToString();
    }
}
