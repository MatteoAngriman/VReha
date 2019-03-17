using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dodge : MonoBehaviour
{
    public GameObject player;
    public GameObject[] proiettili = new GameObject[3];
    public PatientManager pat;
    public Transform playerPos;
    public Rigidbody rb;
    [Range(0f,10f)]
    public float speed = 5.0f;
    public static int points = 0;
    public float wait = 2.0f;
    public float timer = 0.0f;
    public int maxBalls = 20;
    public int ballShooted = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");     //searching for the Player
        Debug.Log("Found the player");
        playerPos = player.transform;  //aiming to the player
        pat = GameObject.FindObjectOfType(typeof(PatientManager)) as PatientManager;
    }

    private void Shoot()
    {
       Debug.Log ("BANG");
        //Debug.Log(playerPos);
       int r = (int)Random.Range(0, 2);
       //Debug.Log("L'indice per lo spawn è: " + r);
       Vector3 r3 = new Vector3(Random.Range(-0.50f, 0.50f), Random.Range(0f, 0.65f), 0);
       //Quaternion rot = Quaternion.Euler(r3);
       GameObject proiettile = Instantiate(proiettili[r], this.transform.position + r3, this.transform.rotation);
       rb = proiettile.GetComponent<Rigidbody>();
        //palla.transform.position = Vector3.MoveTowards(this.transform.position, playerPos, speed * Time.deltaTime);
       rb.AddForce(transform.forward * speed , ForceMode.Impulse);
        //Debug.Log(rb.velocity);
        ballShooted++;
    }
    // Update is called once per frame
    void Update()
    {
        if (player != null) //true aiming to the player
        {
            this.transform.LookAt(playerPos);
        }

            
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > wait && ballShooted< maxBalls)
        {
            Shoot();
            timer = 0f;
        }
        if (ballShooted == maxBalls && timer > 5.0f)
        {
            Debug.Log("FINE");
            if(pat != null)
                pat.AddScore(1, points);
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            ReturnMainMenu();
        }
    }

    void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
