using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SashimiInformation : MonoBehaviour
{
  
        public string sashimiType;
        public float currentx;
        public float defaulty = (float)-3.74;

        private void Start()
        {
        }

        void Update()
        {      
                if(transform.position.y > 7){ //if the bullet has moved to far up
                    switch (sashimiType)
                    {
                        case "kai":
                            KaiPool.instance.Push(gameObject); 
                            break;
                        case "uni":
                            UniPool.instance.Push(gameObject); 
                            break;
                        case "salmon":
                            SalmonPool.instance.Push(gameObject); 
                            break;
            
                        default:
                            break;
                    }
                    currentx = transform.position.x;
                       transform.position= new Vector2(currentx,defaulty);
                }
                
        }

       public void Reset()
        {
        }
}
