using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneToLoad;




    public void Retry()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
