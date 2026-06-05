using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [FriendOf(typeof(YIUIChild))]
    [EntitySystemOf(typeof(TestItemComponent))]
    public static partial class TestItemComponentSystem
    {
        [EntitySystem]
        private static void Awake(this TestItemComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this TestItemComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this TestItemComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();

            self.u_DataIndex = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueInt>("u_DataIndex");

        }
    }
}
