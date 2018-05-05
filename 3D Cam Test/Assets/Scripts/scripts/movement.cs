using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class movement : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;
    public float Ragdollstate = 0;
    private Rigidbody rig;
    private float height_convert;

    void Start()
    {
        height_convert = transform.position.y - 1;
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Ragdollstate = Input.GetAxis("Ragdoll");
    }
    
    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Restart"))
            SceneManager.LoadScene("PrefabBuildScene");


        var camera = Camera.main;
        var forward = camera.transform.forward;
        var right = camera.transform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");


        if (Ragdollstate == 1f)
            rig.constraints = RigidbodyConstraints.None;
        else
            rig.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        var moveDirection = horizontalAxis * right + verticalAxis * forward;

        transform.Translate(moveDirection * speed * Time.deltaTime);

        rig.AddForce(moveDirection, ForceMode.Impulse);
    }
}


