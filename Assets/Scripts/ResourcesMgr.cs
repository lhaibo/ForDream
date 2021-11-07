using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesMgr : SingletonBase<ResourcesMgr>
{
    /// <summary>
    /// 加载资源
    /// </summary>
    /// <param name="path">资源在Resources文件下的路径</param>
    /// <returns></returns>
    public Object Load(string path)
    {
        return Resources.Load(path);
    }
    /// <summary>
    /// 加载资源
    /// </summary>
    /// <typeparam name="T">资源类型</typeparam>
    /// <param name="path">资源在Resources文件下的路径</param>
    /// <returns></returns>
    public T Load<T>(string path)where T:Object
    {
        return Resources.Load<T>(path);
    }
}
