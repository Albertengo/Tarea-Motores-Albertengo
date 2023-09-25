using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballcontrol : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;
    public GanarScript screen;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
        
        if (Input.GetKey(KeyCode.LeftShift))
            force += 1f;
        if (Input.GetKeyDown(KeyCode.LeftShift))
            force -= 1f;

        direction = direction.normalized;
        rb.AddForce(direction * force, ForceMode.Force);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            scoretext.scoreValue = 0;
        }
        if (collision.gameObject.CompareTag("meta"))
        {
            screen.ActiveScreen();
        }
    }

    private void OnTriggerEnter(Collider other) //para hacer desaparecer las monedas
    { 
        if (other.gameObject.CompareTag("coleccionable") == true) 
        {
            scoretext.scoreValue++;
            other.gameObject.SetActive(false); 
        } 

    }
}
