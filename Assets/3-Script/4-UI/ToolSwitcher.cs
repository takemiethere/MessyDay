using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] tools; // An array of the tool game objects to be switched

    private int activeTool = 0; // Index of the currently active tool

    private void Start()
    {
        // Deactivate all tools except the first one at the start of the game
        for (int i = 1; i < tools.Length; i++)
        {
            tools[i].SetActive(false);
        }
    }

    private void Update()
    {
        // Switch between tools when 1, 2, or 3 keys are pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchTool(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchTool(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchTool(2);
        }
    }

    private void SwitchTool(int index)
    {
        // Deactivate all tools except the one at the specified index
        for (int i = 0; i < tools.Length; i++)
        {
            if (i != index)
            {
                tools[i].SetActive(false);
            }
        }

        // Activate the tool at the specified index
        tools[index].SetActive(true);

        activeTool = index;
    }

    public int GetActiveToolIndex()
    {
        return activeTool;
    }
}
