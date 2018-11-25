
namespace VRTK.Examples
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EatFood : MonoBehaviour
    {
        public VRTK_InteractableObject linkedObject;
        public bool Eat = false;
        public float EatTime = 2f;

        GameObject[] portions;
        int currentIndex;
        float lastChange;
        float interval = .5f;

        void Start()
        {
            bool skipFirst = transform.childCount > 4;
            portions = new GameObject[skipFirst ? transform.childCount - 1 : transform.childCount];
            for (int i = 0; i < portions.Length; i++)
            {
                portions[i] = transform.GetChild(skipFirst ? i + 1 : i).gameObject;
                if (portions[i].activeInHierarchy)
                    currentIndex = i;
            }
        }

        void Update()
        {
            if (Time.time - lastChange > interval && Eat == true)
            {
                Consume();
                lastChange = Time.time;
            }
        }

        void Consume()
        {
            if (currentIndex != portions.Length)
                portions[currentIndex].SetActive(false);
            currentIndex++;
            if (currentIndex > portions.Length)
                currentIndex = 0;
            else if (currentIndex == portions.Length)
                return;
            portions[currentIndex].SetActive(true);
        }

        protected virtual void OnEnable()
        {
            Eat = false;
            linkedObject = (linkedObject == null ? GetComponent<VRTK_InteractableObject>() : linkedObject);

            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed += InteractableObjectUsed;
                linkedObject.InteractableObjectUnused += InteractableObjectUnused;
            }

            Eat = transform.Find("Capsule");
        }

        protected virtual void OnDisable()
        {
            if (linkedObject != null)
            {
                linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
                linkedObject.InteractableObjectUnused -= InteractableObjectUnused;
            }
        }

        protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
        {
            Eat = true;
            Debug.Log("in use");
        }

        protected virtual void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
        {
            Eat = false;
        }

    }

}
