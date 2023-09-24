﻿
using Godot;

namespace DsUi
{
    /// <summary>
    /// Ui网格组件基础接口, 无泛型
    /// </summary>
    public interface IUiGrid : IDestroy
    {
        /// <summary>
        /// 当前选中的 Cell 索引
        /// </summary>
        int SelectIndex { get; set; }
        
        /// <summary>
        /// 设置网格组件是否可见
        /// </summary>
        bool Visible { get; set; }
        
        /// <summary>
        /// 当前网格组件数据大小
        /// </summary>
        int Count { get; }
        
        /// <summary>
        /// Godot 原生网格组件
        /// </summary>
        GridContainer GridContainer { get; }

        /// <summary>
        /// 触发 Cell 的点击事件
        /// </summary>
        /// <param name="index">cell的索引</param>
        void Click(int index);
    }
}