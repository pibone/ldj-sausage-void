using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamFood : MonoBehaviour
{
    public GameObject sampleFood;
    public float max_X, max_Y, min_X, min_Y;

    public void AddObject(int size)
    {
        var x = Random.Range(min_X,max_X);
        var y = Random.Range(min_Y,max_Y);
        GameObject newObject = Instantiate(sampleFood, new Vector2(x, y), Quaternion.Euler(0, 0, Random.Range(0f,360f)));
        newObject.transform.localScale = new Vector3(size,1,1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
