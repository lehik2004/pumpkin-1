using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    

    public void OnClickPlay(string _nameScene)
    {
        
        SceneManager.LoadScene(_nameScene);
    }
}
