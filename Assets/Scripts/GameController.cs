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

    bool busy=false;

    bool chewing=false;
    bool eating=false;
    bool swallowing=false;
    bool drinking=false;

    int n_chews=0;

    string uname="";
    bool start=false;

    string saying="";
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
    public void busyTrue()
    {
        this.busy=true;
    }
    public void busyFalse()
    {
        this.busy=false;
    }
    public bool isBusy()
    {
        return this.busy;
    }

    public void SetNChews(int chews){
        this.n_chews=chews;
    }
    public int GetNChews(){
        return this.n_chews;
    }

    public string GetSaying()
    {
        return this.saying;
    }

    public void SetSaying(string tex)
    {
        this.saying=tex;
    }
    public bool isChewing(){
        return this.chewing;
    }

    public void SetChewing(bool state){
        this.chewing=state;
    }
    public bool isEating(){
        return this.eating;
    }

    public void SetEating(bool state){
        this.eating=state;
    }
    public bool isSwallowing(){
        return this.swallowing;
    }

    public void SetSwallowing(bool state){
        this.swallowing=state;
    }
    public bool isDrinking(){
        return this.drinking;
    }

    public void SetDrinking(bool state){
        this.drinking=state;
    }
    public void StartGame(){
        this.start=true;
    }
    public bool GameStarted(){
        return this.start;
    }
    public string getUname(){
        return this.uname;
    }

    public void SetUname(string state){
        this.uname=state;
    }
}
