using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FullStomach : MonoBehaviour
{
    public Color altColor = Color.white;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        //Image.DisableSpriteOptimizations();
        //Get the renderer of the object so we can access the color
          rend = GetComponent<Renderer>();
         //Set the initial color (0f,0f,0f,0f)
         rend.material.color = altColor;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown (KeyCode.G)){  
             //Alter the color          
             altColor.g += 0.1f;
             //Assign the changed color to the material.
         }
        rend.material.color = altColor;
    }

    private void  OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Col detected");
        if (col.gameObject.tag=="Food"){
            altColor=new Color32(255, 0, 0, 255);
            rend.material.color = altColor;
            Debug.Log("Col with food");
        }
        
    }

    void  OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag=="Food"){
            altColor=Color.white;
            Debug.Log("Col exited");
            rend.material.color = altColor;
        }
        
    }
}
