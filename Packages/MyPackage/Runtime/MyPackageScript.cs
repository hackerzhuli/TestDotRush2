using UnityEngine;

namespace MyPackage
{
    public class MyPackageScript : MonoBehaviour {
        private int _count = 0;

        /// <summary>
        /// calc a number
        /// </summary>
        /// <returns></returns>
        public static int Calc()
        {
            return 1 + 1;
        }

        void Start()
        {
        
        }

        void Update()
        {
            _count++;
            _count++;
            _count++;
            _count++;
        }
    }
}
