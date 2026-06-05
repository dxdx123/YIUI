using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET.Client
{
    /// <summary>
    /// Author  YIUI
    /// Date    2026.6.5
    /// Desc
    /// </summary>
    [FriendOf(typeof(TestListViewComponent))]
    [FriendOf(typeof(TestItemComponent))]
    public static partial class TestListViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this TestListViewComponent self)
        {
            // 绑定循环列表: owner=LoopScrollRect, item=TestItemComponent (无点击事件重载)
            self.m_Loop = self.AddChild<YIUILoopScrollChild, LoopScrollRect, Type>(self.u_ComLoopList, typeof(TestItemComponent));
        }

        [EntitySystem]
        private static void Destroy(this TestListViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this TestListViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        /// <summary>
        /// 用指定数量刷新列表 (数据 = 0..count-1)
        /// </summary>
        public static void Refresh(this TestListViewComponent self, int count)
        {
            List<int> list = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }

            self.Loop.SetDataRefresh(list, 0).NoContext();
        }

        [EntitySystem]
        private static void YIUILoopRenderer(this TestListViewComponent self, TestItemComponent item, int data, int index, bool select)
        {
            item.u_DataIndex.SetValue(index);
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
