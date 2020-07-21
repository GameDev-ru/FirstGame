using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Controller : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Player;

    public Rigidbody rb;
    public float force;
    public float jumpForce;
    public bool isGround;

    Vector3 vectorPosition;
    public bool die; 


    public Transform player;
    public Vector3 offset;
    public int lives;
    
    public Action onDie;


    public Text txt;

    void Start()
    {

        die = false;
        rb = Player.GetComponent<Rigidbody>();
   
    }

    void OnTriggerEnter(Collider co)
    {
        if (co.CompareTag("Finish"))
        {
            rb.Sleep();
        }

        if (co.gameObject.tag == "Checkpoint")
        {
            vectorPosition = co.transform.position;

        }
        if (co.gameObject.tag == "DeadZone")
        {
            die = true;
            lives--;
            onDie?.Invoke();
        }
    }

    


    void Update()
    {
        if (txt != null) { txt.text = "lives=" + lives; }

        if (lives == 0) SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Move();
        Jump();
    }
    public void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(MainCamera.transform.forward * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(MainCamera.transform.forward * -force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(MainCamera.transform.right * -force * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(MainCamera.transform.right * force * Time.deltaTime);
        }
    }


    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast(ray, out rh, 0.55f)) isGround = true;
        else isGround = false;

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
            rb.AddForce(Vector3.up * jumpForce);
    }

    IEnumerator NewLevel(Vector3 pos)
    {
        yield return new WaitForSeconds(0);
        gameObject.transform.position = pos + Vector3.forward;
        die = false;
    }

}
