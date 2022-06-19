using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyNewCript : MonoBehaviour
{
    public GameObject planeOne;
    public GameObject planeTwo;
    public GameObject planeThree;
    int i=0;

    // Start is called before the first frame update
    void Start()
    {
        this.planeOne.SetActive(true);
        this.planeTwo.SetActive(false);
        this.planeThree.SetActive(false);
        this.i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.planeOne != null && this.i==0)
            {
                this.planeThree.SetActive(false);
                this.planeOne.SetActive(!this.planeOne.activeSelf);         
            }                      

            if (this.planeTwo != null && this.i==1)
            {
                this.planeOne.SetActive(false);
                this.planeTwo.SetActive(!this.planeTwo.activeSelf);
            }
            
            if (this.planeThree != null && this.i==2)
            {
                this.planeTwo.SetActive(false);
                this.planeThree.SetActive(!this.planeThree.activeSelf);         
            }

            this.i = this.i > 2 ? 0 : this.i + 1;
        }
    }
}
