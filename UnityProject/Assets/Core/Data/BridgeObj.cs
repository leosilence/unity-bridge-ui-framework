﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using System;
namespace BridgeUI.Model
{
   
    /// <summary>
    /// 记录面板之间的加载关联
    /// [同时用于之间的数据交流,使用时实例化对象]
    /// </summary>
    [System.Serializable]
    public class BridgeInfo
    {

        #region 加载规则
        public string inNode;
        public ShowModel showModel;
        public string outNode;
        #endregion

     
    }

    public class Bridge
    {
        #region 实例使用
        public BridgeInfo Info { get; private set; }
        public UnityAction<Queue<object>> onGet { get; set; }
        public Queue<object> dataQueue = new Queue<object>();
        public event UnityAction<Bridge> onRelease;
        public event UnityAction<IPanelBase, object> onCallBack;
        public event UnityAction<IPanelBase> onCreate;
        public IPanelBase InPanel { get; private set; }
        public IPanelBase OutPanel { get; private set; }
        private UnityAction<Bridge> onReleaseFromPool { get; set; }
        public Bridge(BridgeInfo info,UnityAction<Bridge> onReleaseFromPool)
        {
            this.Info = info;
            this.onReleaseFromPool = onReleaseFromPool;
        }
        public void Reset(IPanelBase parentPanel)
        {
            this.InPanel = parentPanel;
            this.onCreate = null;
            this.onGet = null;
            this.onCallBack = null;
            this.dataQueue.Clear();
        }

        public void Send(object data)
        {
            dataQueue.Enqueue(data);
            if (onGet != null)
            {
                onGet.Invoke(dataQueue);
            }
        }

        public void CallBack(IPanelBase panel, object data)
        {
            if (onCallBack != null) onCallBack.Invoke(panel, data);
        }

        public void Release()
        {
            if (onRelease != null)
            {
                onRelease(this);
            }
            if(onReleaseFromPool != null)
            {
                onReleaseFromPool(this);
            }
        }

        internal void OnCreatePanel(IPanelBase panel)
        {
            OutPanel = panel;
            if (onCreate != null)
            {
                onCreate.Invoke(panel);
            }
        }
        #endregion
    }
}