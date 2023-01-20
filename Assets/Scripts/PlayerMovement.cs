using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Transform transform;
    public float speed = 0.5f;
    public float rotationSpeed = 0.5f;
    public ScoreManager ScoreValue;

    public GameObject bulletPrefab;
    public float bulletSpeed = 5;

    public GameObject GameOverPanel;

    public int CoinCounter = 0;
    public int FuelCounter = 0;
    public Text coinText;
    public Text fuelText;


    void Start()
    {
        
    }

    void Update()
    {
        Movment();
        Shooting();
        Clamp();
        coinText.text = ("Coin: " + CoinCounter.ToString());
        fuelText.text = ("Fuel: " + FuelCounter.ToString());
    }

    void Movment()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(speed * Time.deltaTime , 0 , 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -50), rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3(speed * Time.deltaTime , 0 , 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 50), rotationSpeed * Time.deltaTime);
        }
        if(transform.rotation.z != 90){
            rotationSpeed = 10;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), rotationSpeed * Time.deltaTime);
        }
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
             GameObject bullet = Instantiate(bulletPrefab);
             bullet.transform.SetParent(transform.parent);
             bullet.transform.position = transform.position;
             bullet.GetComponent<Rigidbody2D>().velocity = new Vector3(0, bulletSpeed, transform.position.z);
             Destroy(bullet, 5);
        }
    }

    void Clamp()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.85f, 2.85f);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Enemy"){
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if(collision.gameObject.tag == "Coin"){
            CoinCounter += 1;
            ScoreValue.score +=5;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Fuel"){
            FuelCounter += 1;
            Destroy(collision.gameObject);
        }
    }
}
 