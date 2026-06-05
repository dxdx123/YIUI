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
    [FriendOf(typeof(TestPanelComponent))]
    public static partial class TestPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this TestPanelComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this TestPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this TestPanelComponent self)
        {
            // 打开列表 View 并持有引用 (clone 到 AllViewParent)
            self.m_ListView = await self.UIPanel.OpenViewAsync<TestListViewComponent>();
            return true;
        }

        #region YIUIEvent开始

        [YIUIInvoke(TestPanelComponent.OnEventGenerateInvoke)]
        private static void OnEventGenerateInvoke(this TestPanelComponent self)
        {
            TestListViewComponent listView = self.m_ListView;
            if (listView == null)
            {
                Log.Error("[TestPanel] 列表 View 不存在, 无法生成");
                return;
            }

            listView.Refresh(TestPanelComponent.GenerateCount);
            Log.Info($"[TestPanel] 生成列表 {TestPanelComponent.GenerateCount} 条");
        }

        [YIUIInvoke(TestPanelComponent.OnEventCloseInvoke)]
        private static void OnEventCloseInvoke(this TestPanelComponent self)
        {
            self.UIPanel.CloseAsync().NoContext();
        }
        #endregion YIUIEvent结束
    }
}
