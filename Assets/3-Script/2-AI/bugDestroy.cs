using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugDestroy : MonoBehaviour
{
    public float clickTime = 3f;
    public float maxDistance = 3f;
    public Material redMaterial;
    public float flashSpeed = 0.1f;
    public ParticleSystem particleSystem; // The particle system prefab to instantiate
    private float clickTimer;
    private bool isCursorOverObject;
    private bool isDestroying;
    private Renderer renderer;
    private Material defaultMaterial;
    private float flashTimer;
    private BugDestroyUI bugsDestroyUI;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        defaultMaterial = renderer.material;
        bugsDestroyUI = FindObjectOfType<BugDestroyUI>();
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.collider == GetComponent<Collider>())
        {
            float distance = Vector3.Distance(transform.position, hit.point);
            if (distance <= maxDistance)
            {
                isCursorOverObject = true;
            }
            else
            {
                isCursorOverObject = false;
            }
        }
        else
        {
            isCursorOverObject = false;
        }

        if (Input.GetMouseButton(0))
        {
            if (isCursorOverObject)
            {
                if (!isDestroying)
                {
                    clickTimer += Time.deltaTime;
                    if (clickTimer >= clickTime)
                    {
                        isDestroying = true;
                        renderer.material = redMaterial; // set the material to red
                        // Instantiate the particle system at the position of the bug
                        Instantiate(particleSystem, transform.position, Quaternion.identity);
                        bugsDestroyUI.BugDestroyed();
                        Destroy(gameObject, 0.5f);
                    }
                    else
                    {
                        flashTimer += Time.deltaTime;
                        if (flashTimer >= flashSpeed)
                        {
                            if (renderer.material == defaultMaterial)
                            {
                                renderer.material = redMaterial;
                            }
                            else
                            {
                                renderer.material = defaultMaterial;
                            }
                            flashTimer = 0f;
                        }
                    }
                }
            }
        }
    }
}