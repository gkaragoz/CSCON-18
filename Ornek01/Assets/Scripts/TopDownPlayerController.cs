using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownPlayerController : MonoBehaviour {

    public float currentAngle = 0f;
    public float projectileSpeed = 15f;

    public Transform projectile;
    public Transform projectile_SP;

    public float movementSpeed = 3f;

    private void Update() {
        Move();
        LookAtToMousePosition();

        if (Input.GetMouseButton(0)) {
            Fire();
        }
    }

    public void LookAtToMousePosition() {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        currentAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);
    }

    public void Move() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontal, vertical, 0f) * movementSpeed * Time.deltaTime;
    }

    public void Fire() {
        GameObject obj = Instantiate(projectile, projectile_SP.position, Quaternion.identity).gameObject;
        obj.GetComponent<Rigidbody2D>().velocity = (projectile_SP.position - transform.position) * projectileSpeed;
    }
}
