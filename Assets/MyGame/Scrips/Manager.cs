using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    private GameObject cube4;
    private GameObject cube5;
    private GameObject cube6;
    private GameObject cube7;
    
    void Start()
    {
        cube1 = GameObject.FindWithTag("Num1");
        cube2 = GameObject.FindWithTag("Num2");
        cube3 = GameObject.FindWithTag("Num3");
        cube4 = GameObject.FindWithTag("Num4");
        cube5 = GameObject.FindWithTag("Num5");
        cube6 = GameObject.FindWithTag("Num6");
        cube7 = GameObject.FindWithTag("Num7");

        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cube1.transform.Rotate(90.0f, 0.0f, 0.0f);
            Debug.Log("Wird gedreht!");
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            cube1.transform.Rotate(0.0f, 0.0f, 0.0f);
        }
    }
}
