using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    bool hasPackage;
    [SerializeField] float delay = 0.2f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 boostColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("BAM!");
        if(hasPackage){
            spriteRenderer.color = hasPackageColor;
        }
        if(!hasPackage){
            spriteRenderer.color = noPackageColor;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage){
            Debug.Log("Package Picked Up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,delay);
        }
        if (other.tag == "Customer" && hasPackage){
            Debug.Log("Delivered Package!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(other.gameObject,delay);
        }
        if (other.tag == "Boost" && hasPackage){
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,delay);
        }
        if (other.tag == "Boost" && !hasPackage){
            spriteRenderer.color = boostColor;
            Destroy(other.gameObject,delay);
        }
    }
}
