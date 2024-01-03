using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Transform player;
    public GameObject winPanel;
    //public List<Transform> NPCs;
    public Transform pat1;
    public Transform pat2;
    public Transform pat3;
    public Transform pat4;
    public Text text;
    float startTime = 0;
    float endTime = 0;
    
    private void Start()
    {
        player = GameObject.Find("SpiderDrone").transform;
        startTime = Time.time;
        //Debug.Log(NPCs);
    }

    // Update is called once per frame
    void Update()
    {
        //float x = Vector3.Distance(player.position, transform.position);
        //Debug.Log(x);
        if (Vector3.Distance(player.position, transform.position) <= 0.75)
        {
            Debug.Log("win");
            endTime = Time.time;
            text.text = endTime - startTime + " seconds";
            winPanel.SetActive(true);
        }

        //for (int i = 0; i <= 3; i++)
        //{
        //    if (Vector3.Distance(player.transform.position, NPCs[i].transform) <= 1)
        //    {
        //        SceneManager.LoadScene("Creative_Project_2");
        //    }
        //}

        if ((Vector3.Distance(player.transform.position, pat1.position) < 1.5) || (Vector3.Distance(player.transform.position, pat2.position) < 1.5) || (Vector3.Distance(player.transform.position, pat1.position) < 1.5) || (Vector3.Distance(player.transform.position, pat1.position) < 1.5))
        {
            SceneManager.LoadScene("Creative_Project_2");
        }
    }

    public void OnRestart()
    {
        SceneManager.LoadScene("Creative_Project_2");
    }
}