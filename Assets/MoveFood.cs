namespace VRTK.Examples
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MoveFood : MonoBehaviour
    {

        public VRTK_InteractableObject linkedObject;
        private bool teleport;
        // Use this for initialization
        void Start()
        {
            if (linkedObject.transform.position.y < 1)
            {
                teleport = false;
            }
            else
            {
                teleport = true;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (linkedObject.transform.position.y < 1.9 && teleport == true)
            {
                linkedObject.transform.position = new Vector3(0f, 0f, 0f);
            }
        }
        protected virtual void OnEnable()
        {
          
            linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed += InteractableObjectUsed;
                linkedObject.InteractableObjectUnused += InteractableObjectUnused;
            }

            
        }

        protected virtual void OnDisable()
        {
            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
                linkedObject.InteractableObjectUnused -= InteractableObjectUnused;
            }
        }
    }
}