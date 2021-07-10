using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    //move speed.
    public float moveSpeed = 5f;
    //rotation speed.
    public float turnSpeed = 5f;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Y-Axis Rotation
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed, 0);

        // Move
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = moveSpeed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }

    //Lose condition, if enemy touches player, player lose.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("NoSurrenderDemo");
        }
    }
}
