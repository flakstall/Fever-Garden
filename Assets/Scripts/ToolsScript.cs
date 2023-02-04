using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsScript : MonoBehaviour
{
    public string[] toolTarget = new string[] { "Plant", "Hammer", "Scissors", "Glove" };
    string toolUsed;

    public void Plant()
    {
        toolUsed = toolTarget[0];
    }

    public void Hammer()
    {
        toolUsed = toolTarget[1];
    }

    public void Scissors()
    {
        toolUsed = toolTarget[2];
    }
    public void Glove()
    {
        toolUsed = toolTarget[3];
    }

    private void Update()
    {
        Debug.Log(toolUsed);
    }
}
