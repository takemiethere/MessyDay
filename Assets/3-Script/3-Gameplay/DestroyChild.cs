using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DestroyChild : MonoBehaviour
{
    public GameObject target;
    public Material redMaterial;
    public Material defaultMaterial;
    public TextMeshProUGUI countText;

    private bool isInZone = false;
    private int destroyedCount = 0;
    private int maxdestroyedCount = 10;

    private ToolSwitcher toolSwitcher;

    private void Start()
    {
        toolSwitcher = FindObjectOfType<ToolSwitcher>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Check if the target has at least one child before turning the zone red
            if (target.transform.childCount > 0)
            {
                isInZone = true;
                Debug.Log("Player entered zone");
                GetComponent<Renderer>().material = redMaterial;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInZone = false;
            Debug.Log("Player exited zone");
            GetComponent<Renderer>().material = defaultMaterial;
        }
    }

    private void Update()
    {
        if (isInZone && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Destroying child objects");
            foreach (Transform child in target.GetComponentsInChildren<Transform>())
            {
                if (child.gameObject != target.gameObject)
                {
                    Destroy(child.gameObject);
                    destroyedCount++;
                }
            }
            if (destroyedCount >= maxdestroyedCount)
            {
                FindObjectOfType<SuccessScene>().TaskCompleted(0, 5); // task index 0 corresponds to taking out the trash
            }
            countText.text = "Throw the trash  " + destroyedCount + "/" + maxdestroyedCount;
        }
    }

    private void OnMouseDown()
    {
        if (toolSwitcher.GetActiveToolIndex() == 0) // Check if the active tool is the first tool
        {
            // Perform the action for taking the trash to the bin
        }
    }
}