using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private Dictionary<string, GameObject> cubes = new Dictionary<string, GameObject>();
    private Dictionary<string, Quaternion> originalRotations = new Dictionary<string, Quaternion>();

    private GameObject mainCube;

    private void Start()
    {
        string[] tags = { "Num1", "Num2", "Num3", "Num4", "Num5", "Num6", "Num7", "Num8", "Cube" };
        
        foreach (string tag in tags)
        {
            GameObject obj = GameObject.FindWithTag(tag);
            if (obj)
            {
                cubes[tag] = obj;
                originalRotations[tag] = obj.transform.rotation;
            }
        }

        mainCube = cubes.ContainsKey("Cube") ? cubes["Cube"] : null;
    }

    private void SetRotationAndColor(string tag, Vector3 rotation, Color color)
    {
        if (cubes.ContainsKey(tag))
        {
            cubes[tag].transform.rotation = Quaternion.Euler(rotation);
            cubes[tag].GetComponent<Renderer>().material.color = color;
        }
    }

    private void ResetRotationAndColor(string tag, Color color)
    {
        if (cubes.ContainsKey(tag))
        {
            cubes[tag].transform.rotation = originalRotations[tag];
            cubes[tag].GetComponent<Renderer>().material.color = color;
        }
    }

    private void HandleKeyPress(KeyCode key)
    {
        switch (key)
        {
            case KeyCode.Alpha1:
                SetRotationAndColor("Num1", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num2", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num5", new Vector3(0, 90, -90), Color.black);
                SetRotationAndColor("Num6", new Vector3(0, 90, -90), Color.black);
                SetRotationAndColor("Num7", new Vector3(0, 90, -90), Color.black);
                break;
            case KeyCode.Alpha2:
                SetRotationAndColor("Num1", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num3", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha3:
                SetRotationAndColor("Num1", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num2", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha4:
                SetRotationAndColor("Num2", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num5", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num6", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha5:
                SetRotationAndColor("Num2", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num4", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha6:
                SetRotationAndColor("Num4", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha7:
                SetRotationAndColor("Num1", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num2", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num6", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num7", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha8:
                break;
            case KeyCode.Alpha9:
                SetRotationAndColor("Num2", new Vector3(0, -90, -90), Color.black);
                SetRotationAndColor("Num6", new Vector3(0, -90, -90), Color.black);
                break;
            case KeyCode.Alpha0:
                SetRotationAndColor("Num7", new Vector3(0, -90, -90), Color.black);
                break;
        }
        if (mainCube) mainCube.GetComponent<Renderer>().material.color = Color.white;
    }

    private void HandleKeyRelease(KeyCode key)
    {
        switch (key)
        {
            case KeyCode.Alpha1:
                ResetRotationAndColor("Num1", Color.blue);
                ResetRotationAndColor("Num2", Color.blue);
                ResetRotationAndColor("Num5", Color.blue);
                ResetRotationAndColor("Num6", Color.blue);
                ResetRotationAndColor("Num7", Color.blue);
                break;
            case KeyCode.Alpha2:
                ResetRotationAndColor("Num1", Color.blue);
                ResetRotationAndColor("Num3", Color.blue);
                break;
            case KeyCode.Alpha3:
                ResetRotationAndColor("Num1", Color.blue);
                ResetRotationAndColor("Num2", Color.blue);
                break;
            case KeyCode.Alpha4:
                ResetRotationAndColor("Num2", Color.blue);
                ResetRotationAndColor("Num5", Color.blue);
                ResetRotationAndColor("Num6", Color.blue);
                break;
            case KeyCode.Alpha5:
                ResetRotationAndColor("Num2", Color.blue);
                ResetRotationAndColor("Num4", Color.blue);
                break;
            case KeyCode.Alpha6:
                ResetRotationAndColor("Num4", Color.blue);
                break;
            case KeyCode.Alpha7:
                ResetRotationAndColor("Num1", Color.blue);
                ResetRotationAndColor("Num2", Color.blue);
                ResetRotationAndColor("Num6", Color.blue);
                ResetRotationAndColor("Num7", Color.blue);
                break;
            case KeyCode.Alpha9:
                ResetRotationAndColor("Num2", Color.blue);
                ResetRotationAndColor("Num6", Color.blue);
                break;
            case KeyCode.Alpha0:
                ResetRotationAndColor("Num7", Color.blue);
                break;
        }
        if (mainCube) mainCube.GetComponent<Renderer>().material.color = Color.magenta;
    }

    private void Update()
    {
        foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key)) HandleKeyPress(key);
            if (Input.GetKeyUp(key)) HandleKeyRelease(key);
        }
    }
}
