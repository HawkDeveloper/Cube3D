using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;
    public float speed = 10f;
    public GameObject completeLevelUI;

    private void FixedUpdate() {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex ); 
        }
         if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); 
        }
        
    }
   
    
    private void OnTriggerEnter(Collider other) {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            completeLevelUI.SetActive(true);
        }
        if(this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach(Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = false;
            }
        }
    }
    private void OnTriggerExit(Collider other) 
    {
         if(this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach(Activator button in FindObjectsOfType<Activator>())
            {
                button.canPush = true;
            }
        }
    }

    public void OnLeftButtonDown()
    {
        GetComponent<Rigidbody>().velocity -= moveDirection *speed;
    }
    public void OnRightButtonDown()
    {
        GetComponent<Rigidbody>().velocity += moveDirection *speed;
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

