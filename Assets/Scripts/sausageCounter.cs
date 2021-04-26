using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

public class sausageCounter : MonoBehaviour
{
        public Text score, timeText;
        private GameController gameControllerObject;
        private LevelController levelControllerObject;
        private float timer=0.0f;
        private const string URL = "https://leaderboardsausagevoid.herokuapp.com/api";
    // Start is called before the first frame update
    void Start()
    {
        gameControllerObject = GameObject.FindWithTag("gameControllerObject").GetComponent<GameController>();
        levelControllerObject = GameObject.FindWithTag("levelControllerObject").GetComponent<LevelController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameControllerObject.GameStarted()){
            timer += Time.deltaTime;
            int seconds = (int) (timer % 60);
            timeText.text = seconds.ToString();
            score.text=gameControllerObject.GetSausages().ToString();
            if (seconds >= 60){
                post();
                levelControllerObject.LoadEnding();
            }
        }
    }

    async System.Threading.Tasks.Task post()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new System.Uri(URL);

        client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));
        string name = gameControllerObject.GetUname();
        string value = gameControllerObject.GetSausages().ToString();
        // List data response.
        var content = new StringContent("{\"name\":\""+ name+"\",\"value\":"+ value.ToString() +",\"volume\":2}", Encoding.UTF8, "application/json");
            Debug.Log("Contenido");
            Debug.Log("{\"name\":"+ name+",\"value\":"+ value.ToString() +",\"volume\":2}");
        HttpResponseMessage response = client.PostAsync(URL, content).Result;
        if (response.IsSuccessStatusCode)
        {
            // Parse the response body.
            Debug.Log("Contenido");
            Debug.Log(response.Content);

            var customerJsonString = await response.Content.ReadAsStringAsync();
            var dataObjects = JsonConvert.DeserializeObject(customerJsonString);
            Debug.Log(customerJsonString);

            // LeaderBoard en customerJsonString.ranking
        }
        else
        {
            Debug.Log("{0} ({1})");
            Debug.Log(response.StatusCode);
            Debug.Log(response.ReasonPhrase);
        }
        client.Dispose();
    }
}
