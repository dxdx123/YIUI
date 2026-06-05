using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  YIUI
    /// Date    2026.6.5
    /// Desc
    /// </summary>
    [FriendOf(typeof(TestItemComponent))]
    public static partial class TestItemComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this TestItemComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this TestItemComponent self)
        {
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
