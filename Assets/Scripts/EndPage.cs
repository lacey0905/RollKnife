using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndPage : MonoBehaviour
{

    public Text score;
    public Button replay;

    private void Start()
    {
        
    }

    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
