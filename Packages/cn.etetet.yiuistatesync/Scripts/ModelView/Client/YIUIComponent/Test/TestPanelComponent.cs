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
    public partial class TestPanelComponent : Entity
    {
        // 打开后持有的列表 View 引用
        public EntityRef<TestListViewComponent> m_ListView;

        // 固定生成数量 (最简方案: 点击 Generate 直接生成 N 条)
        public const int GenerateCount = 50;
    }
}
