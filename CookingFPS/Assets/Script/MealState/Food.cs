using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Food: MonoBehaviour{
    //private String launch_sound; 
    //private String hit_enemy_sound; 
    //private String miss_enemy_sound;
    //private int damage_points;
    [SerializeField] protected int damage;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Shot(Transform barrelPos, float shootSpeed)
    {
        //this.gameObject.SetActive(true);
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        this.gameObject.GetComponent<Collider>().enabled = true;
        this.gameObject.transform.position = barrelPos.position;
        //this.gameObject.transform.rotation = barrelPos.rotation;

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            // Now you have where your player is and a 3D point the mouse is over
            Vector3 targetDir = hit.point - transform.position;

            Debug.DrawLine(transform.position, hit.point, Color.blue, 5);
            //transform.LookAt(hit.point);
            rb.velocity = Vector3.zero;
            rb.AddForce(targetDir.normalized * shootSpeed, ForceMode.Impulse);
        }

        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Appliance"))
        {
            Cook(other.gameObject);
            other.gameObject.GetComponent<applianceState>().StartCooking(this.gameObject);
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }

    public void PickUp()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<Collider>().enabled = false;
        //this.gameObject.SetActive(false);
    }

    public abstract void Cook(GameObject app);

    public abstract void Remove();
	
} 
