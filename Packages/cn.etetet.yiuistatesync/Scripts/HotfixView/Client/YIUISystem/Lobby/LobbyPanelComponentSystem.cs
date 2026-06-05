using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    [FriendOf(typeof(LobbyPanelComponent))]
    public static partial class LobbyPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this LobbyPanelComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this LobbyPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this LobbyPanelComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始

        [YIUIInvoke(LobbyPanelComponent.OnEventEnterMapInvoke)]
        private static async ETTask OnEventEnterMapInvoke(this LobbyPanelComponent self)
        {
            self.UIBase.SetActive(false);
            await EnterMapHelper.EnterMapAsync(self.Root());
            await self.UIPanel.CloseAsync();
        }

        
        [YIUIInvoke(LobbyPanelComponent.OnEventOpenTestInvoke)]
        private static void OnEventOpenTestInvoke(this LobbyPanelComponent self)
        {
            self.Root().YIUIRoot().OpenPanelAsync<TestPanelComponent>().NoContext();
        }
        #endregion YIUIEvent结束
    }
}