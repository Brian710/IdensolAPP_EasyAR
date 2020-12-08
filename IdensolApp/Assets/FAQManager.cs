using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAQManager : MonoBehaviour
{
    [SerializeField]private List<Collider> FAQCollider;
    
    void Update()
    {
        foreach (Collider collider in FAQCollider)
        {
            if (collider.enabled)
                Set();
        }
    }
    private void Set()
    {
        foreach (Collider collider in FAQCollider)
        {
            collider.gameObject.GetComponent<ShowArFAQ>().FAQCanvas.SetActive(false);
            if (collider.enabled)
                collider.gameObject.GetComponent<ShowArFAQ>().Set();
        }
    }
}
