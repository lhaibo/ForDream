using UnityEngine;
namespace HBFramework
{
    /// <summary>
    /// 单例mono基类
    /// </summary>
    /// <typeparam name="T">单例mono类</typeparam>
    public class SingletonBaseMono<T> : MonoBehaviour where T : SingletonBaseMono<T>
    {
        private static T _instance;
        /// <summary>
        /// 单例
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameObject(typeof(T).Name).AddComponent<T>();
                    DontDestroyOnLoad(_instance.gameObject);
                }
                return _instance;
            }
            private set { _instance = value; }
        }

        private void Awake()
        {
            Instance = (T)this;
        }
    }
}
