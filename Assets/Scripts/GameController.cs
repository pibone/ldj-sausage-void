using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameController : MonoBehaviour
{
    //readonly VarRepo<float> stomachFullnessRepo = new VarRepo<float>(0.0f);

    [SerializeField]
    int Sausages = 0;

    [SerializeField]
    float Fullness = 0;

    [SerializeField]
    float Thirstyness = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float RetrieveBoundedValue(float value, float min, float max)
    {
        return Mathf.Max(min, Mathf.Min(max, value));
    }

    public void SetFullness(float value)
    {   
        this.Fullness = RetrieveBoundedValue(value, 0, 100);
    }

    public void AddFullness(float value)
    {
        this.SetFullness(this.Fullness + value);
    }

    public float GetFullness()
    {
        return this.Fullness;
    }

    public void ResetFullness()
    {
        this.Fullness = 0;
    }

    public void SetSausages(int value)
    {
        this.Sausages = (int)RetrieveBoundedValue(value, 0, 1000);
    }

    public void AddSausages(int value)
    {
        this.SetSausages(this.Sausages + value);
    }

    public int GetSausages()
    {
        return this.Sausages;
    }

    public void ResetSausages()
    {
        this.Sausages = 0;
    }

    public void SetThirstyness(float value)
    {
        this.Thirstyness = RetrieveBoundedValue(value, 0, 100);
    }

    public void AddThirstyness(float value)
    {
        this.SetThirstyness(this.Thirstyness + value);
    }

    public float GetThirstyness()
    {
        return this.Thirstyness;
    }

    public void ResetThirstyness()
    {
        this.Thirstyness = 0;
    }
}
