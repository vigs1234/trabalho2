using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    public int forcaPulo = 7;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);



        if (Input.GetKeyDown(KeyCode.Space)); 
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }



        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
