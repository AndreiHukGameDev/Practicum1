using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    private float speed = 20f;
    public Camera camera;
    public Camera cameraHoodCar;

    public GameObject player;

    private void Start()
    {
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && player.transform.rotation.y >= -0.425 && player.transform.position.x >= -8.6)
        {
            player.transform.Translate(Vector3.left * speed * Time.deltaTime);

            player.transform.Rotate(Vector3.down * (speed * 2) * Time.deltaTime);
            if (player.transform.position.z < 0)
            {
                player.transform.Translate(Vector3.forward * (speed * 0.25f) * Time.deltaTime);

            }
        }

        if (Input.GetKey(KeyCode.D) && player.transform.rotation.y <= 0.425 && player.transform.position.x <= 8.6)
        {
            player.transform.Translate(Vector3.right * speed * Time.deltaTime);
            player.transform.Rotate(Vector3.up * (speed * 2) * Time.deltaTime);
            if (player.transform.position.z < 0)
            {
                player.transform.Translate(Vector3.forward * (speed * 0.25f) * Time.deltaTime);

            }
        }

        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) && player.transform.rotation.y != 0)
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //Change camera
        if (Input.GetKey(KeyCode.C))
        {

            cameraHoodCar.enabled = !cameraHoodCar.enabled;
            camera.enabled = !camera.enabled;

        }
    }
    //ACCIDENT
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Road")
        {
            Destroy(collision.gameObject);
            MultyPlayerScoreCounter.MinusCount(player);
            ScoreCounter.MinusCount();
        }
    }
}

