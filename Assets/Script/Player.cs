using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ITF
{
    public GameObject projectilePrefabW;
    public GameObject projectilePrefabQ;
    public GameObject projectilePrefabE;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Kill();
        Death();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player Direction Inputs
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(projectilePrefabW, transform.position, projectilePrefabW.transform.rotation);
            Debug.Log(Gun(2));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(projectilePrefabQ, transform.position, projectilePrefabQ.transform.rotation);
            Debug.Log(Gun(2,5));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(projectilePrefabE, transform.position, projectilePrefabE.transform.rotation);
            Debug.Log(Gun(2,5,8));
        }
    }

        public void Kill()
        {
            Debug.Log("Kill function");
        }
        public void Death(){
            Debug.Log("Death function");
        }
        public int Gun(int a){
            return a;
        }
        public int Gun(int a, int b){
            return a+b;
        }
        public int Gun(int a,int b,int c){
            return a+b+c;
        }
}