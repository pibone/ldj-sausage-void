using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwallowButtonScript : MonoBehaviour
{
    public Camera cam;
    public GameObject stomach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Input.GetMouseButtonDown(0)){ // if left button pressed...
     Ray ray = cam.ScreenPointToRay(Input.mousePosition);
     RaycastHit hit ;
     bool aux = Physics.Raycast(ray,out hit);
     Debug.Log(aux);
     if (aux){
       // the object identified by hit.transform was clicked
       // do whatever you want
       if (hit.collider.transform.parent.gameObject.name == "ButtonSwallow"){
           Debug.Log("swallow!");
       
       }
     }
   }*/
    }
    void OnMouseDown(){
         // this object was clicked - do something
         int n_chews = Random.Range(2,7);
         float init_prob=90f;
         Debug.Log("chews "+n_chews);

         int n_pieces = abnormalRandom(n_chews,init_prob);

         int size = 8;
         int Msize=size-n_pieces+1;
         for (int j = 0; j<n_pieces; j++){
             Msize=size-(n_pieces-j)+1;
             int s = Random.Range(1,Msize);
             stomach.GetComponent<SpamFood>().AddObject(s);
             size=size-s;
             Debug.Log("size " + j + " sausage size " + s + " n pieces "+n_pieces);
          }
         Debug.Log("swallow!");
         Debug.Log("pieces" + n_pieces);
     //Destroy (this.gameObject);
  }   
  int abnormalRandom(int N, float init_prob){
      int n_out=0;
      for (int i = 0; i <= N; i++){
            if (n_out==0){
              if (Random.Range(0,1)<init_prob){
                  n_out = N-i;
                  
              Debug.Log("n_out "+n_out+" N " + N + i);
              }else{
                  init_prob-=20;
              }
            }
              if (i==N){
                  if(n_out==0){
                      Debug.Log("here");
                      n_out=1;
                  }
              }
          }
        return n_out;
  }
}
