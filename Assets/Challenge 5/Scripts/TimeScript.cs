using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimeScript : MonoBehaviour

    

{
    public float timestart = 60;
    public TextMeshProUGUI textbox;
    private GameManagerX gameManagerX;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = timestart.ToString();
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerX.isGameActive)
        {
            timestart -= Time.deltaTime;
            textbox.text = Mathf.Round(timestart).ToString();

        }
    }
}
