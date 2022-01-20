using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public int ScoreToWin;
    public float Score;
    public Text coinscollected;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        coinscollected.GetComponent<Text>();
        coinscollected.text = "Coins Collected: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        coinscollected.text = "Coins Collected: " + Score;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(h, 0, v);
        tempVect = tempVect.normalized * Speed * Time.deltaTime;
        rb.MovePosition(transform.position + tempVect);


        if(Score == ScoreToWin)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hazard")
        {
            SceneManager.LoadScene("GameOver");
        }

        if(collision.gameObject.tag == "Coin")
        {
            Score += 1;
            Destroy(collision.gameObject);
        }
    }
}
